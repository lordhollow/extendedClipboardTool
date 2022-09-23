namespace extendedClipboardTools
{
    partial class ConfigulationWindow
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
            this.lstTools = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkAdvancedMode = new System.Windows.Forms.CheckBox();
            this.gbToolCreator = new System.Windows.Forms.GroupBox();
            this.pLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.chkAdvancedMode);
            this.pLeft.Controls.Add(this.button3);
            this.pLeft.Controls.Add(this.button2);
            this.pLeft.Controls.Add(this.button1);
            this.pLeft.Controls.Add(this.lstTools);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(203, 340);
            this.pLeft.TabIndex = 0;
            // 
            // lstTools
            // 
            this.lstTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTools.FormattingEnabled = true;
            this.lstTools.IntegralHeight = false;
            this.lstTools.ItemHeight = 12;
            this.lstTools.Location = new System.Drawing.Point(3, 3);
            this.lstTools.Name = "lstTools";
            this.lstTools.Size = new System.Drawing.Size(197, 303);
            this.lstTools.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(3, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(37, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(71, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "on/off";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkAdvancedMode
            // 
            this.chkAdvancedMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAdvancedMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAdvancedMode.AutoSize = true;
            this.chkAdvancedMode.Location = new System.Drawing.Point(171, 312);
            this.chkAdvancedMode.Name = "chkAdvancedMode";
            this.chkAdvancedMode.Size = new System.Drawing.Size(29, 22);
            this.chkAdvancedMode.TabIndex = 4;
            this.chkAdvancedMode.Text = "ad.";
            this.chkAdvancedMode.UseVisualStyleBackColor = true;
            // 
            // gbToolCreator
            // 
            this.gbToolCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbToolCreator.Location = new System.Drawing.Point(209, 0);
            this.gbToolCreator.Name = "gbToolCreator";
            this.gbToolCreator.Size = new System.Drawing.Size(353, 334);
            this.gbToolCreator.TabIndex = 1;
            this.gbToolCreator.TabStop = false;
            this.gbToolCreator.Text = "tool creator";
            // 
            // ConfigulationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 340);
            this.Controls.Add(this.gbToolCreator);
            this.Controls.Add(this.pLeft);
            this.Name = "ConfigulationWindow";
            this.Text = "Configulation";
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.CheckBox chkAdvancedMode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstTools;
        private System.Windows.Forms.GroupBox gbToolCreator;
    }
}