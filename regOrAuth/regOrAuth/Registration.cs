using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace regOrAuth
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
 
        }

        private void agreement_CheckedChanged(object sender, EventArgs e)
        {
            enabilityOfButton();

        }
        private bool isRegCorrect()
        {
            string[] strs = File.ReadAllLines(Form1.dbAdress);
            foreach (string str in strs)
                if (str.Contains("<user: login = "+loginReg.Text.ToString()+"; "))
                    return false;
            if (passReg1.Text.ToString().Length < 6)
                return false;
            if (passReg1.Text != passReg2.Text)
                return false;
            if (agreement.Checked == false)
                return false;
            return true;
        }

        private void auth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 authoris = new Form1();
            authoris.Show();
        }

        private void loginReg_TextChanged(object sender, EventArgs e)
        {
            enabilityOfButton();
        }

        private void passReg1_TextChanged(object sender, EventArgs e)
        {
            enabilityOfButton();

        }

        private void passReg2_TextChanged(object sender, EventArgs e)
        {
            enabilityOfButton();

        }

        private void enabilityOfButton()
        {
            if (isRegCorrect())
                registr.Enabled = true;
            else
                registr.Enabled = false;
        }

        private void registr_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            arr[0] = @"<user: login = " + loginReg.Text.ToString() + @"; password = " + passReg1.Text.ToString() + "; info = \"\">\n";
            arr[1] = "\n</user>\n";
            File.AppendAllLines(Form1.dbAdress, arr);
            
            MessageBox.Show("Success");
            content inner = new content();
            Form1.currentUser = loginReg.Text.ToString();
            inner.Show();
            inner.storage.Text = null;
            this.Close();
        }
    }
}
