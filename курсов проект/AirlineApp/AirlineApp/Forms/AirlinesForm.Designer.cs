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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(86, 81);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(86, 164);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(86, 258);
            label3.Name = "label3";
            label3.Size = new Size(84, 37);
            label3.TabIndex = 2;
            label3.Text = "Logo:";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(441, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 43);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 16F);
            txtCountry.Location = new Point(441, 158);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(292, 43);
            txtCountry.TabIndex = 4;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Segoe UI", 16F);
            btnChooseImage.Location = new Point(86, 349);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(222, 51);
            btnChooseImage.TabIndex = 5;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(441, 228);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(292, 172);
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(100, 544);
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
            btnUpdate.Location = new Point(347, 544);
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
            btnDelete.Location = new Point(591, 544);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(849, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(594, 529);
            dataGridView.TabIndex = 10;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // AirlinesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 745);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
    }
}