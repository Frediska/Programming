namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ParsingButton = new System.Windows.Forms.Button();
            this.ValueForParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ValueForParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(456, 135);
            this.WeekdayParsingGroupBox.TabIndex = 5;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(13, 89);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(0, 16);
            this.WeekdayLabel.TabIndex = 3;
            // 
            // ParsingButton
            // 
            this.ParsingButton.Location = new System.Drawing.Point(285, 60);
            this.ParsingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParsingButton.Name = "ParsingButton";
            this.ParsingButton.Size = new System.Drawing.Size(75, 23);
            this.ParsingButton.TabIndex = 2;
            this.ParsingButton.Text = "Parse";
            this.ParsingButton.UseVisualStyleBackColor = true;
            this.ParsingButton.Click += new System.EventHandler(this.ParsingButton_Click);
            // 
            // ValueForParsingLabel
            // 
            this.ValueForParsingLabel.AutoSize = true;
            this.ValueForParsingLabel.Location = new System.Drawing.Point(11, 41);
            this.ValueForParsingLabel.Name = "ValueForParsingLabel";
            this.ValueForParsingLabel.Size = new System.Drawing.Size(145, 16);
            this.ValueForParsingLabel.TabIndex = 1;
            this.ValueForParsingLabel.Text = "Type value for Parsing:";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(13, 60);
            this.WeekdayParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(267, 22);
            this.WeekdayParsingTextBox.TabIndex = 0;
            // 
            // GroupBoxWeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Name = "GroupBoxWeekdayParsingControl";
            this.Size = new System.Drawing.Size(456, 135);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.Button ParsingButton;
        private System.Windows.Forms.Label ValueForParsingLabel;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
    }
}
