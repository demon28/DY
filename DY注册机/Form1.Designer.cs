namespace DY注册机
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_loger = new System.Windows.Forms.TextBox();
            this.btn_getphone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_verifycode = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_token = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_loger
            // 
            this.tb_loger.Location = new System.Drawing.Point(12, 320);
            this.tb_loger.Multiline = true;
            this.tb_loger.Name = "tb_loger";
            this.tb_loger.Size = new System.Drawing.Size(404, 146);
            this.tb_loger.TabIndex = 0;
            // 
            // btn_getphone
            // 
            this.btn_getphone.Location = new System.Drawing.Point(26, 34);
            this.btn_getphone.Name = "btn_getphone";
            this.btn_getphone.Size = new System.Drawing.Size(83, 28);
            this.btn_getphone.TabIndex = 2;
            this.btn_getphone.Text = "获取手机号";
            this.btn_getphone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_getphone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "获取验证码";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_verifycode
            // 
            this.tb_verifycode.Location = new System.Drawing.Point(115, 68);
            this.tb_verifycode.Multiline = true;
            this.tb_verifycode.Name = "tb_verifycode";
            this.tb_verifycode.Size = new System.Drawing.Size(136, 26);
            this.tb_verifycode.TabIndex = 4;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(115, 36);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(136, 26);
            this.tb_phone.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(26, 19);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(106, 28);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "获取短信验证码";
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_item);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_token);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_pwd);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.btn_getphone);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.tb_verifycode);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btn_register);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 180);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "注册";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(560, 12);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(136, 21);
            this.tb_user.TabIndex = 7;
            this.tb_user.Text = "demon28";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(560, 39);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(136, 21);
            this.tb_pwd.TabIndex = 8;
            this.tb_pwd.Text = "13054134167c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "密码：";
            // 
            // tb_token
            // 
            this.tb_token.Location = new System.Drawing.Point(560, 66);
            this.tb_token.Name = "tb_token";
            this.tb_token.Size = new System.Drawing.Size(136, 21);
            this.tb_token.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "票证：";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(711, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(42, 28);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "登录";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "滑块验证";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "修改资料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 29);
            this.button6.TabIndex = 11;
            this.button6.Text = "退出登录";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(439, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 332);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "浏览器";
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(560, 93);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(136, 21);
            this.tb_item.TabIndex = 14;
            this.tb_item.Text = "15231";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "项目：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_loger);
            this.Name = "Form1";
            this.Text = "DY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_loger;
        private System.Windows.Forms.Button btn_getphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_verifycode;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_token;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_item;
    }
}

