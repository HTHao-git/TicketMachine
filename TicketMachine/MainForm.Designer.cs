namespace TicketMachine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHistoRivertown = new System.Windows.Forms.Panel();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.rbQRCode = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWilowPark = new System.Windows.Forms.Label();
            this.lblSilentHill = new System.Windows.Forms.Label();
            this.lblSeasideCove = new System.Windows.Forms.Label();
            this.lblMapleWood = new System.Windows.Forms.Label();
            this.lblHisto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHistoRivertown.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistoRivertown
            // 
            this.lblHistoRivertown.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblHistoRivertown.Controls.Add(this.lblDescribe);
            this.lblHistoRivertown.Controls.Add(this.txtAmount);
            this.lblHistoRivertown.Controls.Add(this.btnAdd);
            this.lblHistoRivertown.Controls.Add(this.btnSub);
            this.lblHistoRivertown.Controls.Add(this.btnProceed);
            this.lblHistoRivertown.Controls.Add(this.rbQRCode);
            this.lblHistoRivertown.Controls.Add(this.rbCreditCard);
            this.lblHistoRivertown.Controls.Add(this.txtPrice);
            this.lblHistoRivertown.Controls.Add(this.label6);
            this.lblHistoRivertown.Controls.Add(this.lblPrice);
            this.lblHistoRivertown.Controls.Add(this.lblDescription);
            this.lblHistoRivertown.Controls.Add(this.panel2);
            this.lblHistoRivertown.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHistoRivertown.Location = new System.Drawing.Point(850, 0);
            this.lblHistoRivertown.Name = "lblHistoRivertown";
            this.lblHistoRivertown.Size = new System.Drawing.Size(256, 644);
            this.lblHistoRivertown.TabIndex = 0;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(21, 133);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(0, 20);
            this.lblDescribe.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(106, 364);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(22, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(132, 363);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(16, 17);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.SlateGray;
            this.btnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSub.Location = new System.Drawing.Point(86, 364);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(16, 17);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Cyan;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProceed.Location = new System.Drawing.Point(64, 578);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(147, 58);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // rbQRCode
            // 
            this.rbQRCode.AutoSize = true;
            this.rbQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQRCode.ForeColor = System.Drawing.Color.MediumBlue;
            this.rbQRCode.Location = new System.Drawing.Point(64, 469);
            this.rbQRCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbQRCode.Name = "rbQRCode";
            this.rbQRCode.Size = new System.Drawing.Size(93, 24);
            this.rbQRCode.TabIndex = 3;
            this.rbQRCode.TabStop = true;
            this.rbQRCode.Text = "QR Code";
            this.rbQRCode.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreditCard.ForeColor = System.Drawing.Color.Orange;
            this.rbCreditCard.Location = new System.Drawing.Point(64, 434);
            this.rbCreditCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(107, 24);
            this.rbCreditCard.TabIndex = 3;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(62, 338);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(84, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Payment option";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(2, 333);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 24);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(6, 97);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(119, 24);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 94);
            this.panel2.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocation.Location = new System.Drawing.Point(17, 28);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(221, 44);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Destination";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 94);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SION EXPRESS !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Where would you like to go ?";
            // 
            // lblWilowPark
            // 
            this.lblWilowPark.AutoSize = true;
            this.lblWilowPark.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblWilowPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWilowPark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWilowPark.Location = new System.Drawing.Point(554, 318);
            this.lblWilowPark.Name = "lblWilowPark";
            this.lblWilowPark.Size = new System.Drawing.Size(149, 31);
            this.lblWilowPark.TabIndex = 5;
            this.lblWilowPark.Text = "Wilow Park";
            // 
            // lblSilentHill
            // 
            this.lblSilentHill.AutoSize = true;
            this.lblSilentHill.BackColor = System.Drawing.Color.ForestGreen;
            this.lblSilentHill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSilentHill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSilentHill.Location = new System.Drawing.Point(344, 401);
            this.lblSilentHill.Name = "lblSilentHill";
            this.lblSilentHill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSilentHill.Size = new System.Drawing.Size(127, 31);
            this.lblSilentHill.TabIndex = 6;
            this.lblSilentHill.Text = "Silent Hill";
            // 
            // lblSeasideCove
            // 
            this.lblSeasideCove.AutoSize = true;
            this.lblSeasideCove.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblSeasideCove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSeasideCove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeasideCove.Location = new System.Drawing.Point(398, 496);
            this.lblSeasideCove.Name = "lblSeasideCove";
            this.lblSeasideCove.Size = new System.Drawing.Size(183, 31);
            this.lblSeasideCove.TabIndex = 7;
            this.lblSeasideCove.Text = "Seaside Cove";
            // 
            // lblMapleWood
            // 
            this.lblMapleWood.AutoSize = true;
            this.lblMapleWood.BackColor = System.Drawing.Color.Green;
            this.lblMapleWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMapleWood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMapleWood.Location = new System.Drawing.Point(80, 318);
            this.lblMapleWood.Name = "lblMapleWood";
            this.lblMapleWood.Size = new System.Drawing.Size(164, 31);
            this.lblMapleWood.TabIndex = 8;
            this.lblMapleWood.Text = "Maple Wood";
            // 
            // lblHisto
            // 
            this.lblHisto.AutoSize = true;
            this.lblHisto.BackColor = System.Drawing.Color.Aqua;
            this.lblHisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHisto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHisto.Location = new System.Drawing.Point(624, 236);
            this.lblHisto.Name = "lblHisto";
            this.lblHisto.Size = new System.Drawing.Size(206, 31);
            this.lblHisto.TabIndex = 9;
            this.lblHisto.Text = "Histo Rivertown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 644);
            this.Controls.Add(this.lblHisto);
            this.Controls.Add(this.lblMapleWood);
            this.Controls.Add(this.lblSeasideCove);
            this.Controls.Add(this.lblSilentHill);
            this.Controls.Add(this.lblWilowPark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHistoRivertown);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainForm";
            this.Text = "Sion Express";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.lblHistoRivertown.ResumeLayout(false);
            this.lblHistoRivertown.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblHistoRivertown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWilowPark;
        private System.Windows.Forms.Label lblSilentHill;
        private System.Windows.Forms.Label lblSeasideCove;
        private System.Windows.Forms.Label lblMapleWood;
        private System.Windows.Forms.Label lblHisto;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton rbQRCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

