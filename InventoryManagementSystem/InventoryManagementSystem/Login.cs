using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if(textPassword.PasswordChar == '*')
            {
                textPassword.PasswordChar = '\0';
            }
            else if (textPassword.PasswordChar == '\0')
            {
                textPassword.PasswordChar = '*';
            }
               
                
                
            
            




        }
    }
}
