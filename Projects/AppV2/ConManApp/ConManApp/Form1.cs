using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConManApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ClockInPanel.Parent = this;
            this.ClockOutPanel.Parent = this;
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            String command = sender.ToString();
            command = command.Remove(0,35);
            //MessageBox.Show("Button Command: " +command);
            switch (command)
            {
                case "Clock-In":
                    //this.defaultRightPanel.Hide();
                    this.ClockInPanel.Hide();
                    break;
                case "Clock-Out":
                    //this.defaultRightPanel.Hide();
                    this.ClockOutPanel.Hide();
                    break;
                default:
                    MessageBox.Show("Error: Unknown Command In Button Handler = " + command);
                    break;
            }
        }

        private void MenuItemHandler(object sender, EventArgs e)
        {
            String command = sender.ToString();
            //MessageBox.Show("MenuItemHandler Command: " + command);
            switch (command)
            {
                case "Clock-In":
                    //this.defaultRightPanel.Hide();
                    this.ClockInPanel.Show();
                    break;
                case "Clock-Out":
                    //this.defaultRightPanel.Hide();
                    this.ClockOutPanel.Show();
                    break;
                default:
                    MessageBox.Show("Error: Unknown Command In MenuItem Handler = " + command);
                    break;
            }
        }
    }
}
