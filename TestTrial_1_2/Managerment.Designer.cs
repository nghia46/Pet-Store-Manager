namespace A_TestTrial_1_2
{
    partial class Managerment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPet = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            txtPetName = new TextBox();
            txtDecription = new TextBox();
            dtpImportDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbGroupType = new ComboBox();
            label9 = new Label();
            txtID = new TextBox();
            btnSearch = new Button();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvPet
            // 
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(382, 43);
            dgvPet.Name = "dgvPet";
            dgvPet.RowTemplate.Height = 25;
            dgvPet.Size = new Size(721, 429);
            dgvPet.TabIndex = 0;
            dgvPet.CellContentClick += dgvPet_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(460, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(477, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(382, 7);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(12, 160);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(218, 23);
            txtPetName.TabIndex = 4;
            // 
            // txtDecription
            // 
            txtDecription.Location = new Point(12, 248);
            txtDecription.Multiline = true;
            txtDecription.Name = "txtDecription";
            txtDecription.Size = new Size(218, 92);
            txtDecription.TabIndex = 5;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(12, 204);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(218, 23);
            dtpImportDate.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Pet Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 11;
            label3.Text = "Inport Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Decription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(12, 343);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(12, 387);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(12, 431);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 15;
            label7.Text = "Group";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(12, 25);
            label8.Name = "label8";
            label8.Size = new Size(350, 71);
            label8.TabIndex = 16;
            label8.Text = "Pet Manager";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(260, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 90);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(260, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 90);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(260, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 90);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbGroupType
            // 
            cbGroupType.FormattingEnabled = true;
            cbGroupType.Location = new Point(12, 449);
            cbGroupType.Name = "cbGroupType";
            cbGroupType.Size = new Size(218, 23);
            cbGroupType.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Coral;
            label9.Location = new Point(12, 98);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 22;
            label9.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(218, 23);
            txtID.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(943, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(12, 361);
            nudQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(218, 23);
            nudQuantity.TabIndex = 24;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(12, 405);
            nudPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(218, 23);
            nudPrice.TabIndex = 25;
            // 
            // Managerment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 485);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(btnSearch);
            Controls.Add(label9);
            Controls.Add(txtID);
            Controls.Add(cbGroupType);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpImportDate);
            Controls.Add(txtDecription);
            Controls.Add(txtPetName);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvPet);
            Name = "Managerment";
            Text = "Managerment";
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPet;
        private TextBox txtSearch;
        private Label label1;
        private TextBox txtPetName;
        private TextBox txtDecription;
        private DateTimePicker dtpImportDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbGroupType;
        private TextBox textBox1;
        private Label label9;
        private TextBox txtID;
        private Button btnSearch;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
    }
}