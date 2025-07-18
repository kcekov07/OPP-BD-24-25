﻿namespace AirlineApp.Forms
{
    partial class FlightsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbAirlines = new ComboBox();
            txtDestination = new TextBox();
            dtDeparture = new DateTimePicker();
            txtFlightNumber = new TextBox();
            numDuration = new NumericUpDown();
            label6 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView = new DataGridView();
            label7 = new Label();
            txtDeparture = new TextBox();
            btnUpdate = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "Airline:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(40, 164);
            label2.Name = "label2";
            label2.Size = new Size(159, 37);
            label2.TabIndex = 1;
            label2.Text = "Destination:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(40, 239);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 2;
            label3.Text = "Flight Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(40, 327);
            label4.Name = "label4";
            label4.Size = new Size(194, 37);
            label4.TabIndex = 3;
            label4.Text = "Flight Number:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(40, 417);
            label5.Name = "label5";
            label5.Size = new Size(127, 37);
            label5.TabIndex = 4;
            label5.Text = "Duration:";
            // 
            // cmbAirlines
            // 
            cmbAirlines.Font = new Font("Segoe UI", 16F);
            cmbAirlines.FormattingEnabled = true;
            cmbAirlines.Location = new Point(276, 30);
            cmbAirlines.Name = "cmbAirlines";
            cmbAirlines.Size = new Size(270, 45);
            cmbAirlines.TabIndex = 5;
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 16F);
            txtDestination.Location = new Point(276, 164);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(270, 43);
            txtDestination.TabIndex = 6;
            // 
            // dtDeparture
            // 
            dtDeparture.CalendarFont = new Font("Segoe UI", 12F);
            dtDeparture.Font = new Font("Segoe UI", 12F);
            dtDeparture.Location = new Point(258, 242);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.Size = new Size(339, 34);
            dtDeparture.TabIndex = 7;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Font = new Font("Segoe UI", 16F);
            txtFlightNumber.Location = new Point(276, 327);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(270, 43);
            txtFlightNumber.TabIndex = 8;
            // 
            // numDuration
            // 
            numDuration.Font = new Font("Segoe UI", 16F);
            numDuration.Location = new Point(276, 417);
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(270, 43);
            numDuration.TabIndex = 9;
            numDuration.ValueChanged += numDuration_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(565, 423);
            label6.Name = "label6";
            label6.Size = new Size(113, 37);
            label6.TabIndex = 10;
            label6.Text = "Минути";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(34, 539);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 58);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(516, 539);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 58);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(684, 30);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(781, 636);
            dataGridView.TabIndex = 13;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(40, 99);
            label7.Name = "label7";
            label7.Size = new Size(142, 37);
            label7.TabIndex = 14;
            label7.Text = "Departure:";
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 16F);
            txtDeparture.Location = new Point(276, 99);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(270, 43);
            txtDeparture.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 16F);
            btnUpdate.Location = new Point(292, 539);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 57);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 16F);
            btnBack.Location = new Point(1317, 690);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 58);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 774);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtDeparture);
            Controls.Add(label7);
            Controls.Add(dataGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(numDuration);
            Controls.Add(txtFlightNumber);
            Controls.Add(dtDeparture);
            Controls.Add(txtDestination);
            Controls.Add(cmbAirlines);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FlightsForm";
            Text = "FlightsForm";
            Load += FlightsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbAirlines;
        private TextBox txtDestination;
        private DateTimePicker dtDeparture;
        private TextBox txtFlightNumber;
        private NumericUpDown numDuration;
        private Label label6;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView;
        private Label label7;
        private TextBox txtDeparture;
        private Button btnUpdate;
        private Button btnBack;
    }
}