using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_0._1
{
    public partial class BaseFormApplication : Form
    {
        public BaseFormApplication()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginModule LogMod = new LoginModule();
            LogMod.Show();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationModule RegMod = new RegistrationModule();
            RegMod.Show();
        }
    }
}
