namespace TestStuff
{
    partial class Form1
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
            this.token = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.discoveryUrl = new System.Windows.Forms.TextBox();
            this.payload = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(15, 59);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(931, 220);
            this.token.TabIndex = 6;
            this.token.Text = "Paste token and click Process ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discovery Url";
            // 
            // discoveryUrl
            // 
            this.discoveryUrl.Location = new System.Drawing.Point(88, 12);
            this.discoveryUrl.Name = "discoveryUrl";
            this.discoveryUrl.Size = new System.Drawing.Size(546, 20);
            this.discoveryUrl.TabIndex = 8;
            this.discoveryUrl.Text = "https://login.microsoftonline.com/5afa80b5-7ac5-41f7-b1f9-0580195b0d99/.well-know" +
    "n/openid-configuration";
            // 
            // payload
            // 
            this.payload.Location = new System.Drawing.Point(12, 344);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(934, 287);
            this.payload.TabIndex = 10;
            this.payload.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Payload";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Token";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.payload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discoveryUrl);
            this.Controls.Add(this.token);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox token;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discoveryUrl;
        private System.Windows.Forms.RichTextBox payload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

