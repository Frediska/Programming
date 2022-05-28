namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(780, 276);
            this.EnumerationsGroupBox.TabIndex = 4;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(483, 22);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(59, 16);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(251, 22);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(93, 16);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(11, 22);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(134, 16);
            this.ChooseEnumerationLabel.TabIndex = 3;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(13, 41);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(207, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(485, 41);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(119, 22);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(251, 41);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(207, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // GroupBoxEnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumerationsGroupBox);
            this.Name = "GroupBoxEnumerationsControl";
            this.Size = new System.Drawing.Size(780, 276);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
