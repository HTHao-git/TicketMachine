using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMachine
{
    public partial class Credit : Form
    {
        private int countdown = 10;

        public Credit()
        {
            InitializeComponent();
            timer1.Interval = 1000; 
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            lblCountdown.ForeColor = Color.White;
        }
        public void ProcessPayment()
        {
            // Credit card payment logic
            this.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblCountdown.Text = $"You have {countdown} second(s)";

            if (countdown >= 7)
            {
                lblCountdown.ForeColor = Color.White; // 10-7 seconds
            }
            else if (countdown >= 4)
            {
                lblCountdown.ForeColor = Color.Blue;  // 6-4 seconds
            }
            else
            {
                lblCountdown.ForeColor = Color.Red;   // 3-1 seconds
            }

            if (countdown <= 0)
            {
                timer1.Stop();
                lblCountdown.Text = "Transaction failed";
                lblInstruction.Text = "No Credit Card detected !";
                btnConfirm.Enabled = false;
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectPath = Directory.GetParent(basePath).Parent.Parent.FullName;
                string imagePath = Path.Combine(projectPath, "Media", "FailedIcon.png");
                pictureBox1.Image = Image.FromFile(imagePath);
                Timer closeTimer = new Timer();
                closeTimer.Interval = 5000;
                closeTimer.Tick += (s, args) =>
                {
                    closeTimer.Stop();
                    this.Close();
                };
                closeTimer.Start();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(basePath).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Media", "BarCodeIcon.png");
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblInstruction.Text = "Transaction confirmed !";
            lblCountdown.Text = "";
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(basePath).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Media", "Tickbox.png");
            pictureBox1.Image = Image.FromFile(imagePath);
        }
    }
}
