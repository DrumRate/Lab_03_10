using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_10
{
    [Serializable]
    public partial class Form1 : Form
    {
        private List<Boat> ships = new List<Boat>();


        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
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
            var createEditForm = new CreateEdit(this, ships[dataGridView1.CurrentCell.RowIndex]);
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
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                ships.RemoveAt(index);
            }

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "")
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ships);
                stream.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bat files (*.bat)|*.bat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Boat> ships = (List<Boat>)formatter.Deserialize(stream);
                for (int i = 0; i < ships.Count; i++)
                {
                    AddShip(ships[i]);
                }
                stream.Close();

            }
        }
    }
}
