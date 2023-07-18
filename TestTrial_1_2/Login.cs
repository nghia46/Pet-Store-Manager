using A_TestTrial_1_2;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Repository.Models;
using Repository.Servcie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTrial_1_2
{
    public partial class Login : Form
    {
        public static bool isLogined { get; private set; }
        PetShopMemberServcie _petShopMemberServcie;
        public Login()
        {

            _petShopMemberServcie = new PetShopMemberServcie();

            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtEmail.Text = "staff@PetStore.com.au";
            txtPassword.Text = "@2";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PetShopMember acc = _petShopMemberServcie.GetAll().Where(p => p.EmailAddress == txtEmail.Text && p.MemberPassword == txtPassword.Text).FirstOrDefault();
            if (acc != null && acc.MemberRole == 2)
            {
                Managerment managerment = new Managerment(acc);
                //isLogined = true;
                managerment.Show();
                this.Hide();
                return;
            }
            else
            {
                //isLogined = false;
                MessageBox.Show("You have no permistion to access this funtion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
