namespace AirlineApp.Forms
{
    partial class AirlinesForm
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
            txtName = new TextBox();
            txtCountry = new TextBox();
            btnChooseImage = new Button();
            pictureBoxLogo = new PictureBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView = new DataGridView();
            btnBack = new Button();
            label4 = new Label();
            label5 = new Label();
            txtFounder = new TextBox();
            numFoundedYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFoundedYear).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(42, 75);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(42, 158);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(42, 379);
            label3.Name = "label3";
            label3.Size = new Size(84, 37);
            label3.TabIndex = 2;
            label3.Text = "Logo:";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(288, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(423, 43);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 16F);
            txtCountry.Location = new Point(288, 158);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(423, 43);
            txtCountry.TabIndex = 4;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Segoe UI", 16F);
            btnChooseImage.Location = new Point(42, 572);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(222, 51);
            btnChooseImage.TabIndex = 5;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(288, 379);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(423, 244);
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(42, 673);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 60);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 16F);
            btnUpdate.Location = new Point(288, 673);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 60);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(569, 673);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(789, 24);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(654, 599);
            dataGridView.TabIndex = 10;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged_1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 16F);
            btnBack.Location = new Point(1301, 673);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 60);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(42, 244);
            label4.Name = "label4";
            label4.Size = new Size(121, 37);
            label4.TabIndex = 12;
            label4.Text = "Founder:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(42, 324);
            label5.Name = "label5";
            label5.Size = new Size(207, 37);
            label5.TabIndex = 13;
            label5.Text = "Year of creation:";
            // 
            // txtFounder
            // 
            txtFounder.Font = new Font("Segoe UI", 16F);
            txtFounder.Location = new Point(288, 244);
            txtFounder.Name = "txtFounder";
            txtFounder.Size = new Size(423, 43);
            txtFounder.TabIndex = 14;
            // 
            // numFoundedYear
            // 
            numFoundedYear.Font = new Font("Segoe UI", 16F);
            numFoundedYear.Location = new Point(288, 322);
            numFoundedYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numFoundedYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numFoundedYear.Name = "numFoundedYear";
            numFoundedYear.Size = new Size(423, 43);
            numFoundedYear.TabIndex = 15;
            numFoundedYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            numFoundedYear.ValueChanged += numFoundedYear_ValueChanged;
            // 
            // AirlinesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 745);
            Controls.Add(numFoundedYear);
            Controls.Add(txtFounder);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(dataGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnChooseImage);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AirlinesForm";
            Text = "AirlinesForm";
            Load += AirlinesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFoundedYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtCountry;
        private Button btnChooseImage;
        private PictureBox pictureBoxLogo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView;
        private Button btnBack;
        private Label label4;
        private Label label5;
        private TextBox txtFounder;
        private NumericUpDown numFoundedYear;
    }
}