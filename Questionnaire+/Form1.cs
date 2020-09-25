using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_
{
    public partial class Form1 : Form
    {
        private static string userNote = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterBut_Click(object sender, EventArgs e)
        {
            if (UserPoints.Text.Equals("Input your points, definitions, etc.") != false)
            {
                userNote = UserPoints.Text;
                if (userNote.Equals(""))
                {
                    errorLabel.Text = "You just entered an empty input";
                }      
            }
            else
            {
                string message = "No input received.";
                string caption = "Error Detected in input";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
