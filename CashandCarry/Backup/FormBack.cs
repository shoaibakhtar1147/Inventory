using MetroFramework.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Smo.BackupRestoreBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashandCarry.Backup
{
    public partial class FormBack : MetroForm
    {
        public FormBack()
        {
            InitializeComponent();
        }

        private void FormBack_Load(object sender, EventArgs e)
        {
            

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server DbServer = new Server(new ServerConnection(txtServer.Text));
                Microsoft.SqlServer.Management.Smo.Backup dbBackup = new Microsoft.SqlServer.Management.Smo.Backup() { Action = BackupActionType.Database, Database = txtDatabase.Text };
                dbBackup.Devices.AddDevice(@txtPath.Text+"RoshanTraders"+DateTime.Now.ToShortDateString()+".bak", DeviceType.File);
                dbBackup.Initialize = true; dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(DbServer);
                MessageBox.Show("Backup Completed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            //lblPercent.Invoke((MethodInvoker)delegate
            //{
            //lblPercent.Text= $"{e.Percent}%";
            //});
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.RootFolder = Environment.SpecialFolder.Desktop;
            fdb.Description = "Select Folder";
            fdb.ShowNewFolderButton = false;
            if(fdb.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = fdb.SelectedPath + "\\";
            }
        }
    }
}
