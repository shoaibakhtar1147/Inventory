namespace CashandCarry.FormReports
{
    partial class FrmComReport
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
            this.btnAllRecord = new System.Windows.Forms.Button();
            this.btnComName = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crptViewerCom = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAllRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRecord.FlatAppearance.BorderSize = 0;
            this.btnAllRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRecord.ForeColor = System.Drawing.Color.White;
            this.btnAllRecord.Location = new System.Drawing.Point(954, 117);
            this.btnAllRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(107, 23);
            this.btnAllRecord.TabIndex = 88;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseVisualStyleBackColor = false;
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            // 
            // btnComName
            // 
            this.btnComName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnComName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComName.FlatAppearance.BorderSize = 0;
            this.btnComName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComName.ForeColor = System.Drawing.Color.White;
            this.btnComName.Location = new System.Drawing.Point(786, 117);
            this.btnComName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComName.Name = "btnComName";
            this.btnComName.Size = new System.Drawing.Size(107, 23);
            this.btnComName.TabIndex = 87;
            this.btnComName.Text = "Search";
            this.btnComName.UseVisualStyleBackColor = false;
            this.btnComName.Click += new System.EventHandler(this.btnComName_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Location = new System.Drawing.Point(596, 117);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 23);
            this.txtSearch.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(447, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Company ID:";
            // 
            // crptViewerCom
            // 
            this.crptViewerCom.ActiveViewIndex = -1;
            this.crptViewerCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewerCom.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewerCom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crptViewerCom.Location = new System.Drawing.Point(23, 184);
            this.crptViewerCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crptViewerCom.Name = "crptViewerCom";
            this.crptViewerCom.Size = new System.Drawing.Size(1039, 381);
            this.crptViewerCom.TabIndex = 89;
            this.crptViewerCom.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmComReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.crptViewerCom);
            this.Controls.Add(this.btnAllRecord);
            this.Controls.Add(this.btnComName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmComReport";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Company Report";
            this.Load += new System.EventHandler(this.FrmComReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllRecord;
        private System.Windows.Forms.Button btnComName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewerCom;
    }
}