using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;

            var panel = new Panel();
            panel.Size = new Size(200, 200);
            panel.Location = new Point(this.Width / 2, this.Height / 2);
            panel.BackColor = Color.Maroon;


            var labelTime = new Label();
            labelTime.Text = now.ToString("hh,mm");
            
            labelTime.Location = new Point(panel.Width / 2, panel.Height / 2);

            Controls.Add(panel);
            panel.Controls.Add(labelTime);
            
            
        }

        
    }
}
