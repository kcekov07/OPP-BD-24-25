namespace AirlineApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitle = new Label();
            btnAirlines = new Button();
            btnFlights = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(369, 42);
            lblTitle.Margin = new Padding(9, 0, 9, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(733, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✈  Mehano AirLine Menu ✈";
            lblTitle.Click += label1_Click;
            // 
            // btnAirlines
            // 
            btnAirlines.BackColor = SystemColors.ControlLightLight;
            btnAirlines.Font = new Font("Segoe UI", 25F);
            btnAirlines.ForeColor = SystemColors.HotTrack;
            btnAirlines.Location = new Point(104, 252);
            btnAirlines.Name = "btnAirlines";
            btnAirlines.Size = new Size(365, 74);
            btnAirlines.TabIndex = 1;
            btnAirlines.Text = "🛫  Air Lines  🛫";
            btnAirlines.UseVisualStyleBackColor = false;
            btnAirlines.Click += btnAirlines_Click;
            // 
            // btnFlights
            // 
            btnFlights.ForeColor = SystemColors.HotTrack;
            btnFlights.Location = new Point(995, 236);
            btnFlights.Name = "btnFlights";
            btnFlights.Size = new Size(365, 74);
            btnFlights.TabIndex = 2;
            btnFlights.Text = "📅    Flights   📅 ";
            btnFlights.UseVisualStyleBackColor = true;
            btnFlights.Click += btnFlights_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(540, 335);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(383, 384);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1457, 777);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnFlights);
            Controls.Add(btnAirlines);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 25F);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(9);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAirlines;
        private Button btnFlights;
        private PictureBox pictureBoxLogo;
    }
}