using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class StudentLoginWindow : Form
    {
        public StudentLoginWindow()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=databaseproject;allowuservariables=True");

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            MySqlDataAdapter adapter;
            MySqlCommand selectcmd;

            connection.Open();
            
        }
    }
}
