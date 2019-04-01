namespace BookStore
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Manage_Customers_button = new System.Windows.Forms.Button();
            this.Manage_Books_button = new System.Windows.Forms.Button();
            this.Place_Order_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.Manage_Customers_button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Manage_Books_button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Place_Order_button, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Manage_Customers_button
            // 
            this.Manage_Customers_button.Location = new System.Drawing.Point(115, 114);
            this.Manage_Customers_button.Name = "Manage_Customers_button";
            this.Manage_Customers_button.Size = new System.Drawing.Size(138, 31);
            this.Manage_Customers_button.TabIndex = 0;
            this.Manage_Customers_button.Text = "Manage Customers";
            this.Manage_Customers_button.UseVisualStyleBackColor = true;
            this.Manage_Customers_button.Click += new System.EventHandler(this.Manage_Customers_button_Click);
            // 
            // Manage_Books_button
            // 
            this.Manage_Books_button.Location = new System.Drawing.Point(115, 151);
            this.Manage_Books_button.Name = "Manage_Books_button";
            this.Manage_Books_button.Size = new System.Drawing.Size(138, 31);
            this.Manage_Books_button.TabIndex = 1;
            this.Manage_Books_button.Text = "Manage Books";
            this.Manage_Books_button.UseVisualStyleBackColor = true;
            this.Manage_Books_button.Click += new System.EventHandler(this.Manage_Books_button_Click);
            // 
            // Place_Order_button
            // 
            this.Place_Order_button.Location = new System.Drawing.Point(115, 188);
            this.Place_Order_button.Name = "Place_Order_button";
            this.Place_Order_button.Size = new System.Drawing.Size(138, 31);
            this.Place_Order_button.TabIndex = 2;
            this.Place_Order_button.Text = "Place Order";
            this.Place_Order_button.UseVisualStyleBackColor = true;
            this.Place_Order_button.Click += new System.EventHandler(this.Place_Order_button_Click);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Form";
            this.Text = "Book Store with Database";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Manage_Customers_button;
        private System.Windows.Forms.Button Manage_Books_button;
        private System.Windows.Forms.Button Place_Order_button;
    }
}

