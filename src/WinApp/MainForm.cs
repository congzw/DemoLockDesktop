using System;
using System.Windows.Forms;
using WinApp.WinHooks;

namespace WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            WinLockHelper.SetEnable(false);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            WinLockHelper.SetEnable(true);
        }
    }
}
