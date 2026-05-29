namespace ProjectBookApp
{
    partial class UpdateBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.choose_book = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_isBorrowed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(571, 335);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(167, 33);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(408, 335);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(157, 31);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(495, 240);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(243, 20);
            this.txt_quantity.TabIndex = 14;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(495, 178);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(243, 20);
            this.txt_isbn.TabIndex = 13;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(495, 109);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(243, 20);
            this.txt_author.TabIndex = 12;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(495, 52);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(243, 20);
            this.txt_title.TabIndex = 11;
            // 
            // choose_book
            // 
            this.choose_book.FormattingEnabled = true;
            this.choose_book.Location = new System.Drawing.Point(38, 78);
            this.choose_book.Name = "choose_book";
            this.choose_book.Size = new System.Drawing.Size(323, 290);
            this.choose_book.TabIndex = 21;
            this.choose_book.SelectedIndexChanged += new System.EventHandler(this.choose_book_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Choose a book to edit ";
            // 
            // txt_isBorrowed
            // 
            this.txt_isBorrowed.AutoSize = true;
            this.txt_isBorrowed.Location = new System.Drawing.Point(415, 296);
            this.txt_isBorrowed.Name = "txt_isBorrowed";
            this.txt_isBorrowed.Size = new System.Drawing.Size(78, 17);
            this.txt_isBorrowed.TabIndex = 23;
            this.txt_isBorrowed.Text = "isBorrowed";
            this.txt_isBorrowed.UseVisualStyleBackColor = true;
            // 
            // UpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_isBorrowed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.choose_book);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_title);
            this.Name = "UpdateBooks";
            this.Size = new System.Drawing.Size(817, 439);
            this.Load += new System.EventHandler(this.UpdateBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.ListBox choose_book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox txt_isBorrowed;
    }
}
