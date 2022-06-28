namespace ListOfEstablishments
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EstablishmentsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.RemoveEstablishmentButton = new System.Windows.Forms.Button();
            this.AddEstablishmentButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstablishmentsListBox
            // 
            this.EstablishmentsListBox.FormattingEnabled = true;
            this.EstablishmentsListBox.ItemHeight = 16;
            this.EstablishmentsListBox.Location = new System.Drawing.Point(12, 12);
            this.EstablishmentsListBox.Name = "EstablishmentsListBox";
            this.EstablishmentsListBox.Size = new System.Drawing.Size(239, 388);
            this.EstablishmentsListBox.TabIndex = 0;
            this.EstablishmentsListBox.SelectedIndexChanged += new System.EventHandler(this.EstablishmentsListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingLabel);
            this.groupBox1.Controls.Add(this.CategoryLabel);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Controls.Add(this.RatingTextBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.AddressTextBox);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Location = new System.Drawing.Point(258, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Establishment";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(49, 112);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 16);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(33, 82);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(37, 54);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(61, 16);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(62, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 16);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(104, 109);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(221, 22);
            this.RatingTextBox.TabIndex = 3;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(104, 79);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(221, 24);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(104, 51);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(221, 22);
            this.AddressTextBox.TabIndex = 1;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(104, 23);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(420, 22);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // RemoveEstablishmentButton
            // 
            this.RemoveEstablishmentButton.FlatAppearance.BorderSize = 0;
            this.RemoveEstablishmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEstablishmentButton.Image = global::ListOfEstablishments.Properties.Resources.remove_establishment_24x24_uncolor;
            this.RemoveEstablishmentButton.Location = new System.Drawing.Point(376, 163);
            this.RemoveEstablishmentButton.Name = "RemoveEstablishmentButton";
            this.RemoveEstablishmentButton.Size = new System.Drawing.Size(112, 71);
            this.RemoveEstablishmentButton.TabIndex = 3;
            this.RemoveEstablishmentButton.UseVisualStyleBackColor = true;
            this.RemoveEstablishmentButton.Click += new System.EventHandler(this.RemoveEstablishmentButton_Click);
            this.RemoveEstablishmentButton.MouseEnter += new System.EventHandler(this.RemoveEstablishmentButton_MouseEnter);
            this.RemoveEstablishmentButton.MouseLeave += new System.EventHandler(this.RemoveEstablishmentButton_MouseLeave);
            // 
            // AddEstablishmentButton
            // 
            this.AddEstablishmentButton.FlatAppearance.BorderSize = 0;
            this.AddEstablishmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEstablishmentButton.Image = global::ListOfEstablishments.Properties.Resources.add_establishment_24x24_uncolor;
            this.AddEstablishmentButton.Location = new System.Drawing.Point(258, 163);
            this.AddEstablishmentButton.Name = "AddEstablishmentButton";
            this.AddEstablishmentButton.Size = new System.Drawing.Size(112, 71);
            this.AddEstablishmentButton.TabIndex = 2;
            this.AddEstablishmentButton.UseVisualStyleBackColor = true;
            this.AddEstablishmentButton.Click += new System.EventHandler(this.AddEstablishmentButton_Click);
            this.AddEstablishmentButton.MouseEnter += new System.EventHandler(this.AddEstablishmentButton_MouseEnter);
            this.AddEstablishmentButton.MouseLeave += new System.EventHandler(this.AddEstablishmentButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveEstablishmentButton);
            this.Controls.Add(this.AddEstablishmentButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EstablishmentsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EstablishmentApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EstablishmentsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button AddEstablishmentButton;
        private System.Windows.Forms.Button RemoveEstablishmentButton;
    }
}

