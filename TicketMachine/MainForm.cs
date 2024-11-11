using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMachine
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=(local);Initial Catalog=TicketMachineDB ;Integrated Security=True ";
        private decimal initialPrice;
        public MainForm()
        {
            InitializeComponent();
            SetLocationClickEvents();
        }

        private void SetLocationClickEvents()
        {
            lblMapleWood.Click += (s, e) => LoadLocationDetails("Maple Wood");
            lblSilentHill.Click += (s, e) => LoadLocationDetails("Silent Hill");
            lblSeasideCove.Click += (s, e) => LoadLocationDetails("Seaside Cove");
            lblWilowPark.Click += (s, e) => LoadLocationDetails("Willow Park");
            lblHisto.Click += (s, e) => LoadLocationDetails("Histo Rivertown");
        }

        private void LoadLocationDetails(string locationName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Price, Description FROM Locations WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", locationName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblLocation.Text = locationName;
                        lblLocation.MaximumSize = new Size(250, 0); 

                        Size textSize = TextRenderer.MeasureText(lblLocation.Text, lblLocation.Font);
                        int maxWidth = 250;
                        if (textSize.Width > maxWidth)
                        {
                            lblLocation.Location = new Point(3, 0);
                        }
                        else
                        {
                            lblLocation.Location = new Point(17, 28);
                        }
                        lblDescribe.MaximumSize = new Size(240, 0);
                        initialPrice = Convert.ToDecimal(reader["Price"]);
                        txtPrice.Text = initialPrice.ToString("0.00");
                        lblDescribe.Text = reader["Description"].ToString();
                        lblDescribe.TextAlign = ContentAlignment.TopLeft;
                        txtAmount.Text = "1";
                    }
                    else
                    {
                        MessageBox.Show("Location details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading location details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string projectPath = Directory.GetParent(basePath).Parent.Parent.FullName;

            string imagePath = Path.Combine(projectPath, "Media", "GTA-V-Map.jpg");

            // Load the image
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (rbCreditCard.Checked)
            {
                // Show the Credit form
                Credit creditForm = new Credit();
                creditForm.Show();
            }
            else if (rbQRCode.Checked)
            {
                // Show the QR Code form
                QRCode qrCodeForm = new QRCode();
                qrCodeForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a payment option.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(txtAmount.Text);
            if (currentAmount > 1)
            {
                currentAmount--;
                txtAmount.Text = currentAmount.ToString();
                txtPrice.Text = (initialPrice * currentAmount).ToString("0.00");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int currentAmount = int.Parse(txtAmount.Text);
            currentAmount++;
            txtAmount.Text = currentAmount.ToString();
            txtPrice.Text = (initialPrice * currentAmount).ToString("0.00");
        }
    }
}
