using NavigateWinform.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigateWinform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Form1 form1;
        private void btn1_Click(object sender, EventArgs e)
        {
            removeForm();
            if (form1 != null)
            {
                form1.Close();
                form1.Dispose();
                form1 = null;
            }
           
            form1 = new Form1();
            form1.TopLevel = false;
            form1.Dock= DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(form1);
            form1.Show();
        }
        Form2 form2;
        private void btn2_Click(object sender, EventArgs e)
        {
            removeForm();
            if (form2 != null)
            {
                form2.Close();
                form2.Dispose();
                form2 = null;
            }

            form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(form2);
            form2.Show();
        }
        Form3 form3;
        private void btn3_Click(object sender, EventArgs e)
        {
            removeForm();
            if (form3 != null)
            {
                form3.Close();
                form3.Dispose();
                form3= null;
            }
            form3 = new Form3();
            form3.TopLevel = false;
            form3.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(form3);
            form3.Show();
        }

        private void removeForm()
        {
            foreach (Control control in panel2.Controls)
            {
                var f = (Form)control;

                Console.WriteLine(f.Name);
                f.Close();
            }
        }
    }
}
