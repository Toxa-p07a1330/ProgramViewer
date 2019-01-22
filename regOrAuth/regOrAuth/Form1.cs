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
using System.Threading;
using System.Runtime.InteropServices;

namespace regOrAuth
{
    public partial class Form1 : Form
    {
        public static string currentUser;
        public static string dbAdress = @"C:\Users\User\Desktop\db.txt";
        public static string dbPass = "qwerty1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();


        }

        private void authorization_Click(object sender, EventArgs e)
        {
            
            dbAdress = pathToFile.Text;
            dbPass = passForStor.Text;
            try
            {
                File.WriteAllLines(dbAdress, deshifrate(dbAdress, dbPass));
                
                string[] strs = File.ReadAllLines(dbAdress);

                bool isOk = false;
                foreach (string str in strs)
                {   
                    if (str.Contains("<user: login = " + loginAuth.Text.ToString() + "; password = " + passAuth.Text.ToString() + ";"))
                    {
                        MessageBox.Show("Success");     //Debug
                        enter(loginAuth.Text.ToString());
                        isOk = true;

                    }


                }
                if (!isOk)
                    MessageBox.Show("Wrong login or password");
            }
            catch
            {
                MessageBox.Show("Some problem while opening the file");
                File.Create(dbAdress);
            }
        }
        private void enter(string user)
        {
            currentUser = user;
            this.Hide();
            content inner = new content();
            inner.Show();
        }
        public static string[] shifrate(string path, string password)
        {
            string[] input = File.ReadAllLines(path);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains("<user: ") || input[i].Contains("</user>"))
                    continue;
                string tmp = "";
                for (int j = 0; j < input[i].Length; j++)
                {
                    tmp += (char)(((int)input[i][j] - (int)dbPass[i % dbPass.Length]+65535)%65535);     //TODO
                }
                input[i] = tmp;
            }
            return input;
        }
        public static string[] deshifrate(string path, string password)
        {
            string[] input = File.ReadAllLines(path);
            for (int i=0; i<input.Length; i++)
            {
                if (input[i].Contains("<user: ") || input[i].Contains("</user>") )
                    continue;
                string tmp="";
                for (int j=0; j<input[i].Length; j++)
                {
                    tmp += (char)(((int)input[i][j] + (int)dbPass[i % dbPass.Length])%65535);     //TODO
                }
                input[i] = tmp;
            }
            return input;
        }

        private void passForStor_TextChanged(object sender, EventArgs e)
        {
            dbPass = passForStor.Text;
            if (passForStor.Text.Length > 6)
                authorization.Enabled = true;
            else
                authorization.Enabled = false;
        }
    }
}
