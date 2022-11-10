namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.SelectedCustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerFullNameLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerIDLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.SuspendLayout();
            // 
            // SelectedCustomerFullNameTextBox
            // 
            this.SelectedCustomerFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedCustomerFullNameTextBox.Location = new System.Drawing.Point(350, 59);
            this.SelectedCustomerFullNameTextBox.Name = "SelectedCustomerFullNameTextBox";
            this.SelectedCustomerFullNameTextBox.Size = new System.Drawing.Size(329, 20);
            this.SelectedCustomerFullNameTextBox.TabIndex = 21;
            this.SelectedCustomerFullNameTextBox.TextChanged += new System.EventHandler(this.SelectedCustomerFullNameTextBox_TextChanged);
            // 
            // SelectedCustomerIDTextBox
            // 
            this.SelectedCustomerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedCustomerIDTextBox.Location = new System.Drawing.Point(350, 35);
            this.SelectedCustomerIDTextBox.Name = "SelectedCustomerIDTextBox";
            this.SelectedCustomerIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.SelectedCustomerIDTextBox.TabIndex = 20;
            // 
            // SelectedCustomerFullNameLabel
            // 
            this.SelectedCustomerFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullNameLabel.AutoSize = true;
            this.SelectedCustomerFullNameLabel.Location = new System.Drawing.Point(287, 61);
            this.SelectedCustomerFullNameLabel.Name = "SelectedCustomerFullNameLabel";
            this.SelectedCustomerFullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.SelectedCustomerFullNameLabel.TabIndex = 19;
            this.SelectedCustomerFullNameLabel.Text = "Full Name:";
            // 
            // SelectedCustomerIDLabel
            // 
            this.SelectedCustomerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerIDLabel.AutoSize = true;
            this.SelectedCustomerIDLabel.Location = new System.Drawing.Point(287, 37);
            this.SelectedCustomerIDLabel.Name = "SelectedCustomerIDLabel";
            this.SelectedCustomerIDLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedCustomerIDLabel.TabIndex = 18;
            this.SelectedCustomerIDLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(284, 9);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomerLabel.TabIndex = 17;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.Location = new System.Drawing.Point(99, 490);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(87, 42);
            this.RemoveCustomerButton.TabIndex = 16;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCustomerButton.Location = new System.Drawing.Point(6, 490);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(87, 42);
            this.AddCustomerButton.TabIndex = 15;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 9);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 14;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 25);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(270, 459);
            this.CustomersListBox.TabIndex = 13;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // AddressControl
            // 
            this.AddressControl.Address = address1;
            this.AddressControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddressControl.Location = new System.Drawing.Point(282, 85);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(403, 172);
            this.AddressControl.TabIndex = 27;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.SelectedCustomerFullNameTextBox);
            this.Controls.Add(this.SelectedCustomerIDTextBox);
            this.Controls.Add(this.SelectedCustomerFullNameLabel);
            this.Controls.Add(this.SelectedCustomerIDLabel);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.CustomersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(693, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion      
        private System.Windows.Forms.TextBox SelectedCustomerFullNameTextBox;
        private System.Windows.Forms.TextBox SelectedCustomerIDTextBox;
        private System.Windows.Forms.Label SelectedCustomerFullNameLabel;
        private System.Windows.Forms.Label SelectedCustomerIDLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private Controls.AddressControl AddressControl;
    }
}
