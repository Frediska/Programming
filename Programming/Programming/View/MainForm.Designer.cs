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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ParsingButton = new System.Windows.Forms.Button();
            this.ValueForParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleIDLabel = new System.Windows.Forms.Label();
            this.RectangleIDTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.FindRectanglesButton = new System.Windows.Forms.Button();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SelectedRectangleLenghtLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleWidthLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleYLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleXLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleIDLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLenghtTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleYTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleXTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleIDTextBox = new System.Windows.Forms.TextBox();
            this.CanvaPanel = new System.Windows.Forms.Panel();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.Rectangles2ListBox = new System.Windows.Forms.ListBox();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SelectedRectangleabel = new System.Windows.Forms.Label();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsTabControl.Controls.Add(this.tabPage1);
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(800, 450);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 421);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(465, 282);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(317, 135);
            this.SeasonHandleGroupBox.TabIndex = 5;
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
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ValueForParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 282);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(456, 135);
            this.WeekdayParsingGroupBox.TabIndex = 4;
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
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(3, 0);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(780, 276);
            this.EnumerationsGroupBox.TabIndex = 3;
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
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 421);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.FindMoviesButton);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationMinutesLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieReleaseYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieReleaseYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationMinutesTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(399, 0);
            this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MoviesGroupBox.Size = new System.Drawing.Size(384, 417);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // FindMoviesButton
            // 
            this.FindMoviesButton.Location = new System.Drawing.Point(192, 349);
            this.FindMoviesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(100, 28);
            this.FindMoviesButton.TabIndex = 11;
            this.FindMoviesButton.Text = "Find";
            this.FindMoviesButton.UseVisualStyleBackColor = true;
            this.FindMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // MovieDurationMinutesLabel
            // 
            this.MovieDurationMinutesLabel.AutoSize = true;
            this.MovieDurationMinutesLabel.Location = new System.Drawing.Point(192, 233);
            this.MovieDurationMinutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieDurationMinutesLabel.Name = "MovieDurationMinutesLabel";
            this.MovieDurationMinutesLabel.Size = new System.Drawing.Size(60, 16);
            this.MovieDurationMinutesLabel.TabIndex = 10;
            this.MovieDurationMinutesLabel.Text = "Duration:";
            // 
            // MovieReleaseYearLabel
            // 
            this.MovieReleaseYearLabel.AutoSize = true;
            this.MovieReleaseYearLabel.Location = new System.Drawing.Point(192, 182);
            this.MovieReleaseYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieReleaseYearLabel.Name = "MovieReleaseYearLabel";
            this.MovieReleaseYearLabel.Size = new System.Drawing.Size(92, 16);
            this.MovieReleaseYearLabel.TabIndex = 9;
            this.MovieReleaseYearLabel.Text = "Release year:";
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(192, 132);
            this.MovieRatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(49, 16);
            this.MovieRatingLabel.TabIndex = 8;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(192, 80);
            this.MovieGenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(47, 16);
            this.MovieGenreLabel.TabIndex = 7;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(192, 28);
            this.MovieTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(36, 16);
            this.MovieTitleLabel.TabIndex = 6;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MovieReleaseYearTextBox
            // 
            this.MovieReleaseYearTextBox.Location = new System.Drawing.Point(192, 202);
            this.MovieReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            this.MovieReleaseYearTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieReleaseYearTextBox.TabIndex = 5;
            this.MovieReleaseYearTextBox.TextChanged += new System.EventHandler(this.MovieReleaseYearTextBox_TextChanged);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(192, 100);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieGenreTextBox.TabIndex = 4;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieDurationMinutesTextBox
            // 
            this.MovieDurationMinutesTextBox.Location = new System.Drawing.Point(192, 252);
            this.MovieDurationMinutesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDurationMinutesTextBox.Name = "MovieDurationMinutesTextBox";
            this.MovieDurationMinutesTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieDurationMinutesTextBox.TabIndex = 3;
            this.MovieDurationMinutesTextBox.TextChanged += new System.EventHandler(this.MovieDurationMinutesTextBox_TextChanged);
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(192, 151);
            this.MovieRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieRatingTextBox.TabIndex = 2;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(192, 48);
            this.MovieTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(144, 22);
            this.MovieTitleTextBox.TabIndex = 1;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(8, 21);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(175, 356);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleIDLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectanglesButton);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 0);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(389, 417);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleIDLabel
            // 
            this.RectangleIDLabel.AutoSize = true;
            this.RectangleIDLabel.Location = new System.Drawing.Point(187, 284);
            this.RectangleIDLabel.Name = "RectangleIDLabel";
            this.RectangleIDLabel.Size = new System.Drawing.Size(23, 16);
            this.RectangleIDLabel.TabIndex = 13;
            this.RectangleIDLabel.Text = "ID:";
            // 
            // RectangleIDTextBox
            // 
            this.RectangleIDTextBox.Enabled = false;
            this.RectangleIDTextBox.Location = new System.Drawing.Point(190, 303);
            this.RectangleIDTextBox.Name = "RectangleIDTextBox";
            this.RectangleIDTextBox.ReadOnly = true;
            this.RectangleIDTextBox.Size = new System.Drawing.Size(141, 22);
            this.RectangleIDTextBox.TabIndex = 12;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(187, 233);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(19, 16);
            this.RectangleYLabel.TabIndex = 11;
            this.RectangleYLabel.Text = "Y:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Enabled = false;
            this.RectangleYTextBox.Location = new System.Drawing.Point(190, 252);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.ReadOnly = true;
            this.RectangleYTextBox.Size = new System.Drawing.Size(141, 22);
            this.RectangleYTextBox.TabIndex = 10;
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(187, 183);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(18, 16);
            this.RectangleXLabel.TabIndex = 9;
            this.RectangleXLabel.Text = "X:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Enabled = false;
            this.RectangleXTextBox.Location = new System.Drawing.Point(190, 202);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.ReadOnly = true;
            this.RectangleXTextBox.Size = new System.Drawing.Size(141, 22);
            this.RectangleXTextBox.TabIndex = 8;
            // 
            // FindRectanglesButton
            // 
            this.FindRectanglesButton.Location = new System.Drawing.Point(187, 349);
            this.FindRectanglesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindRectanglesButton.Name = "FindRectanglesButton";
            this.FindRectanglesButton.Size = new System.Drawing.Size(100, 28);
            this.FindRectanglesButton.TabIndex = 7;
            this.FindRectanglesButton.Text = "Find";
            this.FindRectanglesButton.UseVisualStyleBackColor = true;
            this.FindRectanglesButton.Click += new System.EventHandler(this.FindRectanglesButton_Click);
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(187, 132);
            this.RectangleColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(42, 16);
            this.RectangleColorLabel.TabIndex = 6;
            this.RectangleColorLabel.Text = "Color:";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(187, 80);
            this.RectangleWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(44, 16);
            this.RectangleWidthLabel.TabIndex = 5;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(188, 151);
            this.RectangleColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(144, 22);
            this.RectangleColorTextBox.TabIndex = 4;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(187, 100);
            this.RectangleWidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(144, 22);
            this.RectangleWidthTextBox.TabIndex = 3;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(187, 30);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(50, 16);
            this.RectangleLengthLabel.TabIndex = 2;
            this.RectangleLengthLabel.Text = "Length:";
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(187, 48);
            this.RectangleLengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(144, 22);
            this.RectangleLengthTextBox.TabIndex = 1;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(5, 21);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(175, 356);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SelectedRectangleabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleLenghtLabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleWidthLabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleYLabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleXLabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleIDLabel);
            this.tabPage1.Controls.Add(this.SelectedRectangleLenghtTextBox);
            this.tabPage1.Controls.Add(this.SelectedRectangleWidthTextBox);
            this.tabPage1.Controls.Add(this.SelectedRectangleYTextBox);
            this.tabPage1.Controls.Add(this.SelectedRectangleXTextBox);
            this.tabPage1.Controls.Add(this.SelectedRectangleIDTextBox);
            this.tabPage1.Controls.Add(this.CanvaPanel);
            this.tabPage1.Controls.Add(this.RemoveRectangleButton);
            this.tabPage1.Controls.Add(this.AddRectangleButton);
            this.tabPage1.Controls.Add(this.RectanglesLabel);
            this.tabPage1.Controls.Add(this.Rectangles2ListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rectangles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SelectedRectangleLenghtLabel
            // 
            this.SelectedRectangleLenghtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleLenghtLabel.AutoSize = true;
            this.SelectedRectangleLenghtLabel.Location = new System.Drawing.Point(7, 378);
            this.SelectedRectangleLenghtLabel.Name = "SelectedRectangleLenghtLabel";
            this.SelectedRectangleLenghtLabel.Size = new System.Drawing.Size(50, 16);
            this.SelectedRectangleLenghtLabel.TabIndex = 14;
            this.SelectedRectangleLenghtLabel.Text = "Lenght:";
            // 
            // SelectedRectangleWidthLabel
            // 
            this.SelectedRectangleWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleWidthLabel.AutoSize = true;
            this.SelectedRectangleWidthLabel.Location = new System.Drawing.Point(14, 350);
            this.SelectedRectangleWidthLabel.Name = "SelectedRectangleWidthLabel";
            this.SelectedRectangleWidthLabel.Size = new System.Drawing.Size(44, 16);
            this.SelectedRectangleWidthLabel.TabIndex = 13;
            this.SelectedRectangleWidthLabel.Text = "Width:";
            // 
            // SelectedRectangleYLabel
            // 
            this.SelectedRectangleYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleYLabel.AutoSize = true;
            this.SelectedRectangleYLabel.Location = new System.Drawing.Point(39, 322);
            this.SelectedRectangleYLabel.Name = "SelectedRectangleYLabel";
            this.SelectedRectangleYLabel.Size = new System.Drawing.Size(19, 16);
            this.SelectedRectangleYLabel.TabIndex = 12;
            this.SelectedRectangleYLabel.Text = "Y:";
            // 
            // SelectedRectangleXLabel
            // 
            this.SelectedRectangleXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleXLabel.AutoSize = true;
            this.SelectedRectangleXLabel.Location = new System.Drawing.Point(39, 294);
            this.SelectedRectangleXLabel.Name = "SelectedRectangleXLabel";
            this.SelectedRectangleXLabel.Size = new System.Drawing.Size(18, 16);
            this.SelectedRectangleXLabel.TabIndex = 11;
            this.SelectedRectangleXLabel.Text = "X:";
            // 
            // SelectedRectangleIDLabel
            // 
            this.SelectedRectangleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleIDLabel.AutoSize = true;
            this.SelectedRectangleIDLabel.Location = new System.Drawing.Point(37, 266);
            this.SelectedRectangleIDLabel.Name = "SelectedRectangleIDLabel";
            this.SelectedRectangleIDLabel.Size = new System.Drawing.Size(21, 16);
            this.SelectedRectangleIDLabel.TabIndex = 10;
            this.SelectedRectangleIDLabel.Text = "Id:";
            // 
            // SelectedRectangleLenghtTextBox
            // 
            this.SelectedRectangleLenghtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleLenghtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedRectangleLenghtTextBox.Location = new System.Drawing.Point(64, 376);
            this.SelectedRectangleLenghtTextBox.Name = "SelectedRectangleLenghtTextBox";
            this.SelectedRectangleLenghtTextBox.Size = new System.Drawing.Size(100, 22);
            this.SelectedRectangleLenghtTextBox.TabIndex = 9;
            // 
            // SelectedRectangleWidthTextBox
            // 
            this.SelectedRectangleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedRectangleWidthTextBox.Location = new System.Drawing.Point(64, 348);
            this.SelectedRectangleWidthTextBox.Name = "SelectedRectangleWidthTextBox";
            this.SelectedRectangleWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.SelectedRectangleWidthTextBox.TabIndex = 8;
            // 
            // SelectedRectangleYTextBox
            // 
            this.SelectedRectangleYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedRectangleYTextBox.Location = new System.Drawing.Point(64, 320);
            this.SelectedRectangleYTextBox.Name = "SelectedRectangleYTextBox";
            this.SelectedRectangleYTextBox.Size = new System.Drawing.Size(100, 22);
            this.SelectedRectangleYTextBox.TabIndex = 7;
            // 
            // SelectedRectangleXTextBox
            // 
            this.SelectedRectangleXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedRectangleXTextBox.Location = new System.Drawing.Point(64, 292);
            this.SelectedRectangleXTextBox.Name = "SelectedRectangleXTextBox";
            this.SelectedRectangleXTextBox.Size = new System.Drawing.Size(100, 22);
            this.SelectedRectangleXTextBox.TabIndex = 6;
            // 
            // SelectedRectangleIDTextBox
            // 
            this.SelectedRectangleIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedRectangleIDTextBox.Location = new System.Drawing.Point(64, 264);
            this.SelectedRectangleIDTextBox.Name = "SelectedRectangleIDTextBox";
            this.SelectedRectangleIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.SelectedRectangleIDTextBox.TabIndex = 5;
            // 
            // CanvaPanel
            // 
            this.CanvaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvaPanel.Location = new System.Drawing.Point(311, 6);
            this.CanvaPanel.Name = "CanvaPanel";
            this.CanvaPanel.Size = new System.Drawing.Size(475, 409);
            this.CanvaPanel.TabIndex = 4;
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(6, 10);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(79, 16);
            this.RectanglesLabel.TabIndex = 1;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // Rectangles2ListBox
            // 
            this.Rectangles2ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Rectangles2ListBox.FormattingEnabled = true;
            this.Rectangles2ListBox.ItemHeight = 16;
            this.Rectangles2ListBox.Location = new System.Drawing.Point(7, 29);
            this.Rectangles2ListBox.Name = "Rectangles2ListBox";
            this.Rectangles2ListBox.Size = new System.Drawing.Size(297, 164);
            this.Rectangles2ListBox.TabIndex = 0;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(191, 195);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 41);
            this.RemoveRectangleButton.TabIndex = 3;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(45, 195);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 41);
            this.AddRectangleButton.TabIndex = 2;
            this.AddRectangleButton.UseVisualStyleBackColor = false;
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // SelectedRectangleabel
            // 
            this.SelectedRectangleabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleabel.AutoSize = true;
            this.SelectedRectangleabel.Location = new System.Drawing.Point(4, 245);
            this.SelectedRectangleabel.Name = "SelectedRectangleabel";
            this.SelectedRectangleabel.Size = new System.Drawing.Size(129, 16);
            this.SelectedRectangleabel.TabIndex = 15;
            this.SelectedRectangleabel.Text = "Selected Rectangle:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnumsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumsTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Button ParsingButton;
        private System.Windows.Forms.Label ValueForParsingLabel;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectangleLengthLabel;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button FindRectanglesButton;
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
        private System.Windows.Forms.Label RectangleYLabel;
        private System.Windows.Forms.TextBox RectangleYTextBox;
        private System.Windows.Forms.Label RectangleXLabel;
        private System.Windows.Forms.TextBox RectangleXTextBox;
        private System.Windows.Forms.Label RectangleIDLabel;
        private System.Windows.Forms.TextBox RectangleIDTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label SelectedRectangleLenghtLabel;
        private System.Windows.Forms.Label SelectedRectangleWidthLabel;
        private System.Windows.Forms.Label SelectedRectangleYLabel;
        private System.Windows.Forms.Label SelectedRectangleXLabel;
        private System.Windows.Forms.Label SelectedRectangleIDLabel;
        private System.Windows.Forms.TextBox SelectedRectangleLenghtTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleWidthTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleYTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleXTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleIDTextBox;
        private System.Windows.Forms.Panel CanvaPanel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox Rectangles2ListBox;
        private System.Windows.Forms.Label SelectedRectangleabel;
    }
}

