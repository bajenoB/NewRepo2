using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp17
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            XElement srcTree = new XElement("root");
            var button = new Button();
            button.Text = "load";
            button.Size = new Size(50, 50);
            button.Location = new Point(150, 100);
            button.Click += Button_Click;
            
            DateTime now = DateTime.Now;
            var checksec = new CheckBox();
            checksec.Text = "second";
            checksec.Name = now.ToString("ss");
            checksec.Location = new Point(0, 0);
            checksec.Click += Checksec_Click;

            var checkmin = new CheckBox();
            checkmin.Text = "minute";
            checkmin.Name = now.ToString("mm");
            checkmin.Checked = true;
            checkmin.Location = new Point(0, 50);
            checkmin.Click += Checksec_Click;

            var checknil = new CheckBox();
            checknil.Text = "milsecond";
            checknil.Name = now.ToString("ffff");
            checknil.Location = new Point(100, 0);
            checknil.Click += Checksec_Click;

            var checkhour = new CheckBox();
            checkhour.Text = "hour";
            checkhour.Name = now.ToString("HH");
            checkhour.Checked = true;
            checkhour.Location = new Point(100, 50);
            checkhour.Click += Checksec_Click;

            Controls.Add(checkhour);
            Controls.Add(checkmin);
            Controls.Add(checksec);
            Controls.Add(checknil);
            Controls.Add(button);
            string textTime=string.Empty;

            

        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            string textTime = string.Empty;
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    if ((item as CheckBox).Checked == true)
                    {
                        textTime = (item as CheckBox).Name + ":";
                        Form1 form1 = new Form1(textTime);
                        this.Text += (item as CheckBox).Name + ":";

                        new XElement((item as CheckBox).Text, (item as CheckBox).Name);
                    }
                }
            }
        }

        private void Checksec_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            string textTime = string.Empty;

            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    if ((item as CheckBox).Checked == true)
                    {
                        //textTime = (item as CheckBox).Name + ":";
                       // Form1 form1 = new Form1(textTime);
                        this.Text += (item as CheckBox).Name + ":";
                    }
                }
            }
            //


        }
    }
}
