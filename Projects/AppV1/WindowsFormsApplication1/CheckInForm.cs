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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobListDataSet.JobListTable' table. You can move, or remove it, as needed.
            this.jobListTableAdapter.FillDataTable(this.jobListDataSet.JobListTable);
        }

        private void JobListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void SignInB_Click(object sender, EventArgs e)
        {
            CheckinConfirmPopUp checkInPopUp = new CheckinConfirmPopUp(JobListCB.SelectedItem.ToString(), EmployeeIdTB.Text);
            checkInPopUp.Show();
        }

        private void jobListDataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobListTableAdapter.FillDataTable(this.jobListDataSet.JobListTable);
                MessageBox.Show(this.jobListTableAdapter.FillDataTable(this.jobListDataSet.JobListTable).ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
