namespace extendedClipboardTools
{
    partial class ConfigurationWindow
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
            this.pLeft = new System.Windows.Forms.Panel();
            this.chkAdvancedMode = new System.Windows.Forms.CheckBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lstTools = new System.Windows.Forms.ListBox();
            this.gbToolCreator = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pTestPanel = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.chkContinuous = new System.Windows.Forms.CheckBox();
            this.tbScripts = new System.Windows.Forms.TabControl();
            this.tpGlobal = new System.Windows.Forms.TabPage();
            this.btnResetGlobalScript = new System.Windows.Forms.Button();
            this.txtGlobalScript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpPrepare = new System.Windows.Forms.TabPage();
            this.btnResetPrepareScript = new System.Windows.Forms.Button();
            this.txtPrepareScript = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpChecker = new System.Windows.Forms.TabPage();
            this.btnResetCheckerScript = new System.Windows.Forms.Button();
            this.txtCheckerScript = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpAction = new System.Windows.Forms.TabPage();
            this.btnResetActionScript = new System.Windows.Forms.Button();
            this.txtActionScript = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpFinish = new System.Windows.Forms.TabPage();
            this.btnResetFinishActionScript = new System.Windows.Forms.Button();
            this.txtFinishActionScript = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDscr = new System.Windows.Forms.TextBox();
            this.txtFace = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pLeft.SuspendLayout();
            this.gbToolCreator.SuspendLayout();
            this.tbScripts.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            this.tpPrepare.SuspendLayout();
            this.tpChecker.SuspendLayout();
            this.tpAction.SuspendLayout();
            this.tpFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.chkAdvancedMode);
            this.pLeft.Controls.Add(this.btnOnOff);
            this.pLeft.Controls.Add(this.btnDown);
            this.pLeft.Controls.Add(this.btnUp);
            this.pLeft.Controls.Add(this.lstTools);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(203, 432);
            this.pLeft.TabIndex = 0;
            // 
            // chkAdvancedMode
            // 
            this.chkAdvancedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAdvancedMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAdvancedMode.AutoSize = true;
            this.chkAdvancedMode.Location = new System.Drawing.Point(171, 404);
            this.chkAdvancedMode.Name = "chkAdvancedMode";
            this.chkAdvancedMode.Size = new System.Drawing.Size(29, 22);
            this.chkAdvancedMode.TabIndex = 4;
            this.chkAdvancedMode.Text = "ad.";
            this.chkAdvancedMode.UseVisualStyleBackColor = true;
            this.chkAdvancedMode.CheckedChanged += new System.EventHandler(this.chkAdvancedMode_CheckedChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOnOff.Location = new System.Drawing.Point(71, 404);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(48, 23);
            this.btnOnOff.TabIndex = 3;
            this.btnOnOff.Text = "on/off";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.Location = new System.Drawing.Point(37, 404);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(28, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(3, 404);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(28, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lstTools
            // 
            this.lstTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTools.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTools.FormattingEnabled = true;
            this.lstTools.IntegralHeight = false;
            this.lstTools.ItemHeight = 12;
            this.lstTools.Location = new System.Drawing.Point(3, 3);
            this.lstTools.Name = "lstTools";
            this.lstTools.Size = new System.Drawing.Size(197, 395);
            this.lstTools.TabIndex = 0;
            this.lstTools.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstTools_DrawItem);
            this.lstTools.SelectedIndexChanged += new System.EventHandler(this.lstTools_SelectedIndexChanged);
            // 
            // gbToolCreator
            // 
            this.gbToolCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbToolCreator.Controls.Add(this.button4);
            this.gbToolCreator.Controls.Add(this.pTestPanel);
            this.gbToolCreator.Controls.Add(this.btnTest);
            this.gbToolCreator.Controls.Add(this.chkContinuous);
            this.gbToolCreator.Controls.Add(this.tbScripts);
            this.gbToolCreator.Controls.Add(this.txtDscr);
            this.gbToolCreator.Controls.Add(this.txtFace);
            this.gbToolCreator.Controls.Add(this.txtName);
            this.gbToolCreator.Controls.Add(this.label3);
            this.gbToolCreator.Controls.Add(this.label2);
            this.gbToolCreator.Controls.Add(this.label1);
            this.gbToolCreator.Location = new System.Drawing.Point(209, 0);
            this.gbToolCreator.Name = "gbToolCreator";
            this.gbToolCreator.Size = new System.Drawing.Size(436, 426);
            this.gbToolCreator.TabIndex = 1;
            this.gbToolCreator.TabStop = false;
            this.gbToolCreator.Text = "tool creator";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(377, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Commit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pTestPanel
            // 
            this.pTestPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTestPanel.Location = new System.Drawing.Point(16, 364);
            this.pTestPanel.Name = "pTestPanel";
            this.pTestPanel.Size = new System.Drawing.Size(355, 52);
            this.pTestPanel.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(377, 364);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(46, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // chkContinuous
            // 
            this.chkContinuous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(346, 23);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(81, 16);
            this.chkContinuous.TabIndex = 7;
            this.chkContinuous.Text = "Continuous";
            this.chkContinuous.UseVisualStyleBackColor = true;
            // 
            // tbScripts
            // 
            this.tbScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScripts.Controls.Add(this.tpGlobal);
            this.tbScripts.Controls.Add(this.tpPrepare);
            this.tbScripts.Controls.Add(this.tpChecker);
            this.tbScripts.Controls.Add(this.tpAction);
            this.tbScripts.Controls.Add(this.tpFinish);
            this.tbScripts.Location = new System.Drawing.Point(12, 96);
            this.tbScripts.Name = "tbScripts";
            this.tbScripts.SelectedIndex = 0;
            this.tbScripts.Size = new System.Drawing.Size(415, 262);
            this.tbScripts.TabIndex = 6;
            // 
            // tpGlobal
            // 
            this.tpGlobal.Controls.Add(this.btnResetGlobalScript);
            this.tpGlobal.Controls.Add(this.txtGlobalScript);
            this.tpGlobal.Controls.Add(this.label4);
            this.tpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tpGlobal.Name = "tpGlobal";
            this.tpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobal.Size = new System.Drawing.Size(407, 236);
            this.tpGlobal.TabIndex = 0;
            this.tpGlobal.Text = "Global";
            this.tpGlobal.UseVisualStyleBackColor = true;
            // 
            // btnResetGlobalScript
            // 
            this.btnResetGlobalScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetGlobalScript.Location = new System.Drawing.Point(326, 207);
            this.btnResetGlobalScript.Name = "btnResetGlobalScript";
            this.btnResetGlobalScript.Size = new System.Drawing.Size(75, 23);
            this.btnResetGlobalScript.TabIndex = 2;
            this.btnResetGlobalScript.Text = "reset";
            this.btnResetGlobalScript.UseVisualStyleBackColor = true;
            // 
            // txtGlobalScript
            // 
            this.txtGlobalScript.AcceptsTab = true;
            this.txtGlobalScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGlobalScript.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtGlobalScript.Location = new System.Drawing.Point(6, 15);
            this.txtGlobalScript.Multiline = true;
            this.txtGlobalScript.Name = "txtGlobalScript";
            this.txtGlobalScript.Size = new System.Drawing.Size(395, 186);
            this.txtGlobalScript.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "define global members.";
            // 
            // tpPrepare
            // 
            this.tpPrepare.Controls.Add(this.btnResetPrepareScript);
            this.tpPrepare.Controls.Add(this.txtPrepareScript);
            this.tpPrepare.Controls.Add(this.label5);
            this.tpPrepare.Location = new System.Drawing.Point(4, 22);
            this.tpPrepare.Name = "tpPrepare";
            this.tpPrepare.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrepare.Size = new System.Drawing.Size(407, 236);
            this.tpPrepare.TabIndex = 1;
            this.tpPrepare.Text = "Prepare";
            this.tpPrepare.UseVisualStyleBackColor = true;
            // 
            // btnResetPrepareScript
            // 
            this.btnResetPrepareScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPrepareScript.Location = new System.Drawing.Point(229, 203);
            this.btnResetPrepareScript.Name = "btnResetPrepareScript";
            this.btnResetPrepareScript.Size = new System.Drawing.Size(75, 23);
            this.btnResetPrepareScript.TabIndex = 4;
            this.btnResetPrepareScript.Text = "reset";
            this.btnResetPrepareScript.UseVisualStyleBackColor = true;
            // 
            // txtPrepareScript
            // 
            this.txtPrepareScript.AcceptsTab = true;
            this.txtPrepareScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrepareScript.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
            this.txtPrepareScript.Location = new System.Drawing.Point(6, 11);
            this.txtPrepareScript.Multiline = true;
            this.txtPrepareScript.Name = "txtPrepareScript";
            this.txtPrepareScript.Size = new System.Drawing.Size(298, 186);
            this.txtPrepareScript.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "run once at application startup.";
            // 
            // tpChecker
            // 
            this.tpChecker.Controls.Add(this.btnResetCheckerScript);
            this.tpChecker.Controls.Add(this.txtCheckerScript);
            this.tpChecker.Controls.Add(this.label6);
            this.tpChecker.Location = new System.Drawing.Point(4, 22);
            this.tpChecker.Name = "tpChecker";
            this.tpChecker.Size = new System.Drawing.Size(407, 236);
            this.tpChecker.TabIndex = 2;
            this.tpChecker.Text = "Checker";
            this.tpChecker.UseVisualStyleBackColor = true;
            // 
            // btnResetCheckerScript
            // 
            this.btnResetCheckerScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetCheckerScript.Location = new System.Drawing.Point(229, 203);
            this.btnResetCheckerScript.Name = "btnResetCheckerScript";
            this.btnResetCheckerScript.Size = new System.Drawing.Size(75, 23);
            this.btnResetCheckerScript.TabIndex = 4;
            this.btnResetCheckerScript.Text = "reset";
            this.btnResetCheckerScript.UseVisualStyleBackColor = true;
            // 
            // txtCheckerScript
            // 
            this.txtCheckerScript.AcceptsTab = true;
            this.txtCheckerScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckerScript.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
            this.txtCheckerScript.Location = new System.Drawing.Point(6, 11);
            this.txtCheckerScript.Multiline = true;
            this.txtCheckerScript.Name = "txtCheckerScript";
            this.txtCheckerScript.Size = new System.Drawing.Size(298, 186);
            this.txtCheckerScript.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "normal: visibility contorl / continuous: action control";
            // 
            // tpAction
            // 
            this.tpAction.Controls.Add(this.btnResetActionScript);
            this.tpAction.Controls.Add(this.txtActionScript);
            this.tpAction.Controls.Add(this.label7);
            this.tpAction.Location = new System.Drawing.Point(4, 22);
            this.tpAction.Name = "tpAction";
            this.tpAction.Size = new System.Drawing.Size(407, 236);
            this.tpAction.TabIndex = 3;
            this.tpAction.Text = "Action";
            this.tpAction.UseVisualStyleBackColor = true;
            // 
            // btnResetActionScript
            // 
            this.btnResetActionScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetActionScript.Location = new System.Drawing.Point(229, 203);
            this.btnResetActionScript.Name = "btnResetActionScript";
            this.btnResetActionScript.Size = new System.Drawing.Size(75, 23);
            this.btnResetActionScript.TabIndex = 4;
            this.btnResetActionScript.Text = "reset";
            this.btnResetActionScript.UseVisualStyleBackColor = true;
            // 
            // txtActionScript
            // 
            this.txtActionScript.AcceptsTab = true;
            this.txtActionScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActionScript.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
            this.txtActionScript.Location = new System.Drawing.Point(6, 11);
            this.txtActionScript.Multiline = true;
            this.txtActionScript.Name = "txtActionScript";
            this.txtActionScript.Size = new System.Drawing.Size(298, 186);
            this.txtActionScript.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "normal: run at click. / continuous: run at clipboard updated. ";
            // 
            // tpFinish
            // 
            this.tpFinish.Controls.Add(this.btnResetFinishActionScript);
            this.tpFinish.Controls.Add(this.txtFinishActionScript);
            this.tpFinish.Controls.Add(this.label8);
            this.tpFinish.Location = new System.Drawing.Point(4, 22);
            this.tpFinish.Name = "tpFinish";
            this.tpFinish.Size = new System.Drawing.Size(407, 236);
            this.tpFinish.TabIndex = 4;
            this.tpFinish.Text = "FinishAction";
            this.tpFinish.UseVisualStyleBackColor = true;
            // 
            // btnResetFinishActionScript
            // 
            this.btnResetFinishActionScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFinishActionScript.Location = new System.Drawing.Point(229, 203);
            this.btnResetFinishActionScript.Name = "btnResetFinishActionScript";
            this.btnResetFinishActionScript.Size = new System.Drawing.Size(75, 23);
            this.btnResetFinishActionScript.TabIndex = 4;
            this.btnResetFinishActionScript.Text = "reset";
            this.btnResetFinishActionScript.UseVisualStyleBackColor = true;
            // 
            // txtFinishActionScript
            // 
            this.txtFinishActionScript.AcceptsTab = true;
            this.txtFinishActionScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinishActionScript.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
            this.txtFinishActionScript.Location = new System.Drawing.Point(6, 11);
            this.txtFinishActionScript.Multiline = true;
            this.txtFinishActionScript.Name = "txtFinishActionScript";
            this.txtFinishActionScript.Size = new System.Drawing.Size(298, 186);
            this.txtFinishActionScript.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "run at continuous tool deactivated.";
            // 
            // txtDscr
            // 
            this.txtDscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDscr.Location = new System.Drawing.Point(50, 71);
            this.txtDscr.Name = "txtDscr";
            this.txtDscr.Size = new System.Drawing.Size(377, 19);
            this.txtDscr.TabIndex = 5;
            // 
            // txtFace
            // 
            this.txtFace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFace.Location = new System.Drawing.Point(50, 46);
            this.txtFace.Name = "txtFace";
            this.txtFace.Size = new System.Drawing.Size(377, 19);
            this.txtFace.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(50, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 19);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dscr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Face";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 432);
            this.Controls.Add(this.gbToolCreator);
            this.Controls.Add(this.pLeft);
            this.Name = "ConfigurationWindow";
            this.Text = "Configulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigurationWindow_FormClosing);
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.gbToolCreator.ResumeLayout(false);
            this.gbToolCreator.PerformLayout();
            this.tbScripts.ResumeLayout(false);
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            this.tpPrepare.ResumeLayout(false);
            this.tpPrepare.PerformLayout();
            this.tpChecker.ResumeLayout(false);
            this.tpChecker.PerformLayout();
            this.tpAction.ResumeLayout(false);
            this.tpAction.PerformLayout();
            this.tpFinish.ResumeLayout(false);
            this.tpFinish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.CheckBox chkAdvancedMode;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ListBox lstTools;
        private System.Windows.Forms.GroupBox gbToolCreator;
        private System.Windows.Forms.CheckBox chkContinuous;
        private System.Windows.Forms.TabControl tbScripts;
        private System.Windows.Forms.TabPage tpGlobal;
        private System.Windows.Forms.TabPage tpPrepare;
        private System.Windows.Forms.TextBox txtDscr;
        private System.Windows.Forms.TextBox txtFace;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpChecker;
        private System.Windows.Forms.TabPage tpAction;
        private System.Windows.Forms.TabPage tpFinish;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pTestPanel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnResetGlobalScript;
        private System.Windows.Forms.TextBox txtGlobalScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetPrepareScript;
        private System.Windows.Forms.TextBox txtPrepareScript;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetCheckerScript;
        private System.Windows.Forms.TextBox txtCheckerScript;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResetActionScript;
        private System.Windows.Forms.TextBox txtActionScript;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetFinishActionScript;
        private System.Windows.Forms.TextBox txtFinishActionScript;
        private System.Windows.Forms.Label label8;
    }
}