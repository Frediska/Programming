namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProductsAmountLabel = new System.Windows.Forms.Label();
            this.ProductsAmountDigitLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountDigitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(27, 197);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(33, 13);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Info:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(30, 224);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 45);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(149, 224);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(113, 45);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(268, 224);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 45);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProductsAmountLabel
            // 
            this.ProductsAmountLabel.AutoSize = true;
            this.ProductsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountLabel.Location = new System.Drawing.Point(567, 197);
            this.ProductsAmountLabel.Name = "ProductsAmountLabel";
            this.ProductsAmountLabel.Size = new System.Drawing.Size(107, 13);
            this.ProductsAmountLabel.TabIndex = 4;
            this.ProductsAmountLabel.Text = "Products Amount:";
            // 
            // ProductsAmountDigitLabel
            // 
            this.ProductsAmountDigitLabel.AutoSize = true;
            this.ProductsAmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsAmountDigitLabel.Location = new System.Drawing.Point(614, 224);
            this.ProductsAmountDigitLabel.Name = "ProductsAmountDigitLabel";
            this.ProductsAmountDigitLabel.Size = new System.Drawing.Size(14, 13);
            this.ProductsAmountDigitLabel.TabIndex = 5;
            this.ProductsAmountDigitLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(567, 256);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(107, 13);
            this.DiscountAmountLabel.TabIndex = 6;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountAmountDigitLabel
            // 
            this.DiscountAmountDigitLabel.AutoSize = true;
            this.DiscountAmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountDigitLabel.Location = new System.Drawing.Point(614, 279);
            this.DiscountAmountDigitLabel.Name = "DiscountAmountDigitLabel";
            this.DiscountAmountDigitLabel.Size = new System.Drawing.Size(14, 13);
            this.DiscountAmountDigitLabel.TabIndex = 7;
            this.DiscountAmountDigitLabel.Text = "0";
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountAmountDigitLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.ProductsAmountDigitLabel);
            this.Controls.Add(this.ProductsAmountLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InfoLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(693, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label ProductsAmountLabel;
        private System.Windows.Forms.Label ProductsAmountDigitLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label DiscountAmountDigitLabel;
    }
}
