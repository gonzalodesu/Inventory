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
    public partial class User : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gonza\OneDrive\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader datareader;
        public User()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dataGridViewUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            datareader = cm.ExecuteReader();
            while (datareader.Read())
            {
                i++;
                dataGridViewUser.Rows.Add(i,datareader[0].ToString(), datareader[0].ToString(), datareader[0].ToString(), datareader[0].ToString());
            }
            datareader.Close();
            con.Close();
        } 
    }
}
