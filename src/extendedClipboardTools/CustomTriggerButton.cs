using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace extendedClipboardTools
{
    /// <summary>
    /// Clipboard Tool Trigger Panel
    /// </summary>
    public partial class CustomTriggerButton : UserControl
    {
        /// <summary>
        /// regex for create options from name
        /// </summary>
        static Regex regexOpts = new Regex(@"\$");

        public CustomTriggerButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// attached clipboard tool
        /// </summary>
        public IClipboardTool Tool { get; private set; }

        /// <summary>
        /// attach clipboard tool to this
        /// </summary>
        /// <param name="tool"></param>
        public void Attach(IClipboardTool tool)
        {
            Tool = null;    //for skip checked_changed event
            Control visible = null;
            if (tool.Continuous)
            {
                visible = chkContAct;
                btnAct.Visible = false;
                chkContAct.Checked = false;
            }
            else
            {
                visible = btnAct;
                chkContAct.Visible = false;
            }
            visible.Visible = true;

            //check option
            if (regexOpts.IsMatch(tool.Name))
            {
                var opts = regexOpts.Split(tool.Name);
                visible.Text = opts[0];
                cmbOption.Items.AddRange(opts.Skip(1).ToArray());
                cmbOption.SelectedIndex = 0;

                cmbOption.Visible = true;
                visible.Width = this.ClientSize.Width - cmbOption.Width - 4;
            }
            else
            {
                visible.Text = tool.Name;
                cmbOption.Visible = false;
                visible.Width = this.ClientSize.Width;
            }

            Tool = tool;
        }

        /// <summary>
        /// option string for tool
        /// </summary>
        public string Option { get { return cmbOption.Text; } }

        /// <summary>
        /// is continuous tool active?
        /// </summary>
        public bool Active { get { return chkContAct.Checked; } }

        /// <summary>
        /// notify clipboard draw
        /// </summary>
        public void NotifyCliboardDraw()
        {
            //continuous tool: always visible. if checker returns true, execute action
            if (Tool.Continuous)
            {
                if (Active && Tool.Checker(Option))
                {
                    Tool.Action(Option);
                }
            }
            //non-continuous tool: checker result changes visibility
            else
            {
                Visible = Tool.Checker(Option);
            }
        }

        /// <summary>
        /// action for non-continuous tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAct_Click(object sender, EventArgs e)
        {
            Tool.Action(Option);
        }

        /// <summary>
        /// action for continuous tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkContAct_CheckedChanged(object sender, EventArgs e)
        {
            if ((Tool != null) && (!Active))
            {
                //Active to NonActive with tool: execute finish action
                Console.WriteLine($"Call Finish Action of { chkContAct.Text} with {Option}");
                Tool.FinishAction(Option);
            }
        }

    }
}
