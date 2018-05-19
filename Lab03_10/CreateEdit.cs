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
        private DataGridView dgv;
        private bool isEdit = false;
        private Boat ship;

        public CreateEdit(Form1 form1)
        {
            parentForm = form1;
            InitializeComponent();
        }

        public CreateEdit(Form1 form1, Boat ship): this(form1)
        {
            this.ship = ship;
            textBox1.Text = ship.Name;
            textBox3.Text = ship.Type;
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(ship.Categories[0].ToString());
            textBox2.Text = ship.Deplacement.ToString();
            //isEdit = true;
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
            if (ship == null)
            {
                ship = new Boat();
                ship.Name = textBox1.Text;
                ship.Deplacement = double.Parse(textBox2.Text);
                ship.Type = textBox3.Text;
                ship.Categories.Add((RoomType)comboBox1.SelectedIndex);
                parentForm.AddShip(ship);
            }
            else
            {
                ship.Name = textBox1.Text;
                ship.Deplacement = double.Parse(textBox2.Text);
                ship.Type = textBox3.Text;
                ship.Categories.Clear();
                ship.Categories.Add((RoomType)comboBox1.SelectedIndex);
                parentForm.RefreshDataGrid();
            }




            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEdit_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
