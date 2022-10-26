namespace Exec2_Star
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
            this.button1 = new System.Windows.Forms.Button();
            this.textRow = new System.Windows.Forms.TextBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.textShow = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "靠左";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRow
            // 
            this.textRow.Location = new System.Drawing.Point(59, 43);
            this.textRow.Name = "textRow";
            this.textRow.Size = new System.Drawing.Size(263, 25);
            this.textRow.TabIndex = 1;
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(56, 326);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(512, 160);
            this.labelShow.TabIndex = 2;
            this.labelShow.Click += new System.EventHandler(this.label1_Click);
            // 
            // textShow
            // 
            this.textShow.Location = new System.Drawing.Point(59, 118);
            this.textShow.Multiline = true;
            this.textShow.Name = "textShow";
            this.textShow.ReadOnly = true;
            this.textShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textShow.Size = new System.Drawing.Size(519, 164);
            this.textShow.TabIndex = 1;
            this.textShow.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "靠右";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(607, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "等腰";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 545);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.textShow);
            this.Controls.Add(this.textRow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textRow;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox textShow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

