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
            //throw new NotImplementedException();
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
    }
}
