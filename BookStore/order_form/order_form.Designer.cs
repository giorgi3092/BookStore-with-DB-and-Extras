namespace BookStore
{
    partial class BookStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStoreForm));
            this.BookList = new System.Windows.Forms.ComboBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.OrderSummarydataGridView = new System.Windows.Forms.DataGridView();
            this.AddToCart = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.NumericUpDown();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SubtotalBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSummarydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(58, 27);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(670, 21);
            this.BookList.TabIndex = 0;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(103, 77);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.ReadOnly = true;
            this.AuthorBox.Size = new System.Drawing.Size(232, 20);
            this.AuthorBox.TabIndex = 1;
            this.AuthorBox.Tag = "";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(26, 73);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(71, 24);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(461, 72);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(57, 24);
            this.ISBNLabel.TabIndex = 3;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // ISBNBox
            // 
            this.ISBNBox.Location = new System.Drawing.Point(524, 77);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.ReadOnly = true;
            this.ISBNBox.Size = new System.Drawing.Size(232, 20);
            this.ISBNBox.TabIndex = 4;
            this.ISBNBox.Tag = "";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(255, 144);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(58, 24);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(319, 148);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(166, 20);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.Tag = "";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(361, 182);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(78, 24);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Quantity";
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummaryLabel.Location = new System.Drawing.Point(326, 280);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(144, 24);
            this.OrderSummaryLabel.TabIndex = 9;
            this.OrderSummaryLabel.Text = "Order Summary";
            // 
            // OrderSummarydataGridView
            // 
            this.OrderSummarydataGridView.AllowUserToAddRows = false;
            this.OrderSummarydataGridView.AllowUserToDeleteRows = false;
            this.OrderSummarydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderSummarydataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderSummarydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSummarydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Quantity,
            this.Column1,
            this.Subtotal});
            this.OrderSummarydataGridView.Location = new System.Drawing.Point(83, 307);
            this.OrderSummarydataGridView.Name = "OrderSummarydataGridView";
            this.OrderSummarydataGridView.ReadOnly = true;
            this.OrderSummarydataGridView.Size = new System.Drawing.Size(635, 150);
            this.OrderSummarydataGridView.TabIndex = 10;
            // 
            // AddToCart
            // 
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart.Location = new System.Drawing.Point(347, 244);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(105, 33);
            this.AddToCart.TabIndex = 11;
            this.AddToCart.Text = "Add to Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(347, 209);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(105, 20);
            this.QuantityBox.TabIndex = 12;
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOrderButton.Location = new System.Drawing.Point(182, 501);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(194, 41);
            this.ConfirmOrderButton.TabIndex = 13;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrderButton.Location = new System.Drawing.Point(409, 501);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(194, 41);
            this.CancelOrderButton.TabIndex = 14;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.Location = new System.Drawing.Point(99, 470);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(82, 24);
            this.SubtotalLabel.TabIndex = 15;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Location = new System.Drawing.Point(182, 470);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.ReadOnly = true;
            this.SubtotalBox.Size = new System.Drawing.Size(105, 20);
            this.SubtotalBox.TabIndex = 16;
            this.SubtotalBox.Tag = "";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(315, 465);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(47, 24);
            this.TaxLabel.TabIndex = 17;
            this.TaxLabel.Text = "Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(510, 466);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(56, 24);
            this.TotalLabel.TabIndex = 19;
            this.TotalLabel.Text = "Total:";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Price";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Line Total";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // TaxBox
            // 
            this.TaxBox.Location = new System.Drawing.Point(361, 466);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.ReadOnly = true;
            this.TaxBox.Size = new System.Drawing.Size(124, 20);
            this.TaxBox.TabIndex = 21;
            this.TaxBox.Tag = "";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(572, 466);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(124, 20);
            this.TotalBox.TabIndex = 22;
            this.TotalBox.Tag = "";
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TaxBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubtotalBox);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.OrderSummarydataGridView);
            this.Controls.Add(this.OrderSummaryLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ISBNBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.BookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookStoreForm";
            this.Text = "Order your Favorite Books";
            this.Load += new System.EventHandler(this.BookStoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderSummarydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BookList;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.DataGridView OrderSummarydataGridView;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.NumericUpDown QuantityBox;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.TextBox SubtotalBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox TaxBox;
        private System.Windows.Forms.TextBox TotalBox;
    }
}

