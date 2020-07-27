namespace CashandCarry.FormReports
{
    partial class FrmExpenseReport
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaxdate = new System.Windows.Forms.DateTimePicker();
            this.txtMinDate = new System.Windows.Forms.DateTimePicker();
            this.crptViewerExpense = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(109, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(840, 112);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(516, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(193, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "From:";
            // 
            // txtmaxdate
            // 
            this.txtmaxdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaxdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtmaxdate.Location = new System.Drawing.Point(568, 112);
            this.txtmaxdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaxdate.Name = "txtmaxdate";
            this.txtmaxdate.Size = new System.Drawing.Size(171, 23);
            this.txtmaxdate.TabIndex = 84;
            this.txtmaxdate.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // txtMinDate
            // 
            this.txtMinDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtMinDate.Location = new System.Drawing.Point(259, 112);
            this.txtMinDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinDate.Name = "txtMinDate";
            this.txtMinDate.Size = new System.Drawing.Size(171, 23);
            this.txtMinDate.TabIndex = 83;
            this.txtMinDate.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // crptViewerExpense
            // 
            this.crptViewerExpense.ActiveViewIndex = -1;
            this.crptViewerExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewerExpense.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewerExpense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crptViewerExpense.Location = new System.Drawing.Point(20, 189);
            this.crptViewerExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crptViewerExpense.Name = "crptViewerExpense";
            this.crptViewerExpense.Size = new System.Drawing.Size(1045, 381);
            this.crptViewerExpense.TabIndex = 94;
            this.crptViewerExpense.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.crptViewerExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaxdate);
            this.Controls.Add(this.txtMinDate);
            this.Name = "FrmExpenseReport";
            this.Text = "Expense Report";
            this.Load += new System.EventHandler(this.FrmExpenseReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtmaxdate;
        private System.Windows.Forms.DateTimePicker txtMinDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewerExpense;
    }
}