namespace CashandCarry.FormReports
{
    partial class FrmsalReturn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRinvoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCusID = new System.Windows.Forms.Button();
            this.txtCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaxdate = new System.Windows.Forms.DateTimePicker();
            this.txtMinDate = new System.Windows.Forms.DateTimePicker();
            this.crptViewerReturn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtRinvoiceNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCusID);
            this.groupBox1.Controls.Add(this.txtCus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmaxdate);
            this.groupBox1.Controls.Add(this.txtMinDate);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(23, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(909, 139);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Invoice";
            // 
            // txtRinvoiceNo
            // 
            this.txtRinvoiceNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRinvoiceNo.Location = new System.Drawing.Point(496, 92);
            this.txtRinvoiceNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRinvoiceNo.Name = "txtRinvoiceNo";
            this.txtRinvoiceNo.Size = new System.Drawing.Size(171, 23);
            this.txtRinvoiceNo.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(377, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Return Invoice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(37, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Date:";
            // 
            // btnCusID
            // 
            this.btnCusID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCusID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusID.FlatAppearance.BorderSize = 0;
            this.btnCusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusID.ForeColor = System.Drawing.Color.White;
            this.btnCusID.Location = new System.Drawing.Point(768, 92);
            this.btnCusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCusID.Name = "btnCusID";
            this.btnCusID.Size = new System.Drawing.Size(107, 23);
            this.btnCusID.TabIndex = 67;
            this.btnCusID.Text = "Search";
            this.btnCusID.UseVisualStyleBackColor = false;
            this.btnCusID.Click += new System.EventHandler(this.btnCusID_Click);
            // 
            // txtCus
            // 
            this.txtCus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCus.Location = new System.Drawing.Point(187, 92);
            this.txtCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(171, 23);
            this.txtCus.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Customer ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(768, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(455, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "From:";
            // 
            // txtmaxdate
            // 
            this.txtmaxdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaxdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtmaxdate.Location = new System.Drawing.Point(496, 38);
            this.txtmaxdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaxdate.Name = "txtmaxdate";
            this.txtmaxdate.Size = new System.Drawing.Size(171, 23);
            this.txtmaxdate.TabIndex = 61;
            this.txtmaxdate.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // txtMinDate
            // 
            this.txtMinDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtMinDate.Location = new System.Drawing.Point(187, 38);
            this.txtMinDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinDate.Name = "txtMinDate";
            this.txtMinDate.Size = new System.Drawing.Size(171, 23);
            this.txtMinDate.TabIndex = 60;
            this.txtMinDate.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            // 
            // crptViewerReturn
            // 
            this.crptViewerReturn.ActiveViewIndex = -1;
            this.crptViewerReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crptViewerReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewerReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewerReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crptViewerReturn.Location = new System.Drawing.Point(20, 229);
            this.crptViewerReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crptViewerReturn.Name = "crptViewerReturn";
            this.crptViewerReturn.Size = new System.Drawing.Size(1292, 381);
            this.crptViewerReturn.TabIndex = 82;
            this.crptViewerReturn.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crptViewerReturn.Load += new System.EventHandler(this.crptViewerSale_Load);
            // 
            // FrmsalReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1332, 630);
            this.Controls.Add(this.crptViewerReturn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmsalReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale Return Report";
            this.Load += new System.EventHandler(this.FrmSaleReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRinvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCusID;
        private System.Windows.Forms.TextBox txtCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtmaxdate;
        private System.Windows.Forms.DateTimePicker txtMinDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewerReturn;
    }
}