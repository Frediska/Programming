namespace Programming.View
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
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindMoviesButton = new System.Windows.Forms.Button();
            this.MovieDurationMinutesLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYearLabel = new System.Windows.Forms.Label();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieDurationMinutesTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.groupBoxSeasonsHandleControl1 = new Programming.View.Panels.SeasonsHandleControl();
            this.groupBoxWeekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.groupBoxEnumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(800, 450);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.groupBoxSeasonsHandleControl1);
            this.EnumsTabPage.Controls.Add(this.groupBoxWeekdayParsingControl1);
            this.EnumsTabPage.Controls.Add(this.groupBoxEnumerationsControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 421);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.rectanglesControl1);
            this.ClassesTabPage.Controls.Add(this.moviesControl1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 421);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 421);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.MoviesGroupBox.TabIndex = 0;
            this.MoviesGroupBox.TabStop = false;
            // 
            // FindMoviesButton
            // 
            this.FindMoviesButton.Location = new System.Drawing.Point(0, 0);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(75, 23);
            this.FindMoviesButton.TabIndex = 0;
            // 
            // MovieDurationMinutesLabel
            // 
            this.MovieDurationMinutesLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieDurationMinutesLabel.Name = "MovieDurationMinutesLabel";
            this.MovieDurationMinutesLabel.Size = new System.Drawing.Size(100, 23);
            this.MovieDurationMinutesLabel.TabIndex = 0;
            // 
            // MovieReleaseYearLabel
            // 
            this.MovieReleaseYearLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieReleaseYearLabel.Name = "MovieReleaseYearLabel";
            this.MovieReleaseYearLabel.Size = new System.Drawing.Size(100, 23);
            this.MovieReleaseYearLabel.TabIndex = 0;
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(100, 23);
            this.MovieRatingLabel.TabIndex = 0;
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(100, 23);
            this.MovieGenreLabel.TabIndex = 0;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(100, 23);
            this.MovieTitleLabel.TabIndex = 0;
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(0, 0);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieReleaseYearTextBox.TabIndex = 0;
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(0, 0);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieGenreTextBox.TabIndex = 0;
            // 
            // MovieDurationMinutesTextBox
            // 
            this.MovieDurationMinutesTextBox.Location = new System.Drawing.Point(0, 0);
            this.MovieDurationMinutesTextBox.Name = "MovieDurationMinutesTextBox";
            this.MovieDurationMinutesTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieDurationMinutesTextBox.TabIndex = 0;
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(0, 0);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieRatingTextBox.TabIndex = 0;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(0, 0);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.MovieTitleTextBox.TabIndex = 0;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(120, 84);
            this.MoviesListBox.TabIndex = 0;
            // 
            // groupBoxSeasonsHandleControl1
            // 
            this.groupBoxSeasonsHandleControl1.Location = new System.Drawing.Point(465, 282);
            this.groupBoxSeasonsHandleControl1.Name = "groupBoxSeasonsHandleControl1";
            this.groupBoxSeasonsHandleControl1.Size = new System.Drawing.Size(317, 135);
            this.groupBoxSeasonsHandleControl1.TabIndex = 8;
            // 
            // groupBoxWeekdayParsingControl1
            // 
            this.groupBoxWeekdayParsingControl1.Location = new System.Drawing.Point(2, 282);
            this.groupBoxWeekdayParsingControl1.Name = "groupBoxWeekdayParsingControl1";
            this.groupBoxWeekdayParsingControl1.Size = new System.Drawing.Size(456, 135);
            this.groupBoxWeekdayParsingControl1.TabIndex = 7;
            // 
            // groupBoxEnumerationsControl1
            // 
            this.groupBoxEnumerationsControl1.Location = new System.Drawing.Point(2, 3);
            this.groupBoxEnumerationsControl1.Name = "groupBoxEnumerationsControl1";
            this.groupBoxEnumerationsControl1.Size = new System.Drawing.Size(780, 276);
            this.groupBoxEnumerationsControl1.TabIndex = 6;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 0);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(389, 417);
            this.rectanglesControl1.TabIndex = 2;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(395, 0);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(389, 417);
            this.moviesControl1.TabIndex = 2;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(786, 415);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumsTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TextBox MovieDurationMinutesTextBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox MovieReleaseYearTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.Label MovieReleaseYearLabel;
        private System.Windows.Forms.Label MovieDurationMinutesLabel;
        private System.Windows.Forms.Button FindMoviesButton;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.EnumerationsControl groupBoxEnumerationsControl1;
        private Panels.WeekdayParsingControl groupBoxWeekdayParsingControl1;
        private Panels.SeasonsHandleControl groupBoxSeasonsHandleControl1;
        private Panels.RectanglesControl rectanglesControl1;
        private Panels.MoviesControl moviesControl1;
    }
}

