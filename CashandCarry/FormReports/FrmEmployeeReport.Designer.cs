namespace CashandCarry.FormReports
{
    partial class FrmEmployeeReport
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
            this.crptViewerEmp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsalaryID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCusName = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crptViewerEmp
            // 
            this.crptViewerEmp.ActiveViewIndex = -1;
            this.crptViewerEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewerEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewerEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crptViewerEmp.Location = new System.Drawing.Point(20, 189);
            this.crptViewerEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crptViewerEmp.Name = "crptViewerEmp";
            this.crptViewerEmp.Size = new System.Drawing.Size(1045, 381);
            this.crptViewerEmp.TabIndex = 2;
            this.crptViewerEmp.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtsalaryID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCusName);
            this.groupBox1.Controls.Add(this.txtEmpID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(23, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(909, 94);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Report";
            // 
            // txtsalaryID
            // 
            this.txtsalaryID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalaryID.Location = new System.Drawing.Point(496, 40);
            this.txtsalaryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsalaryID.Name = "txtsalaryID";
            this.txtsalaryID.Size = new System.Drawing.Size(171, 23);
            this.txtsalaryID.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(394, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Salary ID:";
            // 
            // btnCusName
            // 
            this.btnCusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCusName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusName.FlatAppearance.BorderSize = 0;
            this.btnCusName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusName.ForeColor = System.Drawing.Color.White;
            this.btnCusName.Location = new System.Drawing.Point(768, 40);
            this.btnCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCusName.Name = "btnCusName";
            this.btnCusName.Size = new System.Drawing.Size(107, 23);
            this.btnCusName.TabIndex = 67;
            this.btnCusName.Text = "Search";
            this.btnCusName.UseVisualStyleBackColor = false;
            this.btnCusName.Click += new System.EventHandler(this.btnCusName_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(187, 40);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(171, 23);
            this.txtEmpID.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(37, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Employee ID:";
            // 
            // FrmEmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1085, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crptViewerEmp);
            this.Name = "FrmEmployeeReport";
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.FrmEmployeeReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewerEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsalaryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCusName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
    }
}