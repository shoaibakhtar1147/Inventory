namespace CashandCarry.FormReports
{
    partial class FrmCustomerReport
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
            this.crptViewerCus = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnCusName = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllRecord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crptViewerCus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(23, 184);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 381);
            this.panel1.TabIndex = 78;
            // 
            // crptViewerCus
            // 
            this.crptViewerCus.ActiveViewIndex = -1;
            this.crptViewerCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewerCus.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewerCus.Location = new System.Drawing.Point(0, 0);
            this.crptViewerCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crptViewerCus.Name = "crptViewerCus";
            this.crptViewerCus.Size = new System.Drawing.Size(1039, 381);
            this.crptViewerCus.TabIndex = 1;
            this.crptViewerCus.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnCusName
            // 
            this.btnCusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCusName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusName.FlatAppearance.BorderSize = 0;
            this.btnCusName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusName.ForeColor = System.Drawing.Color.White;
            this.btnCusName.Location = new System.Drawing.Point(790, 117);
            this.btnCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCusName.Name = "btnCusName";
            this.btnCusName.Size = new System.Drawing.Size(107, 23);
            this.btnCusName.TabIndex = 82;
            this.btnCusName.Text = "Search";
            this.btnCusName.UseVisualStyleBackColor = false;
            this.btnCusName.Click += new System.EventHandler(this.btnCusName_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(600, 117);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 23);
            this.txtSearch.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(451, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Customer ID:";
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAllRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRecord.FlatAppearance.BorderSize = 0;
            this.btnAllRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRecord.ForeColor = System.Drawing.Color.White;
            this.btnAllRecord.Location = new System.Drawing.Point(955, 117);
            this.btnAllRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(107, 23);
            this.btnAllRecord.TabIndex = 84;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseVisualStyleBackColor = false;
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            // 
            // FrmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.btnAllRecord);
            this.Controls.Add(this.btnCusName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomerReport";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.FrmCustomerReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCusName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllRecord;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewerCus;
    }
}