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
    public partial class CheckinConfirmPopUp : Form
    {
        String timeStamp_m;
        public CheckinConfirmPopUp(String job, String id)
        {
            InitializeComponent();
            JobL.Text = job;
            EmployeeId.Text = id;
            timeStamp_m = System.DateTime.Now.ToShortTimeString() + " " + System.DateTime.Now.ToShortDateString();
            TimeStamp.Text = timeStamp_m;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeId_Click(object sender, EventArgs e)
        {

        }
    }
}
