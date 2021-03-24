using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoGamesCollectionCSharpDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text=="" || passwordTextBox.Text == "")
            {
                errorLabel.Visible = true;
            } else
            {
                if(usernameTextBox.Text=="Gui" && passwordTextBox.Text == "123")
                {
                    MainAppForm mainAppForm = new MainAppForm();
                    mainAppForm.Show();
                    Close();
                }
            }
        }
    }
}
