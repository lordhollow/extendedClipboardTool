using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extendedClipboardTools
{
    /// <summary>
    /// sort & enable & edit tools
    /// </summary>
    public partial class ConfigurationWindow : Form
    {
        public ConfigurationWindow()
        {
            InitializeComponent();

            showTools();
        }

        /// <summary>
        /// show all tools
        /// </summary>
        private void showTools()
        {
            lstTools.Items.AddRange(ClipboardExtender.Instance.Tools.Select(x => new toolAdapter(x)).ToArray());
        }

        private IClipboardTool SelectedTool
        {
            get { return (lstTools.SelectedItem as toolAdapter)?.Tool; }
        }

        /// <summary>
        /// item selected
        /// </summary>
        private void touch()
        {
            if ((lstTools.SelectedIndex >= 0) && (chkAdvancedMode.Checked))
            {
                SetupEditor(SelectedTool);
            }
            else
            {
                ClearEditor();
            }
        }

        /// <summary>
        /// ad. show touched tool detail;
        /// </summary>
        /// <param name="tool"></param>
        private void SetupEditor(IClipboardTool tool)
        {
            txtName.Text = tool.Define.Name;
            txtFace.Text = tool.Define.FaceName;
            txtDscr.Text = tool.Define.Description;
            txtGlobalScript.Text = tool.Define.GlobalScript;
            txtPrepareScript.Text = tool.Define.PrepareScript;
            txtCheckerScript.Text = tool.Define.CheckerScript;
            txtActionScript.Text = tool.Define.ActionScript;
            txtFinishActionScript.Text = tool.Define.FinishActionScript;
            chkContinuous.Checked = tool.Define.Continuous;
            pTestPanel.Controls.Clear();
            gbToolCreator.Enabled = true;
        }

        /// <summary>
        /// clear editor
        /// </summary>
        private void ClearEditor()
        {
            txtName.Text =
            txtFace.Text =
            txtDscr.Text =
            txtGlobalScript.Text =
            txtPrepareScript.Text =
            txtCheckerScript.Text =
            txtActionScript.Text =
            txtFinishActionScript.Text = "";
            chkContinuous.Checked = false;
            pTestPanel.Controls.Clear();
            gbToolCreator.Enabled = false;
        }

        private void selectedToolGoUp()
        {
            if (lstTools.SelectedIndex > 0)
            {
                var index = lstTools.SelectedIndex;
                var item = lstTools.SelectedItem;
                lstTools.Items.RemoveAt(index);
                lstTools.Items.Insert(index - 1, item);
                lstTools.SelectedIndex = index - 1;
            }
        }

        private void selectedToolGoDown()
        {
            if ((lstTools.SelectedIndex >= 0) && (lstTools.SelectedIndex != lstTools.Items.Count - 1))
            {
                var index = lstTools.SelectedIndex;
                var item = lstTools.SelectedItem;
                lstTools.Items.RemoveAt(index);
                lstTools.Items.Insert(index + 1, item);
                lstTools.SelectedIndex = index + 1;
            }
        }

        private void toggleSelectedToolEnable()
        {
            var item = lstTools.SelectedItem as toolAdapter;
            if (item != null)
            {
                switch(item.ToolState)
                {
                    case ToolState.Enable:
                        item.ToolState = ToolState.Disable;
                        break;
                    case ToolState.Disable:
                        item.ToolState = ToolState.Enable;
                        break;
                    case ToolState.Error:
                        //todo:: if (isValidTool(item))...
                        item.ToolState = ToolState.Enable;
                        break;
                }
                lstTools.Invalidate();
            }
        }

        private void lstTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            touch();
        }
        
        private void chkAdvancedMode_CheckedChanged(object sender, EventArgs e)
        {
            touch();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            selectedToolGoUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            selectedToolGoDown();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            toggleSelectedToolEnable();
        }

        private void lstTools_DrawItem(object sender, DrawItemEventArgs e)
        {
            //use ownerdraw  to apply property changing (result of ToString() method) of adapter

            e.DrawBackground();
            if ((e.Index >= 0) && (e.Index < lstTools.Items.Count))
            {
                var item = lstTools.Items[e.Index];
                e.Graphics.DrawString(item.ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
            e.DrawFocusRectangle();

        }

        /// <summary>
        /// List box adapter for clipboard tool list
        /// </summary>
        class toolAdapter
        {
            public toolAdapter(IClipboardTool tool)
            {
                Tool = tool;
                if (tool is UnloadedClipboardTool)
                {
                    ToolState = (tool as UnloadedClipboardTool).Error ? ToolState.Error : ToolState = ToolState.Disable;
                }
                else
                {
                    ToolState = tool.Enable ? ToolState.Enable : ToolState.Disable;
                }
            }

            /// <summary>
            /// Target Tool
            /// </summary>
            public IClipboardTool Tool { get; private set; }

            /// <summary>
            /// state of tool
            /// </summary>
            public ToolState ToolState { get; set; }

            public override string ToString()
            {
                string suf = "";
                switch (ToolState)
                {
                    case ToolState.Disable:
                        suf = " [disabled]";
                        break;
                    case ToolState.Error:
                        suf = " [error]";
                        break;
                    default:
                        break;
                }
                return Tool.Define.Name + suf;
            }
        }

        /// <summary>
        /// when close this form, apply tool order & state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var order = new ClipboardToolOrder();
            order.AddRange(lstTools.Items.Cast<toolAdapter>().Select(item =>
                new ClipboardToolOrderEntry
                {
                    State = item.ToolState,
                    ToolName = item.Tool.Define.Name,
                    SHA1 = null,
                }));
            ClipboardExtender.Instance.Order(order);
        }
    }

}
