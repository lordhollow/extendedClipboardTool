using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace extendedClipboardTools
{
    public partial class ControlBoard : Form
    {
        #region extern
        [DllImport("user32")]
        static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("user32")]
        static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32")]
        extern static IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        const int WM_DRAWCLIPBOARD = 0x0308;
        const int WM_CHANGECBCHAIN = 0x030D;

        #endregion


        //next window of clipboard chain
        IntPtr nextHandle = IntPtr.Zero;

        public ControlBoard()
        {
            InitializeComponent();

            //[un]registor clipboard viewer
            Shown += (s, a) => StartListening();
            FormClosing += (s, a) => EndListening();

            ReconstructTools();

        }

        public void ReconstructTools()
        {
            pMain.Controls.Clear();

            foreach (var tool in ClipboardExtender.Instance.Tools.Reverse())
            {
                var ctrl = new CustomTriggerButton();
                ctrl.Attach(tool);
                ctrl.Dock = DockStyle.Top;
                pMain.Controls.Add(ctrl);
            }
        }

        public EventHandler DrawClipboard;

        private void onDrawClipboard()
        {
            updateSummary();
            notifyClipboardDraw();

            DrawClipboard?.Invoke(this, EventArgs.Empty);
        }

        private void updateSummary()
        {
            string msg = "";
            if (Clipboard.ContainsText())
            {
                msg = $"Text, {Clipboard.GetText().Length }";  
            }
            else if (Clipboard.ContainsImage())
            {
                msg = "Image";
            }
            else if (Clipboard.ContainsFileDropList())
            {
                msg = "FileList";
            }
            else if (Clipboard.ContainsAudio())
            {
                msg = "Audio";
            }
            else
            {
                msg = "Unknown";
            }
            lblMsg.Text = msg;
        }

        private void notifyClipboardDraw()
        {
            foreach(CustomTriggerButton btn in pMain.Controls)
            {
                btn.NotifyCliboardDraw();
            }
        }

        void StartListening()
        {
            nextHandle = SetClipboardViewer(this.Handle);
        }

        void EndListening()
        {
            ChangeClipboardChain(this.Handle, nextHandle);
        }

        protected override void WndProc(ref Message m)
        {
            switch( m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    onDrawClipboard();
                    if (nextHandle != IntPtr.Zero)
                    {
                        SendMessage(nextHandle, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextHandle)
                    {
                        nextHandle = m.LParam;
                    }
                    else if (nextHandle != IntPtr.Zero)
                    {
                        SendMessage(nextHandle, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var editor = new ConfigurationWindow();
            editor.ShowDialog();
        }
    }
}
