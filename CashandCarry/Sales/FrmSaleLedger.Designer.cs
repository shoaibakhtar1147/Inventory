namespace CashandCarry.Sales
{
    partial class FrmSaleLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLedger = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.ComboBox();
            this.btnRouteSearch = new System.Windows.Forms.Button();
            this.txtRoute = new System.Windows.Forms.ComboBox();
            this.btnPrintRoute = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(587, 77);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(126, 24);
            this.btnPrint.TabIndex = 71;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(393, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 24);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Customer Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLedger);
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 319);
            this.panel1.TabIndex = 67;
            // 
            // dgvLedger
            // 
            this.dgvLedger.AllowUserToAddRows = false;
            this.dgvLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLedger.Location = new System.Drawing.Point(0, 0);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.Size = new System.Drawing.Size(1053, 319);
            this.dgvLedger.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(15, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 76;
            this.label13.Text = "Route Name:";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCusName.FormattingEnabled = true;
            this.txtCusName.Location = new System.Drawing.Point(129, 77);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(242, 25);
            this.txtCusName.TabIndex = 77;
            // 
            // btnRouteSearch
            // 
            this.btnRouteSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRouteSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRouteSearch.FlatAppearance.BorderSize = 0;
            this.btnRouteSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRouteSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRouteSearch.ForeColor = System.Drawing.Color.White;
            this.btnRouteSearch.Location = new System.Drawing.Point(393, 121);
            this.btnRouteSearch.Name = "btnRouteSearch";
            this.btnRouteSearch.Size = new System.Drawing.Size(126, 24);
            this.btnRouteSearch.TabIndex = 78;
            this.btnRouteSearch.Text = "Search";
            this.btnRouteSearch.UseVisualStyleBackColor = false;
            this.btnRouteSearch.Click += new System.EventHandler(this.btnRouteSearch_Click);
            // 
            // txtRoute
            // 
            this.txtRoute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRoute.FormattingEnabled = true;
            this.txtRoute.Location = new System.Drawing.Point(129, 118);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(242, 25);
            this.txtRoute.TabIndex = 79;
            // 
            // btnPrintRoute
            // 
            this.btnPrintRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPrintRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintRoute.FlatAppearance.BorderSize = 0;
            this.btnPrintRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRoute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrintRoute.ForeColor = System.Drawing.Color.White;
            this.btnPrintRoute.Location = new System.Drawing.Point(587, 121);
            this.btnPrintRoute.Name = "btnPrintRoute";
            this.btnPrintRoute.Size = new System.Drawing.Size(126, 24);
            this.btnPrintRoute.TabIndex = 80;
            this.btnPrintRoute.Text = "Print";
            this.btnPrintRoute.UseVisualStyleBackColor = false;
            this.btnPrintRoute.Click += new System.EventHandler(this.btnPrintRoute_Click);
            // 
            // FrmSaleLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1057, 500);
            this.Controls.Add(this.btnPrintRoute);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.btnRouteSearch);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSaleLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale Ledger";
            this.Load += new System.EventHandler(this.FrmSaleLedger_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLedger;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtCusName;
        private System.Windows.Forms.Button btnRouteSearch;
        private System.Windows.Forms.ComboBox txtRoute;
        private System.Windows.Forms.Button btnPrintRoute;
    }
}