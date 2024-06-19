using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        AuthorizationForm authForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (authForm == null)
            {
                authForm = new AuthorizationForm();
                authForm.Show();
                button1.Text = "Закрыть авторизацию";
            }
            else if (authForm.Visible)
            {
                authForm.Hide();
                button1.Text = "Авторизация";
            }
                
            else
            {
                authForm.Show();
                button1.Text = "Закрыть авторизацию";
            }
                
                

            
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            var dialog = new QForm();

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                pictureBox1.Image = Properties.Resources.ResourceManager
                .GetObject("cat") as Image;
            else
                        MessageBox.Show("Ну и зря!");
        }
    }
}
