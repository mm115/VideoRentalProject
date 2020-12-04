using System;

namespace VideoRentalProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button LoadBt;
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MovieBt = new System.Windows.Forms.Button();
            this.RentalBt = new System.Windows.Forms.Button();
            this.ADDBt = new System.Windows.Forms.Button();
            this.MovieTb = new System.Windows.Forms.TextBox();
            this.RatingTb = new System.Windows.Forms.TextBox();
            this.Titletb = new System.Windows.Forms.TextBox();
            this.YearTb = new System.Windows.Forms.TextBox();
            this.RatingLable = new System.Windows.Forms.Label();
            this.MovieLable = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.YearLable = new System.Windows.Forms.Label();
            this.RentalTb = new System.Windows.Forms.TextBox();
            this.CpiesTb = new System.Windows.Forms.TextBox();
            this.PlotTb = new System.Windows.Forms.TextBox();
            this.GenreTb = new System.Windows.Forms.TextBox();
            this.CopiesLable = new System.Windows.Forms.Label();
            this.RntlCstLable = new System.Windows.Forms.Label();
            this.PlotLable = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.UpdateMovie = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.IssueMovie = new System.Windows.Forms.Button();
            this.ReturnMovie = new System.Windows.Forms.Button();
            this.PopularMovie = new System.Windows.Forms.Button();
            this.PopularCustomer = new System.Windows.Forms.Button();
            this.AddCBt = new System.Windows.Forms.Button();
            this.NTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.ADDTB = new System.Windows.Forms.TextBox();
            this.PHTB = new System.Windows.Forms.TextBox();
            this.LNLable = new System.Windows.Forms.Label();
            this.NLable = new System.Windows.Forms.Label();
            this.AddLable = new System.Windows.Forms.Label();
            this.PhLable = new System.Windows.Forms.Label();
            this.UPBT = new System.Windows.Forms.Button();
            this.DltCustBt = new System.Windows.Forms.Button();
            this.CustIDTBox = new System.Windows.Forms.Label();
            this.CustTBox = new System.Windows.Forms.TextBox();
            LoadBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBt
            // 
            LoadBt.Location = new System.Drawing.Point(8, 3);
            LoadBt.Margin = new System.Windows.Forms.Padding(2);
            LoadBt.Name = "LoadBt";
            LoadBt.Size = new System.Drawing.Size(60, 57);
            LoadBt.TabIndex = 0;
            LoadBt.Text = "Load Customer ";
            LoadBt.UseVisualStyleBackColor = true;
            LoadBt.Click += new System.EventHandler(this.LoadBt_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(8, 106);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(2);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 62;
            this.MainGrid.RowTemplate.Height = 28;
            this.MainGrid.Size = new System.Drawing.Size(553, 277);
            this.MainGrid.TabIndex = 1;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGrid_CellContentClick);
            // 
            // MovieBt
            // 
            this.MovieBt.Location = new System.Drawing.Point(-2, 414);
            this.MovieBt.Margin = new System.Windows.Forms.Padding(2);
            this.MovieBt.Name = "MovieBt";
            this.MovieBt.Size = new System.Drawing.Size(64, 57);
            this.MovieBt.TabIndex = 2;
            this.MovieBt.Text = "Load Movie ";
            this.MovieBt.UseVisualStyleBackColor = true;
            this.MovieBt.Click += new System.EventHandler(this.MovieBt_Click);
            // 
            // RentalBt
            // 
            this.RentalBt.Location = new System.Drawing.Point(66, 415);
            this.RentalBt.Margin = new System.Windows.Forms.Padding(2);
            this.RentalBt.Name = "RentalBt";
            this.RentalBt.Size = new System.Drawing.Size(63, 56);
            this.RentalBt.TabIndex = 3;
            this.RentalBt.Text = "Load Rented";
            this.RentalBt.UseVisualStyleBackColor = true;
            this.RentalBt.Click += new System.EventHandler(this.RentalBt_Click);
            // 
            // ADDBt
            // 
            this.ADDBt.Location = new System.Drawing.Point(133, 425);
            this.ADDBt.Margin = new System.Windows.Forms.Padding(2);
            this.ADDBt.Name = "ADDBt";
            this.ADDBt.Size = new System.Drawing.Size(60, 46);
            this.ADDBt.TabIndex = 13;
            this.ADDBt.Text = "Add Movie";
            this.ADDBt.UseVisualStyleBackColor = true;
            this.ADDBt.Click += new System.EventHandler(this.ADDBt_Click);
            // 
            // MovieTb
            // 
            this.MovieTb.Enabled = false;
            this.MovieTb.Location = new System.Drawing.Point(354, 439);
            this.MovieTb.Margin = new System.Windows.Forms.Padding(2);
            this.MovieTb.Name = "MovieTb";
            this.MovieTb.Size = new System.Drawing.Size(52, 20);
            this.MovieTb.TabIndex = 14;
            this.MovieTb.TextChanged += new System.EventHandler(this.MovieTb_TextChanged);
            // 
            // RatingTb
            // 
            this.RatingTb.Location = new System.Drawing.Point(418, 439);
            this.RatingTb.Margin = new System.Windows.Forms.Padding(2);
            this.RatingTb.Name = "RatingTb";
            this.RatingTb.Size = new System.Drawing.Size(59, 20);
            this.RatingTb.TabIndex = 15;
            // 
            // Titletb
            // 
            this.Titletb.Location = new System.Drawing.Point(493, 439);
            this.Titletb.Margin = new System.Windows.Forms.Padding(2);
            this.Titletb.Name = "Titletb";
            this.Titletb.Size = new System.Drawing.Size(51, 20);
            this.Titletb.TabIndex = 16;
            // 
            // YearTb
            // 
            this.YearTb.Location = new System.Drawing.Point(554, 439);
            this.YearTb.Margin = new System.Windows.Forms.Padding(2);
            this.YearTb.Name = "YearTb";
            this.YearTb.Size = new System.Drawing.Size(53, 20);
            this.YearTb.TabIndex = 17;
            // 
            // RatingLable
            // 
            this.RatingLable.AutoSize = true;
            this.RatingLable.Location = new System.Drawing.Point(429, 413);
            this.RatingLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLable.Name = "RatingLable";
            this.RatingLable.Size = new System.Drawing.Size(38, 13);
            this.RatingLable.TabIndex = 18;
            this.RatingLable.Text = "Rating";
            // 
            // MovieLable
            // 
            this.MovieLable.AutoSize = true;
            this.MovieLable.Location = new System.Drawing.Point(352, 413);
            this.MovieLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieLable.Name = "MovieLable";
            this.MovieLable.Size = new System.Drawing.Size(45, 13);
            this.MovieLable.TabIndex = 19;
            this.MovieLable.Text = "MovieId";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(504, 411);
            this.TitleLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(27, 13);
            this.TitleLable.TabIndex = 20;
            this.TitleLable.Text = "Title";
            // 
            // YearLable
            // 
            this.YearLable.AutoSize = true;
            this.YearLable.Location = new System.Drawing.Point(561, 413);
            this.YearLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearLable.Name = "YearLable";
            this.YearLable.Size = new System.Drawing.Size(29, 13);
            this.YearLable.TabIndex = 21;
            this.YearLable.Text = "Year";
            // 
            // RentalTb
            // 
            this.RentalTb.Location = new System.Drawing.Point(630, 439);
            this.RentalTb.Margin = new System.Windows.Forms.Padding(2);
            this.RentalTb.Name = "RentalTb";
            this.RentalTb.Size = new System.Drawing.Size(52, 20);
            this.RentalTb.TabIndex = 22;
            // 
            // CpiesTb
            // 
            this.CpiesTb.Location = new System.Drawing.Point(694, 439);
            this.CpiesTb.Margin = new System.Windows.Forms.Padding(2);
            this.CpiesTb.Name = "CpiesTb";
            this.CpiesTb.Size = new System.Drawing.Size(59, 20);
            this.CpiesTb.TabIndex = 23;
            // 
            // PlotTb
            // 
            this.PlotTb.Location = new System.Drawing.Point(769, 439);
            this.PlotTb.Margin = new System.Windows.Forms.Padding(2);
            this.PlotTb.Name = "PlotTb";
            this.PlotTb.Size = new System.Drawing.Size(51, 20);
            this.PlotTb.TabIndex = 24;
            // 
            // GenreTb
            // 
            this.GenreTb.Location = new System.Drawing.Point(838, 439);
            this.GenreTb.Margin = new System.Windows.Forms.Padding(2);
            this.GenreTb.Name = "GenreTb";
            this.GenreTb.Size = new System.Drawing.Size(45, 20);
            this.GenreTb.TabIndex = 25;
            // 
            // CopiesLable
            // 
            this.CopiesLable.AutoSize = true;
            this.CopiesLable.Location = new System.Drawing.Point(705, 413);
            this.CopiesLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CopiesLable.Name = "CopiesLable";
            this.CopiesLable.Size = new System.Drawing.Size(39, 13);
            this.CopiesLable.TabIndex = 26;
            this.CopiesLable.Text = "Copies";
            // 
            // RntlCstLable
            // 
            this.RntlCstLable.AutoSize = true;
            this.RntlCstLable.Location = new System.Drawing.Point(628, 413);
            this.RntlCstLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RntlCstLable.Name = "RntlCstLable";
            this.RntlCstLable.Size = new System.Drawing.Size(59, 13);
            this.RntlCstLable.TabIndex = 27;
            this.RntlCstLable.Text = "RentalCost";
            // 
            // PlotLable
            // 
            this.PlotLable.AutoSize = true;
            this.PlotLable.Location = new System.Drawing.Point(780, 411);
            this.PlotLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlotLable.Name = "PlotLable";
            this.PlotLable.Size = new System.Drawing.Size(25, 13);
            this.PlotLable.TabIndex = 28;
            this.PlotLable.Text = "Plot";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(841, 413);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 29;
            this.GenreLabel.Text = "Genre";
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.Location = new System.Drawing.Point(197, 425);
            this.UpdateMovie.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(65, 46);
            this.UpdateMovie.TabIndex = 34;
            this.UpdateMovie.Text = "Update Movie";
            this.UpdateMovie.UseVisualStyleBackColor = true;
            this.UpdateMovie.Click += new System.EventHandler(this.UpdateMovie_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(268, 425);
            this.DeleteMovie.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(70, 46);
            this.DeleteMovie.TabIndex = 35;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // IssueMovie
            // 
            this.IssueMovie.Location = new System.Drawing.Point(605, 106);
            this.IssueMovie.Margin = new System.Windows.Forms.Padding(2);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(63, 56);
            this.IssueMovie.TabIndex = 36;
            this.IssueMovie.Text = "Issue Movie";
            this.IssueMovie.UseVisualStyleBackColor = true;
            this.IssueMovie.Click += new System.EventHandler(this.IssueMovie_Click);
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.Location = new System.Drawing.Point(605, 180);
            this.ReturnMovie.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(63, 56);
            this.ReturnMovie.TabIndex = 37;
            this.ReturnMovie.Text = "Return Movie";
            this.ReturnMovie.UseVisualStyleBackColor = true;
            this.ReturnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // PopularMovie
            // 
            this.PopularMovie.Location = new System.Drawing.Point(708, 106);
            this.PopularMovie.Margin = new System.Windows.Forms.Padding(2);
            this.PopularMovie.Name = "PopularMovie";
            this.PopularMovie.Size = new System.Drawing.Size(63, 56);
            this.PopularMovie.TabIndex = 38;
            this.PopularMovie.Text = "Popular Movie";
            this.PopularMovie.UseVisualStyleBackColor = true;
            this.PopularMovie.Click += new System.EventHandler(this.PopularMovie_Click);
            // 
            // PopularCustomer
            // 
            this.PopularCustomer.Location = new System.Drawing.Point(708, 180);
            this.PopularCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.PopularCustomer.Name = "PopularCustomer";
            this.PopularCustomer.Size = new System.Drawing.Size(63, 56);
            this.PopularCustomer.TabIndex = 39;
            this.PopularCustomer.Text = "Popular Customer";
            this.PopularCustomer.UseVisualStyleBackColor = true;
            this.PopularCustomer.Click += new System.EventHandler(this.PopularCustomer_Click);
            // 
            // AddCBt
            // 
            this.AddCBt.Location = new System.Drawing.Point(81, 3);
            this.AddCBt.Margin = new System.Windows.Forms.Padding(2);
            this.AddCBt.Name = "AddCBt";
            this.AddCBt.Size = new System.Drawing.Size(57, 50);
            this.AddCBt.TabIndex = 4;
            this.AddCBt.Text = "Add Customer";
            this.AddCBt.UseVisualStyleBackColor = true;
            this.AddCBt.Click += new System.EventHandler(this.AddCBt_Click);
            // 
            // NTBox
            // 
            this.NTBox.Location = new System.Drawing.Point(387, 27);
            this.NTBox.Margin = new System.Windows.Forms.Padding(2);
            this.NTBox.Name = "NTBox";
            this.NTBox.Size = new System.Drawing.Size(52, 20);
            this.NTBox.TabIndex = 5;
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(455, 27);
            this.LNTBox.Margin = new System.Windows.Forms.Padding(2);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(59, 20);
            this.LNTBox.TabIndex = 6;
            // 
            // ADDTB
            // 
            this.ADDTB.Location = new System.Drawing.Point(526, 27);
            this.ADDTB.Margin = new System.Windows.Forms.Padding(2);
            this.ADDTB.Name = "ADDTB";
            this.ADDTB.Size = new System.Drawing.Size(61, 20);
            this.ADDTB.TabIndex = 7;
            // 
            // PHTB
            // 
            this.PHTB.Location = new System.Drawing.Point(606, 27);
            this.PHTB.Margin = new System.Windows.Forms.Padding(2);
            this.PHTB.Name = "PHTB";
            this.PHTB.Size = new System.Drawing.Size(52, 20);
            this.PHTB.TabIndex = 8;
            // 
            // LNLable
            // 
            this.LNLable.AutoSize = true;
            this.LNLable.Location = new System.Drawing.Point(458, 12);
            this.LNLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNLable.Name = "LNLable";
            this.LNLable.Size = new System.Drawing.Size(55, 13);
            this.LNLable.TabIndex = 9;
            this.LNLable.Text = "LastName";
            // 
            // NLable
            // 
            this.NLable.AutoSize = true;
            this.NLable.Location = new System.Drawing.Point(384, 12);
            this.NLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NLable.Name = "NLable";
            this.NLable.Size = new System.Drawing.Size(54, 13);
            this.NLable.TabIndex = 10;
            this.NLable.Text = "FirstName";
            // 
            // AddLable
            // 
            this.AddLable.AutoSize = true;
            this.AddLable.Location = new System.Drawing.Point(530, 12);
            this.AddLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddLable.Name = "AddLable";
            this.AddLable.Size = new System.Drawing.Size(45, 13);
            this.AddLable.TabIndex = 11;
            this.AddLable.Text = "Address";
            // 
            // PhLable
            // 
            this.PhLable.AutoSize = true;
            this.PhLable.Location = new System.Drawing.Point(603, 12);
            this.PhLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhLable.Name = "PhLable";
            this.PhLable.Size = new System.Drawing.Size(38, 13);
            this.PhLable.TabIndex = 12;
            this.PhLable.Text = "Phone";
            // 
            // UPBT
            // 
            this.UPBT.Location = new System.Drawing.Point(142, 3);
            this.UPBT.Margin = new System.Windows.Forms.Padding(2);
            this.UPBT.Name = "UPBT";
            this.UPBT.Size = new System.Drawing.Size(68, 50);
            this.UPBT.TabIndex = 30;
            this.UPBT.Text = "Update Customer";
            this.UPBT.UseVisualStyleBackColor = true;
            this.UPBT.Click += new System.EventHandler(this.UPBT_Click);
            // 
            // DltCustBt
            // 
            this.DltCustBt.Location = new System.Drawing.Point(216, 3);
            this.DltCustBt.Margin = new System.Windows.Forms.Padding(2);
            this.DltCustBt.Name = "DltCustBt";
            this.DltCustBt.Size = new System.Drawing.Size(70, 50);
            this.DltCustBt.TabIndex = 31;
            this.DltCustBt.Text = "Delete Customer";
            this.DltCustBt.UseVisualStyleBackColor = true;
            this.DltCustBt.Click += new System.EventHandler(this.DltCustBt_Click);
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.AutoSize = true;
            this.CustIDTBox.Location = new System.Drawing.Point(304, 12);
            this.CustIDTBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(62, 13);
            this.CustIDTBox.TabIndex = 32;
            this.CustIDTBox.Text = "CustomerID";
            // 
            // CustTBox
            // 
            this.CustTBox.Enabled = false;
            this.CustTBox.Location = new System.Drawing.Point(306, 27);
            this.CustTBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustTBox.Name = "CustTBox";
            this.CustTBox.Size = new System.Drawing.Size(62, 20);
            this.CustTBox.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 522);
            this.Controls.Add(this.PopularCustomer);
            this.Controls.Add(this.PopularMovie);
            this.Controls.Add(this.ReturnMovie);
            this.Controls.Add(this.IssueMovie);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.UpdateMovie);
            this.Controls.Add(this.CustTBox);
            this.Controls.Add(this.CustIDTBox);
            this.Controls.Add(this.DltCustBt);
            this.Controls.Add(this.UPBT);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLable);
            this.Controls.Add(this.RntlCstLable);
            this.Controls.Add(this.CopiesLable);
            this.Controls.Add(this.GenreTb);
            this.Controls.Add(this.PlotTb);
            this.Controls.Add(this.CpiesTb);
            this.Controls.Add(this.RentalTb);
            this.Controls.Add(this.YearLable);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.MovieLable);
            this.Controls.Add(this.RatingLable);
            this.Controls.Add(this.YearTb);
            this.Controls.Add(this.Titletb);
            this.Controls.Add(this.RatingTb);
            this.Controls.Add(this.MovieTb);
            this.Controls.Add(this.ADDBt);
            this.Controls.Add(this.PhLable);
            this.Controls.Add(this.AddLable);
            this.Controls.Add(this.NLable);
            this.Controls.Add(this.LNLable);
            this.Controls.Add(this.PHTB);
            this.Controls.Add(this.ADDTB);
            this.Controls.Add(this.LNTBox);
            this.Controls.Add(this.NTBox);
            this.Controls.Add(this.AddCBt);
            this.Controls.Add(this.RentalBt);
            this.Controls.Add(this.MovieBt);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(LoadBt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "VideoRental";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button MovieBt;
        private System.Windows.Forms.Button RentalBt;
        private System.Windows.Forms.Button ADDBt;
        private System.Windows.Forms.TextBox MovieTb;
        private System.Windows.Forms.TextBox RatingTb;
        private System.Windows.Forms.TextBox Titletb;
        private System.Windows.Forms.TextBox YearTb;
        private System.Windows.Forms.Label RatingLable;
        private System.Windows.Forms.Label MovieLable;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label YearLable;
        private System.Windows.Forms.TextBox RentalTb;
        private System.Windows.Forms.TextBox CpiesTb;
        private System.Windows.Forms.TextBox PlotTb;
        private System.Windows.Forms.TextBox GenreTb;
        private System.Windows.Forms.Label CopiesLable;
        private System.Windows.Forms.Label RntlCstLable;
        private System.Windows.Forms.Label PlotLable;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button UpdateMovie;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button IssueMovie;
        private System.Windows.Forms.Button ReturnMovie;
        private System.Windows.Forms.Button PopularMovie;
        private System.Windows.Forms.Button PopularCustomer;
        private System.Windows.Forms.Button AddCBt;
        private System.Windows.Forms.TextBox NTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.TextBox ADDTB;
        private System.Windows.Forms.TextBox PHTB;
        private System.Windows.Forms.Label LNLable;
        private System.Windows.Forms.Label NLable;
        private System.Windows.Forms.Label AddLable;
        private System.Windows.Forms.Label PhLable;
        private System.Windows.Forms.Button UPBT;
        private System.Windows.Forms.Button DltCustBt;
        private System.Windows.Forms.Label CustIDTBox;
        private System.Windows.Forms.TextBox CustTBox;
    }
}

