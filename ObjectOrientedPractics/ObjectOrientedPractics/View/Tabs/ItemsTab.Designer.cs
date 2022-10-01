namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.SelectedItemIDLabel = new System.Windows.Forms.Label();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemIDTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(270, 459);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 9);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(6, 490);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(87, 42);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.Location = new System.Drawing.Point(99, 490);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(87, 42);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(284, 9);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // SelectedItemIDLabel
            // 
            this.SelectedItemIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemIDLabel.AutoSize = true;
            this.SelectedItemIDLabel.Location = new System.Drawing.Point(287, 37);
            this.SelectedItemIDLabel.Name = "SelectedItemIDLabel";
            this.SelectedItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedItemIDLabel.TabIndex = 5;
            this.SelectedItemIDLabel.Text = "ID:";
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemCostLabel.AutoSize = true;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(287, 61);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedItemCostLabel.TabIndex = 6;
            this.SelectedItemCostLabel.Text = "Cost:";
            // 
            // SelectedItemIDTextBox
            // 
            this.SelectedItemIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemIDTextBox.Enabled = false;
            this.SelectedItemIDTextBox.Location = new System.Drawing.Point(327, 34);
            this.SelectedItemIDTextBox.Name = "SelectedItemIDTextBox";
            this.SelectedItemIDTextBox.ReadOnly = true;
            this.SelectedItemIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.SelectedItemIDTextBox.TabIndex = 7;
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(327, 58);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(124, 20);
            this.SelectedItemCostTextBox.TabIndex = 8;
            this.SelectedItemCostTextBox.TextChanged += new System.EventHandler(this.SelectedItemCostTextBox_TextChanged);
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(287, 96);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedItemNameLabel.TabIndex = 9;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemDescriptionLabel.AutoSize = true;
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(287, 214);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectedItemDescriptionLabel.TabIndex = 11;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(290, 112);
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(389, 99);
            this.SelectedItemNameTextBox.TabIndex = 13;
            this.SelectedItemNameTextBox.TextChanged += new System.EventHandler(this.SelectedItemNameTextBox_TextChanged);
            // 
            // SelectedItemDescriptionTextBox
            // 
            this.SelectedItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemDescriptionTextBox.Location = new System.Drawing.Point(290, 231);
            this.SelectedItemDescriptionTextBox.Multiline = true;
            this.SelectedItemDescriptionTextBox.Name = "SelectedItemDescriptionTextBox";
            this.SelectedItemDescriptionTextBox.Size = new System.Drawing.Size(389, 137);
            this.SelectedItemDescriptionTextBox.TabIndex = 14;
            this.SelectedItemDescriptionTextBox.TextChanged += new System.EventHandler(this.SelectedItemDescriptionTextBox_TextChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedItemDescriptionTextBox);
            this.Controls.Add(this.SelectedItemNameTextBox);
            this.Controls.Add(this.SelectedItemDescriptionLabel);
            this.Controls.Add(this.SelectedItemNameLabel);
            this.Controls.Add(this.SelectedItemCostTextBox);
            this.Controls.Add(this.SelectedItemIDTextBox);
            this.Controls.Add(this.SelectedItemCostLabel);
            this.Controls.Add(this.SelectedItemIDLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(693, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label SelectedItemIDLabel;
        private System.Windows.Forms.Label SelectedItemCostLabel;
        private System.Windows.Forms.TextBox SelectedItemIDTextBox;
        private System.Windows.Forms.TextBox SelectedItemCostTextBox;
        private System.Windows.Forms.Label SelectedItemNameLabel;
        private System.Windows.Forms.Label SelectedItemDescriptionLabel;
        private System.Windows.Forms.TextBox SelectedItemNameTextBox;
        private System.Windows.Forms.TextBox SelectedItemDescriptionTextBox;
    }
}
