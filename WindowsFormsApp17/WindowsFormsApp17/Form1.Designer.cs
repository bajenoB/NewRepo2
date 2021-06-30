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
using System.Xml.Linq;

namespace WindowsFormsApp17
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DateTime now;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //private Button btn1;

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            now = DateTime.Now;

            panel = new Panel();
            panel.Size = new Size(200, 200);
            panel.Location = new Point(this.Width / 2, this.Height / 2);
            panel.BackColor = Color.Maroon;


           

            labelTime = new Label();
           
            labelTime.Text = now.ToString("hh,mm");

            labelTime.Location = new Point(panel.Width / 2, panel.Height / 2);

            button = new Button();
            button.Size = new Size(100, 100);
            button.Location = new Point(0, 0);
            //button.Text = "settings";
            button.BackgroundImage = Image.FromFile("bg.jpg");
            button.ImageAlign = ContentAlignment.MiddleRight;
            //button.BackgroundImage.Width = 50;
            //button.BackgroundImage.Height = 50;
            button.Click += Button_Click;

            Controls.Add(panel);
            panel.Controls.Add(labelTime);
            Controls.Add(button);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Settings form1 = new Settings();
            form1.Show();
            //this.Visible = false;
        }

        Panel panel;
        Button button;
        Label labelTime;
        
        #endregion
    }
}

