namespace Playfair
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChipherText = new System.Windows.Forms.TextBox();
            this.Encryption = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.Decryption = new System.Windows.Forms.Button();
            this.DecryptionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(92, 22);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(398, 21);
            this.keyText.TabIndex = 0;
            this.keyText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "암호키";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "평문";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(92, 76);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(398, 21);
            this.Message.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "암호문";
            // 
            // ChipherText
            // 
            this.ChipherText.Location = new System.Drawing.Point(92, 127);
            this.ChipherText.Name = "ChipherText";
            this.ChipherText.Size = new System.Drawing.Size(398, 21);
            this.ChipherText.TabIndex = 5;
            // 
            // Encryption
            // 
            this.Encryption.Location = new System.Drawing.Point(33, 222);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(75, 23);
            this.Encryption.TabIndex = 6;
            this.Encryption.Text = "암호화";
            this.Encryption.UseVisualStyleBackColor = true;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("굴림", 15F);
            this.test.Location = new System.Drawing.Point(30, 273);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(57, 20);
            this.test.TabIndex = 7;
            this.test.Text = "label4";
            // 
            // Decryption
            // 
            this.Decryption.Location = new System.Drawing.Point(171, 222);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(75, 23);
            this.Decryption.TabIndex = 9;
            this.Decryption.Text = "복호화";
            this.Decryption.UseVisualStyleBackColor = true;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // DecryptionText
            // 
            this.DecryptionText.Location = new System.Drawing.Point(91, 176);
            this.DecryptionText.Name = "DecryptionText";
            this.DecryptionText.Size = new System.Drawing.Size(398, 21);
            this.DecryptionText.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "복호문";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecryptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.ChipherText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChipherText;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.TextBox DecryptionText;
        private System.Windows.Forms.Label label4;
    }
}

