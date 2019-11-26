namespace CashandCarry.FrmMessageBox
{
    partial class PurchaseMesageBox
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
            this.btnPurReturn = new System.Windows.Forms.Button();
            this.btnPurInvoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRamaining = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnRamaining);
            this.panel1.Controls.Add(this.btnPurReturn);
            this.panel1.Controls.Add(this.btnPurInvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 77);
            this.panel1.TabIndex = 34;
            // 
            // btnPurReturn
            // 
            this.btnPurReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPurReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurReturn.FlatAppearance.BorderSize = 0;
            this.btnPurReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurReturn.ForeColor = System.Drawing.Color.White;
            this.btnPurReturn.Location = new System.Drawing.Point(194, 24);
            this.btnPurReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPurReturn.Name = "btnPurReturn";
            this.btnPurReturn.Size = new System.Drawing.Size(132, 28);
            this.btnPurReturn.TabIndex = 32;
            this.btnPurReturn.Text = "Purchase Return";
            this.btnPurReturn.UseVisualStyleBackColor = false;
            this.btnPurReturn.Click += new System.EventHandler(this.btnPurReturn_Click);
            // 
            // btnPurInvoice
            // 
            this.btnPurInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPurInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurInvoice.FlatAppearance.BorderSize = 0;
            this.btnPurInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurInvoice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPurInvoice.Location = new System.Drawing.Point(51, 24);
            this.btnPurInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPurInvoice.Name = "btnPurInvoice";
            this.btnPurInvoice.Size = new System.Drawing.Size(132, 28);
            this.btnPurInvoice.TabIndex = 31;
            this.btnPurInvoice.Text = "Purchase Invoice";
            this.btnPurInvoice.UseVisualStyleBackColor = false;
            this.btnPurInvoice.Click += new System.EventHandler(this.btnPurInvoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(70, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "Please Press a button\r\n ";
            // 
            // btnRamaining
            // 
            this.btnRamaining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRamaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRamaining.FlatAppearance.BorderSize = 0;
            this.btnRamaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRamaining.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRamaining.ForeColor = System.Drawing.Color.White;
            this.btnRamaining.Location = new System.Drawing.Point(337, 24);
            this.btnRamaining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRamaining.Name = "btnRamaining";
            this.btnRamaining.Size = new System.Drawing.Size(111, 28);
            this.btnRamaining.TabIndex = 35;
            this.btnRamaining.Text = "Remaining";
            this.btnRamaining.UseVisualStyleBackColor = false;
            this.btnRamaining.Click += new System.EventHandler(this.btnRamaining_Click);
            // 
            // PurchaseMesageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 158);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseMesageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.PurchaseMesageBox_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPurReturn;
        private System.Windows.Forms.Button btnPurInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRamaining;
    }
}