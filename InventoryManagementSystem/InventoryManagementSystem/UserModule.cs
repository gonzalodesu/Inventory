using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class UserModule : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gonza\OneDrive\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModule()
        {
            InitializeComponent();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", textUser.Text);
                    cm.Parameters.AddWithValue("@fullname", textFname.Text);
                    cm.Parameters.AddWithValue("@password", textPass.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully created.");
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textUser.Clear();
            textFname.Clear();
            textPass.Clear();
            textPhone.Clear();
        }
    }
}
