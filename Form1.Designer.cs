namespace Example11
{
    partial class うるう年判定
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.btmJudge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(103, 85);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 2;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(47, 24);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(83, 19);
            this.tbxYear.TabIndex = 3;
            // 
            // btmJudge
            // 
            this.btmJudge.Location = new System.Drawing.Point(178, 22);
            this.btmJudge.Name = "btmJudge";
            this.btmJudge.Size = new System.Drawing.Size(75, 23);
            this.btmJudge.TabIndex = 4;
            this.btmJudge.Text = "判定";
            this.btmJudge.UseVisualStyleBackColor = true;
            this.btmJudge.Click += new System.EventHandler(this.btmJudge_Click);
            // 
            // うるう年判定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.btmJudge);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "うるう年判定";
            this.Text = "うるう年判定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Button btmJudge;
    }
}

