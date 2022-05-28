namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieDurationMinutesLabel = new System.Windows.Forms.Label();
            this.MovieDurationMinutesTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.FindMoviesButton = new System.Windows.Forms.Button();
            this.MovieReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieDurationMinutesLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationMinutesTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.FindMoviesButton);
            this.MoviesGroupBox.Controls.Add(this.MovieReleaseYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieReleaseYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Size = new System.Drawing.Size(389, 417);
            this.MoviesGroupBox.TabIndex = 2;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieDurationMinutesLabel
            // 
            this.MovieDurationMinutesLabel.AutoSize = true;
            this.MovieDurationMinutesLabel.Location = new System.Drawing.Point(187, 233);
            this.MovieDurationMinutesLabel.Name = "MovieDurationMinutesLabel";
            this.MovieDurationMinutesLabel.Size = new System.Drawing.Size(60, 16);
            this.MovieDurationMinutesLabel.TabIndex = 11;
            this.MovieDurationMinutesLabel.Text = "Duration:";
            // 
            // MovieDurationMinutesTextBox
            // 
            this.MovieDurationMinutesTextBox.Location = new System.Drawing.Point(190, 252);
            this.MovieDurationMinutesTextBox.Name = "MovieDurationMinutesTextBox";
            this.MovieDurationMinutesTextBox.Size = new System.Drawing.Size(141, 22);
            this.MovieDurationMinutesTextBox.TabIndex = 10;
            this.MovieDurationMinutesTextBox.TextChanged += new System.EventHandler(this.MovieDurationMinutesTextBox_TextChanged);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(187, 183);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(49, 16);
            this.MovieRatingLabel.TabIndex = 9;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(190, 202);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(141, 22);
            this.MovieRatingTextBox.TabIndex = 8;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // FindMoviesButton
            // 
            this.FindMoviesButton.Location = new System.Drawing.Point(187, 349);
            this.FindMoviesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(100, 28);
            this.FindMoviesButton.TabIndex = 7;
            this.FindMoviesButton.Text = "Find";
            this.FindMoviesButton.UseVisualStyleBackColor = true;
            this.FindMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // MovieReleaseYearLabel
            // 
            this.MovieReleaseYearLabel.AutoSize = true;
            this.MovieReleaseYearLabel.Location = new System.Drawing.Point(187, 132);
            this.MovieReleaseYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieReleaseYearLabel.Name = "MovieReleaseYearLabel";
            this.MovieReleaseYearLabel.Size = new System.Drawing.Size(92, 16);
            this.MovieReleaseYearLabel.TabIndex = 6;
            this.MovieReleaseYearLabel.Text = "Release year:";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(187, 80);
            this.MovieGenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(47, 16);
            this.MovieGenreLabel.TabIndex = 5;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(188, 151);
            this.MovieReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieReleaseYearTextBox.TabIndex = 4;
            this.MovieReleaseYearTextBox.TextChanged += new System.EventHandler(this.MovieReleaseYearTextBox_TextChanged);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(187, 100);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieGenreTextBox.TabIndex = 3;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(187, 30);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(36, 16);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(187, 48);
            this.MovieTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieTitleTextBox.TabIndex = 1;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(5, 21);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(175, 356);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(389, 417);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Label MovieDurationMinutesLabel;
        private System.Windows.Forms.TextBox MovieDurationMinutesTextBox;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Button FindMoviesButton;
        private System.Windows.Forms.Label MovieReleaseYearLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.TextBox MovieReleaseYearTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
