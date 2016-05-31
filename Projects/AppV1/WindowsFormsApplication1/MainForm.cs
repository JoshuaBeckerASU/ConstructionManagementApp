using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }
        //------------------------Testing Methods-----------------------------//
        private void ShowMessage(String args)
        {
            //MessageBox.Show(args);
        }
        //------------------------Event Handlers------------------------------//
        private void ShowMessage(object sender, EventArgs e)
        {
            //MessageBox.Show("clicked");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void biddingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void sidingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkInMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn cif = new CheckIn();
            cif.Show();
        }

        private void eployeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void decksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
