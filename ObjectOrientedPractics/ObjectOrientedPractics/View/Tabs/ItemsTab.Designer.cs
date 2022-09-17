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
            this.SelectedItemNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(270, 459);
            this.ItemsListBox.TabIndex = 0;
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
            this.AddItemButton.Location = new System.Drawing.Point(6, 490);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(87, 42);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(99, 490);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(87, 42);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
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
            this.SelectedItemIDLabel.AutoSize = true;
            this.SelectedItemIDLabel.Location = new System.Drawing.Point(287, 37);
            this.SelectedItemIDLabel.Name = "SelectedItemIDLabel";
            this.SelectedItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedItemIDLabel.TabIndex = 5;
            this.SelectedItemIDLabel.Text = "ID:";
            // 
            // SelectedItemCostLabel
            // 
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
            this.SelectedItemIDTextBox.Location = new System.Drawing.Point(327, 34);
            this.SelectedItemIDTextBox.Name = "SelectedItemIDTextBox";
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
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(287, 96);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedItemNameLabel.TabIndex = 9;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemNameRichTextBox
            // 
            this.SelectedItemNameRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemNameRichTextBox.Location = new System.Drawing.Point(287, 112);
            this.SelectedItemNameRichTextBox.Name = "SelectedItemNameRichTextBox";
            this.SelectedItemNameRichTextBox.Size = new System.Drawing.Size(392, 88);
            this.SelectedItemNameRichTextBox.TabIndex = 10;
            this.SelectedItemNameRichTextBox.Text = "";
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.AutoSize = true;
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(287, 214);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectedItemDescriptionLabel.TabIndex = 11;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemDescriptionRichTextBox
            // 
            this.SelectedItemDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemDescriptionRichTextBox.Location = new System.Drawing.Point(287, 230);
            this.SelectedItemDescriptionRichTextBox.Name = "SelectedItemDescriptionRichTextBox";
            this.SelectedItemDescriptionRichTextBox.Size = new System.Drawing.Size(392, 126);
            this.SelectedItemDescriptionRichTextBox.TabIndex = 12;
            this.SelectedItemDescriptionRichTextBox.Text = "";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedItemDescriptionRichTextBox);
            this.Controls.Add(this.SelectedItemDescriptionLabel);
            this.Controls.Add(this.SelectedItemNameRichTextBox);
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
        private System.Windows.Forms.RichTextBox SelectedItemNameRichTextBox;
        private System.Windows.Forms.Label SelectedItemDescriptionLabel;
        private System.Windows.Forms.RichTextBox SelectedItemDescriptionRichTextBox;
    }
}
