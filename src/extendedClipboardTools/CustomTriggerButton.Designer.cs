namespace extendedClipboardTools
{
    partial class CustomTriggerButton
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAct = new System.Windows.Forms.Button();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.chkContAct = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAct
            // 
            this.btnAct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAct.Location = new System.Drawing.Point(0, 0);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(128, 24);
            this.btnAct.TabIndex = 0;
            this.btnAct.Text = "btnAct";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // cmbOption
            // 
            this.cmbOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(130, 2);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(75, 20);
            this.cmbOption.TabIndex = 1;
            this.cmbOption.Click += new System.EventHandler(this.cmbOption_Click);
            // 
            // chkContAct
            // 
            this.chkContAct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContAct.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkContAct.Location = new System.Drawing.Point(0, 0);
            this.chkContAct.Name = "chkContAct";
            this.chkContAct.Size = new System.Drawing.Size(128, 24);
            this.chkContAct.TabIndex = 2;
            this.chkContAct.Text = "chkContAct";
            this.chkContAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkContAct.UseVisualStyleBackColor = true;
            this.chkContAct.CheckedChanged += new System.EventHandler(this.chkContAct_CheckedChanged);
            // 
            // CustomTriggerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkContAct);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.btnAct);
            this.Name = "CustomTriggerButton";
            this.Size = new System.Drawing.Size(208, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.CheckBox chkContAct;
    }
}
