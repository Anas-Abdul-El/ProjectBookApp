namespace ProjectBookApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_books_panel = new System.Windows.Forms.Button();
            this.btn_update_panel = new System.Windows.Forms.Button();
            this.btn_del_panel = new System.Windows.Forms.Button();
            this.reports_btn_panel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.reports_btn_panel);
            this.panel1.Controls.Add(this.btn_del_panel);
            this.panel1.Controls.Add(this.btn_update_panel);
            this.panel1.Controls.Add(this.btn_add_books_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 626);
            this.panel1.TabIndex = 0;
            // 
            // btn_add_books_panel
            // 
            this.btn_add_books_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_books_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add_books_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add_books_panel.FlatAppearance.BorderSize = 0;
            this.btn_add_books_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_books_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_books_panel.Location = new System.Drawing.Point(0, 60);
            this.btn_add_books_panel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_books_panel.Name = "btn_add_books_panel";
            this.btn_add_books_panel.Size = new System.Drawing.Size(145, 57);
            this.btn_add_books_panel.TabIndex = 2;
            this.btn_add_books_panel.Text = "Add Books";
            this.btn_add_books_panel.UseVisualStyleBackColor = false;
            this.btn_add_books_panel.Click += new System.EventHandler(this.btn_add_books_panel_Click);
            // 
            // btn_update_panel
            // 
            this.btn_update_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_update_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update_panel.FlatAppearance.BorderSize = 0;
            this.btn_update_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update_panel.Location = new System.Drawing.Point(0, 117);
            this.btn_update_panel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_update_panel.Name = "btn_update_panel";
            this.btn_update_panel.Size = new System.Drawing.Size(145, 59);
            this.btn_update_panel.TabIndex = 3;
            this.btn_update_panel.Text = "Update Books";
            this.btn_update_panel.UseVisualStyleBackColor = false;
            this.btn_update_panel.Click += new System.EventHandler(this.btn_update_panel_Click);
            // 
            // btn_del_panel
            // 
            this.btn_del_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_del_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_del_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_del_panel.FlatAppearance.BorderSize = 0;
            this.btn_del_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_del_panel.Location = new System.Drawing.Point(0, 176);
            this.btn_del_panel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_del_panel.Name = "btn_del_panel";
            this.btn_del_panel.Size = new System.Drawing.Size(145, 59);
            this.btn_del_panel.TabIndex = 4;
            this.btn_del_panel.Text = "Delete Book";
            this.btn_del_panel.UseVisualStyleBackColor = false;
            this.btn_del_panel.Click += new System.EventHandler(this.btn_del_panel_Click);
            // 
            // reports_btn_panel
            // 
            this.reports_btn_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reports_btn_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reports_btn_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reports_btn_panel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reports_btn_panel.FlatAppearance.BorderSize = 0;
            this.reports_btn_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports_btn_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reports_btn_panel.Location = new System.Drawing.Point(0, 235);
            this.reports_btn_panel.Margin = new System.Windows.Forms.Padding(0);
            this.reports_btn_panel.Name = "reports_btn_panel";
            this.reports_btn_panel.Size = new System.Drawing.Size(145, 59);
            this.reports_btn_panel.TabIndex = 5;
            this.reports_btn_panel.Text = "Reports";
            this.reports_btn_panel.UseVisualStyleBackColor = false;
            this.reports_btn_panel.Click += new System.EventHandler(this.reports_btn_panel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(145, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1021, 626);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1166, 626);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_books_panel;
        private System.Windows.Forms.Button btn_del_panel;
        private System.Windows.Forms.Button btn_update_panel;
        private System.Windows.Forms.Button reports_btn_panel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
    }
}

