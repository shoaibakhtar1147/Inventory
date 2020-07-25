namespace CashandCarry.Sales
{
    partial class SaleRecoveryDgv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSaleRecovery = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSaleRecovery);
            this.panel1.Location = new System.Drawing.Point(23, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 340);
            this.panel1.TabIndex = 52;
            // 
            // dgvSaleRecovery
            // 
            this.dgvSaleRecovery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleRecovery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleRecovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleRecovery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleRecovery.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSaleRecovery.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleRecovery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSaleRecovery.Name = "dgvSaleRecovery";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvSaleRecovery.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleRecovery.Size = new System.Drawing.Size(891, 340);
            this.dgvSaleRecovery.TabIndex = 4;
            // 
            // SaleRecoveryDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 615);
            this.Controls.Add(this.panel1);
            this.Name = "SaleRecoveryDgv";
            this.Text = "SaleRecoveryDgv";
            this.Load += new System.EventHandler(this.SaleRecoveryDgv_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleRecovery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSaleRecovery;
    }
}