namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox txtSHOW;
            this.btnGO = new System.Windows.Forms.Button();
            txtSHOW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(458, 165);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(156, 58);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "開始";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // txtSHOW
            // 
            txtSHOW.Location = new System.Drawing.Point(119, 184);
            txtSHOW.Name = "txtSHOW";
            txtSHOW.Size = new System.Drawing.Size(324, 25);
            txtSHOW.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(txtSHOW);
            this.Controls.Add(this.btnGO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
    }
}

