namespace extendedClipboardTools
{
    partial class ControlBoard
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pUp = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.pUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUp
            // 
            this.pUp.Controls.Add(this.btnConfig);
            this.pUp.Controls.Add(this.chkTopMost);
            this.pUp.Controls.Add(this.lblMsg);
            this.pUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUp.Location = new System.Drawing.Point(0, 0);
            this.pUp.Name = "pUp";
            this.pUp.Size = new System.Drawing.Size(209, 29);
            this.pUp.TabIndex = 2;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(176, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(30, 23);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "...";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // chkTopMost
            // 
            this.chkTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(127, 7);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(43, 16);
            this.chkTopMost.TabIndex = 2;
            this.chkTopMost.Text = "Top";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(3, 8);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(29, 12);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "none";
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 29);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(209, 208);
            this.pMain.TabIndex = 3;
            // 
            // ControlBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 237);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pUp);
            this.MaximizeBox = false;
            this.Name = "ControlBoard";
            this.Text = "eCT";
            this.pUp.ResumeLayout(false);
            this.pUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pUp;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblMsg;
    }
}

