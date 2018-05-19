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
    public partial class Form1 : Form
    {
        private List<Ship> ships = new List<Ship>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var createEditForm = new CreateEdit(this);
            createEditForm.Show();
        }

        public void AddShip(Boat boat)
        {
            ships.Add(boat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var createEditForm = new CreateEdit(this);
            createEditForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
