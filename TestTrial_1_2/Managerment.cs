using Repository.Models;
using Repository.Servcie;
using System.Data;


namespace A_TestTrial_1_2
{
    public partial class Managerment : Form
    {
        PetService _petService;
        PetGroupService _petGroupService;
        PetShopMember _acc;
        public Managerment(PetShopMember acc)
        {
            _acc = acc;
            _petService = new PetService();
            _petGroupService = new PetGroupService();
            InitializeComponent();

            //Setting
            txtID.ReadOnly = true;
            // Set DataGridView properties to lock user interaction
            dgvPet.ReadOnly = true;
            dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Load combobox
            var listGroupType = _petGroupService.GetAll();
            cbGroupType.DataSource = listGroupType;
            cbGroupType.DisplayMember = "PetGroupName";
            cbGroupType.ValueMember = "PetGroupId";
            cbGroupType.DropDownStyle = ComboBoxStyle.DropDownList;
            //Load petList first
            List<Pet> petList = _petService.GetAll();
            _ = _acc != null ? getDataToGrid(petList) : MessageBox.Show("You dont have permistion to access this page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Setting dataGridview

            dgvPet.Columns[0].Width = 50;
            dgvPet.Columns[3].Width = 190;
            dgvPet.Columns[4].Width = 60;
        }
        internal Object getDataToGrid(Object dataSource)
        {
            return dgvPet.DataSource = dataSource;
        }
        internal void clearTextBox()
        {
            txtID.Text = string.Empty;
            txtDecription.Text = string.Empty;
            txtPetName.Text = string.Empty;
            nudQuantity.Value = 0;
            dtpImportDate.Text = string.Empty;
            nudPrice.Value = 0;
        }
        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow seletedRow = dgvPet.Rows[e.RowIndex];
                txtID.Text = seletedRow.Cells[0].Value.ToString();
                txtPetName.Text = seletedRow.Cells[1].Value.ToString();
                dtpImportDate.Text = seletedRow.Cells[2].Value.ToString();
                txtDecription.Text = seletedRow.Cells[3].Value.ToString();
                nudQuantity.Value = Convert.ToInt32(seletedRow.Cells[4].Value);
                nudPrice.Value = Convert.ToInt32(seletedRow.Cells[5].Value);
                PetGroup petGroup = _petGroupService.GetAll().Where(p => p.PetGroupId == seletedRow.Cells[6].Value.ToString()).FirstOrDefault();
                cbGroupType.Text = petGroup.PetGroupName;
            }
        }
        //private void dgvPet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow seletedRow = dgvPet.Rows[e.RowIndex];
        //        txtID.Text = seletedRow.Cells[0].Value.ToString();
        //        txtPetName.Text = seletedRow.Cells[1].Value.ToString();
        //        dtpImportDate.Text = seletedRow.Cells[2].Value.ToString();
        //        txtDecription.Text = seletedRow.Cells[3].Value.ToString();
        //        nudQuantity.Value = Convert.ToInt32(seletedRow.Cells[4].Value);
        //        nudPrice.Value = Convert.ToInt32(seletedRow.Cells[5].Value);
        //        PetGroup petGroup = _petGroupService.GetAll().Where(p => p.PetGroupId == seletedRow.Cells[6].Value.ToString()).FirstOrDefault();
        //        cbGroupType.Text = petGroup.PetGroupName;
        //    }
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_acc != null)
            {
                if (txtPetName.Text != string.Empty && txtDecription.Text != string.Empty)
                {
                    DateTime selectedDate = dtpImportDate.Value;
                    int selectedYear = selectedDate.Year;
                    Pet lastPet = _petService.GetAll().LastOrDefault();
                    Pet pet = new Pet()
                    {
                        PetId = lastPet.PetId + 1,
                        PetDescription = txtDecription.Text,
                        PetName = txtPetName.Text,
                        Quantity = Convert.ToInt32(nudQuantity.Value),
                        ImportDate = selectedDate,
                        PetPrice = Convert.ToInt32(nudPrice.Value),
                        PetGroupId = cbGroupType.SelectedValue.ToString(),
                    };
                    bool added = _petService.Add(pet);
                    if (added)
                    {
                        clearTextBox();
                        List<Pet> petList = _petService.GetAll();
                        getDataToGrid(petList);
                    }
                }
                else
                {
                    MessageBox.Show("You must fill all the information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("You dont have permistion to access this page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                Pet getPet = _petService.GetAll().Where(p => p.PetId == id).FirstOrDefault();
                if (getPet != null)
                {
                    getPet.PetName = txtPetName.Text;
                    getPet.ImportDate = dtpImportDate.Value;
                    getPet.PetDescription = txtDecription.Text;
                    getPet.Quantity = Convert.ToInt32(nudQuantity.Value);
                    getPet.PetPrice = Convert.ToInt32(nudPrice.Value);
                    getPet.PetGroupId = cbGroupType.SelectedValue.ToString();
                }
                bool updated = _petService.Update(getPet);
                if (updated)
                {
                    clearTextBox();
                    List<Pet> petList = _petService.GetAll();
                    getDataToGrid(petList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid id to update", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (_acc != null)
            {
                try
                {
                    id = int.Parse(txtID.Text);
                    Pet pet = _petService.GetAll().Where(p => p.PetId == id).FirstOrDefault();
                    DialogResult result = MessageBox.Show("Are you sure to prefrom this task!", "Wraning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool isDelete = _petService.Remove(pet);
                        if (isDelete)
                        {
                            clearTextBox();
                            List<Pet> petList = _petService.GetAll();
                            getDataToGrid(petList);
                            //Message delete 
                            MessageBox.Show("Delete sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Nothing was change!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid id to delete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("You dont have permistion to access this page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            String key = txtSearch.Text;
            List<Pet> searchResult = _petService.SearchByKeyword(pet => pet.PetPrice.ToString().Contains(key) || pet.Quantity.ToString().Contains(key));
            getDataToGrid(searchResult);
        }


    }
}
