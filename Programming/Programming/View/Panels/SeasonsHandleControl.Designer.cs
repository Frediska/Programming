namespace Programming.View.Panels
{
    partial class SeasonsHandleControl
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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(317, 135);
            this.SeasonHandleGroupBox.TabIndex = 6;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(7, 41);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(104, 16);
            this.ChooseSeasonLabel.TabIndex = 3;
            this.ChooseSeasonLabel.Text = "Choose Season";
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(5, 60);
            this.ChooseSeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(209, 24);
            this.ChooseSeasonComboBox.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(221, 60);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // GroupBoxSeasonsHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonHandleGroupBox);
            this.Name = "GroupBoxSeasonsHandleControl";
            this.Size = new System.Drawing.Size(317, 135);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.Button GoButton;
    }
}
