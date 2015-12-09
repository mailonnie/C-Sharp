// Project : Pet's Name Application
// Name    : Mai Nguyen
// Date    : 12/08/2015
// Purpose : The program displays the name of the pet when the Pet's Name button is clicked
//Ahmed Soliman GitHub....
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsNameApplication
{
    public partial class PetsNameApplication : Form
    {
        public PetsNameApplication()
        {
            InitializeComponent();
        }

        private void btnDisplayPetsName_Click(object sender, EventArgs e)
        {
            choosePet(); // Choose your pet
        }

        private void choosePet()
        {
            if (rbLucy.Checked == true)
            {
                display("Your pet name is Lucy");
            }
            else if (rbBamboo.Checked == true)
            {
                display("Your pet name is Bamboo");
            }
            else if (rbLala.Checked == true)
            {
                display("Your pet name is Lala");
            }
        }
        private void display(string text)
        {
            MessageBox.Show(text); //Display pet's name
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }

}
