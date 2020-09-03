namespace TCP_Client_Demo
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
            System.Windows.Forms.Label label1;
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txb_send = new System.Windows.Forms.TextBox();
            this.btn_ac1 = new System.Windows.Forms.Button();
            this.btn_ac2 = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.lab_size = new System.Windows.Forms.Label();
            this.txb_rec = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 12);
            label1.TabIndex = 7;
            label1.Text = "Receive";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(93, 12);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // txb_send
            // 
            this.txb_send.Location = new System.Drawing.Point(12, 70);
            this.txb_send.Name = "txb_send";
            this.txb_send.Size = new System.Drawing.Size(100, 22);
            this.txb_send.TabIndex = 2;
            // 
            // btn_ac1
            // 
            this.btn_ac1.Location = new System.Drawing.Point(12, 41);
            this.btn_ac1.Name = "btn_ac1";
            this.btn_ac1.Size = new System.Drawing.Size(75, 23);
            this.btn_ac1.TabIndex = 3;
            this.btn_ac1.Text = "0x01";
            this.btn_ac1.UseVisualStyleBackColor = true;
            this.btn_ac1.Click += new System.EventHandler(this.btn_ac1_Click);
            // 
            // btn_ac2
            // 
            this.btn_ac2.Location = new System.Drawing.Point(93, 41);
            this.btn_ac2.Name = "btn_ac2";
            this.btn_ac2.Size = new System.Drawing.Size(75, 23);
            this.btn_ac2.TabIndex = 4;
            this.btn_ac2.Text = "0x02";
            this.btn_ac2.UseVisualStyleBackColor = true;
            this.btn_ac2.Click += new System.EventHandler(this.btn_ac2_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(119, 71);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(49, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lab_size
            // 
            this.lab_size.AutoSize = true;
            this.lab_size.Location = new System.Drawing.Point(157, 101);
            this.lab_size.Name = "lab_size";
            this.lab_size.Size = new System.Drawing.Size(11, 12);
            this.lab_size.TabIndex = 8;
            this.lab_size.Text = "0";
            // 
            // txb_rec
            // 
            this.txb_rec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_rec.Location = new System.Drawing.Point(14, 116);
            this.txb_rec.Name = "txb_rec";
            this.txb_rec.ReadOnly = true;
            this.txb_rec.Size = new System.Drawing.Size(154, 124);
            this.txb_rec.TabIndex = 9;
            this.txb_rec.Text = "";
            this.txb_rec.TextChanged += new System.EventHandler(this.txb_rec_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 252);
            this.Controls.Add(this.txb_rec);
            this.Controls.Add(this.lab_size);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_ac2);
            this.Controls.Add(this.btn_ac1);
            this.Controls.Add(this.txb_send);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox txb_send;
        private System.Windows.Forms.Button btn_ac1;
        private System.Windows.Forms.Button btn_ac2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lab_size;
        private System.Windows.Forms.RichTextBox txb_rec;
    }
}

