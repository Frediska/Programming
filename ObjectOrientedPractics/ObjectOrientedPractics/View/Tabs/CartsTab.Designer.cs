namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartTextBox = new System.Windows.Forms.TextBox();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ALlAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 11);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(41, 13);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 27);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(265, 459);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(6, 492);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(94, 33);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(286, 27);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(355, 24);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(327, 21);
            this.CustomerComboBox.TabIndex = 4;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(286, 64);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(29, 13);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            // 
            // CartTextBox
            // 
            this.CartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartTextBox.Location = new System.Drawing.Point(289, 80);
            this.CartTextBox.Multiline = true;
            this.CartTextBox.Name = "CartTextBox";
            this.CartTextBox.Size = new System.Drawing.Size(393, 145);
            this.CartTextBox.TabIndex = 6;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateOrderButton.Location = new System.Drawing.Point(289, 275);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(94, 33);
            this.CreateOrderButton.TabIndex = 7;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(588, 275);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(94, 33);
            this.ClearCartButton.TabIndex = 8;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(488, 275);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(94, 33);
            this.RemoveItemButton.TabIndex = 9;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(629, 237);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // ALlAmountLabel
            // 
            this.ALlAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ALlAmountLabel.AutoSize = true;
            this.ALlAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALlAmountLabel.Location = new System.Drawing.Point(648, 259);
            this.ALlAmountLabel.Name = "ALlAmountLabel";
            this.ALlAmountLabel.Size = new System.Drawing.Size(14, 13);
            this.ALlAmountLabel.TabIndex = 11;
            this.ALlAmountLabel.Text = "0";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ALlAmountLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.CartTextBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(693, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.TextBox CartTextBox;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label ALlAmountLabel;
    }
}
