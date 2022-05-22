using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_you_wait
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Form1")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                Form1 createC = new Form1();
                this.Hide();
                createC.Show();
            }
        }

        void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) Keys.Enter)
            {
                button1_Click(Start, null);
            }
        }
    }
}
