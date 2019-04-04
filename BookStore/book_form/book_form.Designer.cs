﻿namespace BookStore.order_form
{
    partial class Book_Window_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Window_form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.New_Book_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Books_comboBox = new System.Windows.Forms.ComboBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Author_button = new System.Windows.Forms.Label();
            this.ISBN_button = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Title_box = new System.Windows.Forms.TextBox();
            this.Author_box = new System.Windows.Forms.TextBox();
            this.ISBN_box = new System.Windows.Forms.TextBox();
            this.Price_box = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.56186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.48969F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Back_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.New_Book_button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Save_button, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Books_comboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Title_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Author_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ISBN_button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Price_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Title_box, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Author_box, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ISBN_box, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Price_box, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Back_button
            // 
            this.Back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(628, 18);
            this.Back_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(136, 27);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back";
            this.Back_button.UseCompatibleTextRendering = true;
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // New_Book_button
            // 
            this.New_Book_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Book_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Book_button.Location = new System.Drawing.Point(628, 81);
            this.New_Book_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.New_Book_button.Name = "New_Book_button";
            this.New_Book_button.Size = new System.Drawing.Size(136, 27);
            this.New_Book_button.TabIndex = 1;
            this.New_Book_button.Text = "New Book";
            this.New_Book_button.UseCompatibleTextRendering = true;
            this.New_Book_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(628, 144);
            this.Save_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(136, 27);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Save";
            this.Save_button.UseCompatibleTextRendering = true;
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(628, 207);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(136, 27);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseCompatibleTextRendering = true;
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Books_comboBox
            // 
            this.Books_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Books_comboBox.FormattingEnabled = true;
            this.Books_comboBox.Location = new System.Drawing.Point(128, 18);
            this.Books_comboBox.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Books_comboBox.Name = "Books_comboBox";
            this.Books_comboBox.Size = new System.Drawing.Size(476, 24);
            this.Books_comboBox.TabIndex = 4;
            // 
            // Title_label
            // 
            this.Title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(12, 81);
            this.Title_label.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(92, 27);
            this.Title_label.TabIndex = 5;
            this.Title_label.Text = "Title:";
            this.Title_label.UseCompatibleTextRendering = true;
            // 
            // Author_button
            // 
            this.Author_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Author_button.AutoSize = true;
            this.Author_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_button.Location = new System.Drawing.Point(12, 144);
            this.Author_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Author_button.Name = "Author_button";
            this.Author_button.Size = new System.Drawing.Size(92, 27);
            this.Author_button.TabIndex = 6;
            this.Author_button.Text = "Author";
            this.Author_button.UseCompatibleTextRendering = true;
            // 
            // ISBN_button
            // 
            this.ISBN_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBN_button.AutoSize = true;
            this.ISBN_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_button.Location = new System.Drawing.Point(12, 207);
            this.ISBN_button.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.ISBN_button.Name = "ISBN_button";
            this.ISBN_button.Size = new System.Drawing.Size(92, 27);
            this.ISBN_button.TabIndex = 7;
            this.ISBN_button.Text = "ISBN:";
            this.ISBN_button.UseCompatibleTextRendering = true;
            // 
            // Price_label
            // 
            this.Price_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(12, 270);
            this.Price_label.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(92, 27);
            this.Price_label.TabIndex = 8;
            this.Price_label.Text = "Price:";
            this.Price_label.UseCompatibleTextRendering = true;
            // 
            // Title_box
            // 
            this.Title_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_box.Location = new System.Drawing.Point(128, 81);
            this.Title_box.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Title_box.Name = "Title_box";
            this.Title_box.Size = new System.Drawing.Size(476, 22);
            this.Title_box.TabIndex = 9;
            // 
            // Author_box
            // 
            this.Author_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Author_box.Location = new System.Drawing.Point(128, 144);
            this.Author_box.Margin = new System.Windows.Forms.Padding(12, 18, 200, 18);
            this.Author_box.Name = "Author_box";
            this.Author_box.Size = new System.Drawing.Size(288, 22);
            this.Author_box.TabIndex = 10;
            // 
            // ISBN_box
            // 
            this.ISBN_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBN_box.Location = new System.Drawing.Point(128, 207);
            this.ISBN_box.Margin = new System.Windows.Forms.Padding(12, 18, 200, 18);
            this.ISBN_box.Name = "ISBN_box";
            this.ISBN_box.Size = new System.Drawing.Size(288, 22);
            this.ISBN_box.TabIndex = 11;
            // 
            // Price_box
            // 
            this.Price_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price_box.Location = new System.Drawing.Point(128, 270);
            this.Price_box.Margin = new System.Windows.Forms.Padding(12, 18, 300, 18);
            this.Price_box.Name = "Price_box";
            this.Price_box.Size = new System.Drawing.Size(188, 22);
            this.Price_box.TabIndex = 12;
            // 
            // Book_Window_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Book_Window_form";
            this.Text = "Book Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Book_Window_form_FormClosing);
            this.Load += new System.EventHandler(this.Book_Window_form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button New_Book_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.ComboBox Books_comboBox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Author_button;
        private System.Windows.Forms.Label ISBN_button;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox Title_box;
        private System.Windows.Forms.TextBox Author_box;
        private System.Windows.Forms.TextBox ISBN_box;
        private System.Windows.Forms.TextBox Price_box;
        private System.Windows.Forms.Label label1;
    }
}