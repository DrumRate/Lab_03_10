using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab03_10
{
    [Serializable]

    public partial class MainForm : Form
    {
        BinaryFormatter formatter = new BinaryFormatter();
        private Boat ship1;
        List<Form1>  ships = new List<Form1>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                ships.Add(new Form1());
                ships[ships.Count-1].MdiParent = this;
                // ship.Text = "Create";
                ships[ships.Count - 1].FormClosed += Ship_FormClosed;
                ships[ships.Count - 1].Show();
         
            
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                formatter.Serialize(fs, new Test());
                fs.Close();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }



        private void Ship_FormClosed(object sender, FormClosedEventArgs e)
        {
            ships.Remove((Form1)sender);
        }
    }


}