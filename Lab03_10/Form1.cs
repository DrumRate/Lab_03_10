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
        private List<Boat> ships = new List<Boat>();
        

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
            string categories = "";
            foreach (var category in boat.Categories)
            {
                categories += category + ", ";
            }
            this.dataGridView1.Rows.Add(boat.Name, boat.Deplacement, categories, boat.Type);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var createEditForm = new CreateEdit(this,ships[dataGridView1.CurrentCell.RowIndex]);
            createEditForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void RefreshDataGrid()  
        {
            dataGridView1.Rows.Clear();
            foreach (var boat in ships)
            {
                string categories = "";
                foreach (var category in boat.Categories)
                {
                    categories += category + ", ";
                }
                this.dataGridView1.Rows.Add(boat.Name, boat.Deplacement, categories, boat.Type);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            ships.RemoveAt(index);
        }
    }

}
