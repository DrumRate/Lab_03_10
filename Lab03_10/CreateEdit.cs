using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_10
{
    public partial class CreateEdit : Form
    {
        private Form1 parentForm;

        public CreateEdit(Form1 form1)
        {
            parentForm = form1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ship = new Boat();
            ship.Name = textBox1.Text;
            ship.Deplacement = double.Parse(textBox2.Text);
            ship.Type = textBox3.Text;
            parentForm.AddShip(ship);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
