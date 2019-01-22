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
using System.Diagnostics;
namespace regOrAuth
{
    public partial class content : Form
    {
        public content()
        {
            InitializeComponent();
            string[] strs = File.ReadAllLines(Form1.dbAdress);
            List<string> strsOfThisUser = new List<string>();
            bool isUserThis=false;
            foreach(string str in strs)
            {
                if (str.Contains("login = " + Form1.currentUser))
                {
                    isUserThis = true;
                    continue;
                }
                if (isUserThis && str.Contains("</user"))
                    break;
                if (isUserThis)
                    strsOfThisUser.Add(str);
            }
            foreach (string str in strsOfThisUser)
            {
                storage.Text += str+"\n";
            }
        }

        private void content_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.currentUser;
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<string> saver = new List<string>();
            bool isUserThis = false;
            bool wasUser = false;
            bool rest = false;
            bool wasAdded = false;
            string[] strs = File.ReadAllLines(Form1.dbAdress);
            foreach (string str in strs)
            {
                if (str.Contains("login = " + Form1.currentUser))
                {
                    saver.Add(str);
                    isUserThis = true;
                    continue;
                }
                if (isUserThis && str.Contains("</user"))
                    isUserThis = false;
                if (isUserThis)
                    wasUser = true;
                if (!isUserThis && wasUser)
                    rest = true;
                if (!wasUser)
                    saver.Add (str);
                if (isUserThis && !wasAdded)
                {
                    foreach (string st in storage.Text.Split('\n'))
                        saver.Add(st);
                    wasAdded = true;
                }
                if (rest)
                    saver.Add(str);
  
            }
            string[] outer = new string[saver.Count];
            for (int i = 0; i < saver.Count; i++)
                outer[i] = saver.ElementAt(i);
            File.WriteAllLines(Form1.dbAdress+"tmp", outer);

            File.WriteAllLines(Form1.dbAdress, Form1.shifrate(Form1.dbAdress+"tmp", Form1.dbPass));
            File.Delete(Form1.dbAdress + "tmp");
            this.Close();

        }
    }
}
