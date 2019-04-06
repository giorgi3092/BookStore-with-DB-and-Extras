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
            this.TaxBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSummarydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(115, 61);
            this.BookList.Margin = new System.Windows.Forms.Padding(4);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(892, 24);
            this.BookList.TabIndex = 0;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(137, 95);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.ReadOnly = true;
            this.AuthorBox.Size = new System.Drawing.Size(308, 22);
            this.AuthorBox.TabIndex = 1;
            this.AuthorBox.Tag = "";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(35, 90);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(88, 29);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(615, 89);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(75, 29);
            this.ISBNLabel.TabIndex = 3;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // ISBNBox
            // 
            this.ISBNBox.Location = new System.Drawing.Point(699, 95);
            this.ISBNBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.ReadOnly = true;
            this.ISBNBox.Size = new System.Drawing.Size(308, 22);
            this.ISBNBox.TabIndex = 4;
            this.ISBNBox.Tag = "";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(340, 177);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(75, 29);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(425, 182);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(220, 22);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.Tag = "";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(481, 224);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(100, 29);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Quantity";
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummaryLabel.Location = new System.Drawing.Point(435, 345);
            this.OrderSummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(183, 29);
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
            this.Book_ID,
            this.Title,
            this.Quantity,
            this.Price,
            this.Subtotal,
            this.Customer_ID,
            this.Customer_name});
            this.OrderSummarydataGridView.Location = new System.Drawing.Point(21, 378);
            this.OrderSummarydataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.OrderSummarydataGridView.Name = "OrderSummarydataGridView";
            this.OrderSummarydataGridView.ReadOnly = true;
            this.OrderSummarydataGridView.Size = new System.Drawing.Size(1033, 185);
            this.OrderSummarydataGridView.TabIndex = 10;
            // 
            // AddToCart
            // 
            this.AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart.Location = new System.Drawing.Point(463, 300);
            this.AddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(140, 41);
            this.AddToCart.TabIndex = 11;
            this.AddToCart.Text = "Add to Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(463, 257);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(140, 22);
            this.QuantityBox.TabIndex = 12;
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOrderButton.Location = new System.Drawing.Point(243, 617);
            this.ConfirmOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(259, 50);
            this.ConfirmOrderButton.TabIndex = 13;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrderButton.Location = new System.Drawing.Point(545, 617);
            this.CancelOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(259, 50);
            this.CancelOrderButton.TabIndex = 14;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.Location = new System.Drawing.Point(132, 578);
            this.SubtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(107, 29);
            this.SubtotalLabel.TabIndex = 15;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Location = new System.Drawing.Point(243, 578);
            this.SubtotalBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.ReadOnly = true;
            this.SubtotalBox.Size = new System.Drawing.Size(139, 22);
            this.SubtotalBox.TabIndex = 16;
            this.SubtotalBox.Tag = "";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(420, 572);
            this.TaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(59, 29);
            this.TaxLabel.TabIndex = 17;
            this.TaxLabel.Text = "Tax:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(680, 574);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(74, 29);
            this.TotalLabel.TabIndex = 19;
            this.TotalLabel.Text = "Total:";
            // 
            // TaxBox
            // 
            this.TaxBox.Location = new System.Drawing.Point(481, 574);
            this.TaxBox.Margin = new System.Windows.Forms.Padding(4);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.ReadOnly = true;
            this.TaxBox.Size = new System.Drawing.Size(164, 22);
            this.TaxBox.TabIndex = 21;
            this.TaxBox.Tag = "";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(763, 574);
            this.TotalBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(164, 22);
            this.TotalBox.TabIndex = 22;
            this.TotalBox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // CustomerList
            // 
            this.CustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(115, 29);
            this.CustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(892, 24);
            this.CustomerList.TabIndex = 24;
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Customer:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Customer_name
            // 
            this.Customer_name.HeaderText = "Customer Name";
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.ReadOnly = true;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Line Total";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "Book ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1067, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookStoreForm";
            this.Text = "Order your Favorite Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookStoreForm_FormClosing);
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
        private System.Windows.Forms.TextBox TaxBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_name;
    }
}

