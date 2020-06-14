namespace DSED_02_Movies
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVRentedMovies = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVMostPopular = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGVCustomerRank = new System.Windows.Forms.DataGridView();
            this.TXTFirstName = new System.Windows.Forms.TextBox();
            this.TXTLastName = new System.Windows.Forms.TextBox();
            this.TXTAddress = new System.Windows.Forms.TextBox();
            this.TXTPhoneNumber = new System.Windows.Forms.TextBox();
            this.TXTMovieTitle = new System.Windows.Forms.TextBox();
            this.TXTYear = new System.Windows.Forms.TextBox();
            this.TXTRentalCost = new System.Windows.Forms.TextBox();
            this.CustIDtxt = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.MovieIDtxt = new System.Windows.Forms.TextBox();
            this.TXTDate = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.TXTRating = new System.Windows.Forms.TextBox();
            this.TXTCopies = new System.Windows.Forms.TextBox();
            this.TXTPlot = new System.Windows.Forms.TextBox();
            this.TXTGenre = new System.Windows.Forms.TextBox();
            this.TXTMovieDate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.txtDateRented = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.lblRMID = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostPopular)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomerRank)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Customers);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Location = new System.Drawing.Point(30, 16);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1127, 342);
            this.TabControl.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.DGVCustomer);
            this.Customers.Location = new System.Drawing.Point(4, 29);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1119, 309);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Location = new System.Drawing.Point(1, 1);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 62;
            this.DGVCustomer.RowTemplate.Height = 28;
            this.DGVCustomer.Size = new System.Drawing.Size(1118, 308);
            this.DGVCustomer.TabIndex = 0;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(1, 1);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowHeadersWidth = 62;
            this.DGVMovies.RowTemplate.Height = 28;
            this.DGVMovies.Size = new System.Drawing.Size(1118, 308);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVRentedMovies);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1119, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVRentedMovies
            // 
            this.DGVRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentedMovies.Location = new System.Drawing.Point(1, 1);
            this.DGVRentedMovies.Name = "DGVRentedMovies";
            this.DGVRentedMovies.RowHeadersWidth = 62;
            this.DGVRentedMovies.RowTemplate.Height = 28;
            this.DGVRentedMovies.Size = new System.Drawing.Size(1118, 308);
            this.DGVRentedMovies.TabIndex = 1;
            this.DGVRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentedMovies_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVMostPopular);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1119, 309);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "PopularMovie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVMostPopular
            // 
            this.DGVMostPopular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMostPopular.Location = new System.Drawing.Point(0, 0);
            this.DGVMostPopular.Name = "DGVMostPopular";
            this.DGVMostPopular.RowHeadersWidth = 62;
            this.DGVMostPopular.RowTemplate.Height = 28;
            this.DGVMostPopular.Size = new System.Drawing.Size(1119, 309);
            this.DGVMostPopular.TabIndex = 31;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGVCustomerRank);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1119, 309);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Customer Rankings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGVCustomerRank
            // 
            this.DGVCustomerRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomerRank.Location = new System.Drawing.Point(0, 0);
            this.DGVCustomerRank.Name = "DGVCustomerRank";
            this.DGVCustomerRank.RowHeadersWidth = 62;
            this.DGVCustomerRank.RowTemplate.Height = 28;
            this.DGVCustomerRank.Size = new System.Drawing.Size(1119, 309);
            this.DGVCustomerRank.TabIndex = 32;
            // 
            // TXTFirstName
            // 
            this.TXTFirstName.Location = new System.Drawing.Point(175, 415);
            this.TXTFirstName.Name = "TXTFirstName";
            this.TXTFirstName.Size = new System.Drawing.Size(94, 26);
            this.TXTFirstName.TabIndex = 1;
            // 
            // TXTLastName
            // 
            this.TXTLastName.Location = new System.Drawing.Point(275, 414);
            this.TXTLastName.Name = "TXTLastName";
            this.TXTLastName.Size = new System.Drawing.Size(94, 26);
            this.TXTLastName.TabIndex = 2;
            // 
            // TXTAddress
            // 
            this.TXTAddress.Location = new System.Drawing.Point(375, 414);
            this.TXTAddress.Name = "TXTAddress";
            this.TXTAddress.Size = new System.Drawing.Size(151, 26);
            this.TXTAddress.TabIndex = 3;
            // 
            // TXTPhoneNumber
            // 
            this.TXTPhoneNumber.Location = new System.Drawing.Point(532, 414);
            this.TXTPhoneNumber.Name = "TXTPhoneNumber";
            this.TXTPhoneNumber.Size = new System.Drawing.Size(135, 26);
            this.TXTPhoneNumber.TabIndex = 4;
            // 
            // TXTMovieTitle
            // 
            this.TXTMovieTitle.Location = new System.Drawing.Point(174, 501);
            this.TXTMovieTitle.Name = "TXTMovieTitle";
            this.TXTMovieTitle.Size = new System.Drawing.Size(151, 26);
            this.TXTMovieTitle.TabIndex = 5;
            // 
            // TXTYear
            // 
            this.TXTYear.Location = new System.Drawing.Point(331, 501);
            this.TXTYear.Name = "TXTYear";
            this.TXTYear.Size = new System.Drawing.Size(95, 26);
            this.TXTYear.TabIndex = 6;
            // 
            // TXTRentalCost
            // 
            this.TXTRentalCost.Location = new System.Drawing.Point(432, 501);
            this.TXTRentalCost.Name = "TXTRentalCost";
            this.TXTRentalCost.Size = new System.Drawing.Size(110, 26);
            this.TXTRentalCost.TabIndex = 7;
            // 
            // CustIDtxt
            // 
            this.CustIDtxt.Enabled = false;
            this.CustIDtxt.Location = new System.Drawing.Point(175, 383);
            this.CustIDtxt.Name = "CustIDtxt";
            this.CustIDtxt.Size = new System.Drawing.Size(55, 26);
            this.CustIDtxt.TabIndex = 8;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(30, 383);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(133, 67);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "Add/Update Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(30, 471);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(133, 67);
            this.btnAddMovie.TabIndex = 10;
            this.btnAddMovie.Text = "Add/Update Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // MovieIDtxt
            // 
            this.MovieIDtxt.Enabled = false;
            this.MovieIDtxt.Location = new System.Drawing.Point(174, 471);
            this.MovieIDtxt.Name = "MovieIDtxt";
            this.MovieIDtxt.Size = new System.Drawing.Size(55, 26);
            this.MovieIDtxt.TabIndex = 11;
            // 
            // TXTDate
            // 
            this.TXTDate.Location = new System.Drawing.Point(673, 414);
            this.TXTDate.Name = "TXTDate";
            this.TXTDate.Size = new System.Drawing.Size(146, 26);
            this.TXTDate.TabIndex = 12;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(453, 360);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(151, 48);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // TXTRating
            // 
            this.TXTRating.Location = new System.Drawing.Point(235, 471);
            this.TXTRating.Name = "TXTRating";
            this.TXTRating.Size = new System.Drawing.Size(55, 26);
            this.TXTRating.TabIndex = 15;
            // 
            // TXTCopies
            // 
            this.TXTCopies.Location = new System.Drawing.Point(548, 501);
            this.TXTCopies.Name = "TXTCopies";
            this.TXTCopies.Size = new System.Drawing.Size(53, 26);
            this.TXTCopies.TabIndex = 16;
            // 
            // TXTPlot
            // 
            this.TXTPlot.Location = new System.Drawing.Point(174, 533);
            this.TXTPlot.Name = "TXTPlot";
            this.TXTPlot.Size = new System.Drawing.Size(645, 26);
            this.TXTPlot.TabIndex = 17;
            // 
            // TXTGenre
            // 
            this.TXTGenre.Location = new System.Drawing.Point(607, 501);
            this.TXTGenre.Name = "TXTGenre";
            this.TXTGenre.Size = new System.Drawing.Size(95, 26);
            this.TXTGenre.TabIndex = 18;
            // 
            // TXTMovieDate
            // 
            this.TXTMovieDate.Location = new System.Drawing.Point(708, 501);
            this.TXTMovieDate.Name = "TXTMovieDate";
            this.TXTMovieDate.Size = new System.Drawing.Size(111, 26);
            this.TXTMovieDate.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 48);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(842, 364);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(113, 96);
            this.btnIssue.TabIndex = 22;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(842, 471);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(113, 96);
            this.btnRent.TabIndex = 23;
            this.btnRent.Text = "Return Movie";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // txtDateRented
            // 
            this.txtDateRented.Location = new System.Drawing.Point(961, 388);
            this.txtDateRented.Name = "txtDateRented";
            this.txtDateRented.Size = new System.Drawing.Size(192, 26);
            this.txtDateRented.TabIndex = 24;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(961, 439);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(192, 26);
            this.txtDateReturned.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(957, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Return Date";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(296, 360);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(151, 48);
            this.btnUpdateCustomer.TabIndex = 28;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(296, 447);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(151, 48);
            this.btnUpdateMovie.TabIndex = 29;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // lblRMID
            // 
            this.lblRMID.AutoSize = true;
            this.lblRMID.Location = new System.Drawing.Point(1136, 365);
            this.lblRMID.Name = "lblRMID";
            this.lblRMID.Size = new System.Drawing.Size(0, 20);
            this.lblRMID.TabIndex = 30;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Enabled = false;
            this.btnUpdatePrice.Location = new System.Drawing.Point(983, 496);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(153, 70);
            this.btnUpdatePrice.TabIndex = 31;
            this.btnUpdatePrice.Text = "Update Movie Fee";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 595);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.lblRMID);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDateRented);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXTMovieDate);
            this.Controls.Add(this.TXTGenre);
            this.Controls.Add(this.TXTPlot);
            this.Controls.Add(this.TXTCopies);
            this.Controls.Add(this.TXTRating);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.TXTDate);
            this.Controls.Add(this.MovieIDtxt);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.CustIDtxt);
            this.Controls.Add(this.TXTRentalCost);
            this.Controls.Add(this.TXTYear);
            this.Controls.Add(this.TXTMovieTitle);
            this.Controls.Add(this.TXTPhoneNumber);
            this.Controls.Add(this.TXTAddress);
            this.Controls.Add(this.TXTLastName);
            this.Controls.Add(this.TXTFirstName);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentedMovies)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMostPopular)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomerRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVRentedMovies;
        private System.Windows.Forms.TextBox TXTFirstName;
        private System.Windows.Forms.TextBox TXTLastName;
        private System.Windows.Forms.TextBox TXTAddress;
        private System.Windows.Forms.TextBox TXTPhoneNumber;
        private System.Windows.Forms.TextBox TXTMovieTitle;
        private System.Windows.Forms.TextBox TXTYear;
        private System.Windows.Forms.TextBox TXTRentalCost;
        private System.Windows.Forms.TextBox CustIDtxt;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox MovieIDtxt;
        private System.Windows.Forms.TextBox TXTDate;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox TXTRating;
        private System.Windows.Forms.TextBox TXTCopies;
        private System.Windows.Forms.TextBox TXTPlot;
        private System.Windows.Forms.TextBox TXTGenre;
        private System.Windows.Forms.TextBox TXTMovieDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.TextBox txtDateRented;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Label lblRMID;
        private System.Windows.Forms.DataGridView DGVMostPopular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGVCustomerRank;
        private System.Windows.Forms.Button btnUpdatePrice;
    }
}

