namespace ProjectBookApp
{
    partial class DeleteBooks
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
            this.Delete_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_list
            // 
            this.Delete_list.FormattingEnabled = true;
            this.Delete_list.Location = new System.Drawing.Point(34, 46);
            this.Delete_list.Name = "Delete_list";
            this.Delete_list.Size = new System.Drawing.Size(258, 225);
            this.Delete_list.TabIndex = 0;
            this.Delete_list.SelectedIndexChanged += new System.EventHandler(this.Delete_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose The Book You Want to Delete";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_list);
            this.Name = "DeleteBooks";
            this.Size = new System.Drawing.Size(350, 353);
            this.Load += new System.EventHandler(this.DeleteBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Delete_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
