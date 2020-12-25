namespace test6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.loginString = new System.Windows.Forms.TextBox();
            this.passwordString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            this.guestEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(75, 224);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(54, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // loginString
            // 
            this.loginString.Location = new System.Drawing.Point(131, 91);
            this.loginString.Name = "loginString";
            this.loginString.Size = new System.Drawing.Size(100, 20);
            this.loginString.TabIndex = 1;
            // 
            // passwordString
            // 
            this.passwordString.Location = new System.Drawing.Point(131, 175);
            this.passwordString.Name = "passwordString";
            this.passwordString.PasswordChar = '*';
            this.passwordString.Size = new System.Drawing.Size(100, 20);
            this.passwordString.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "e-mail или Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(135, 224);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(96, 23);
            this.redButton.TabIndex = 5;
            this.redButton.Text = "Регистрация";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // guestEnter
            // 
            this.guestEnter.Location = new System.Drawing.Point(75, 254);
            this.guestEnter.Name = "guestEnter";
            this.guestEnter.Size = new System.Drawing.Size(156, 23);
            this.guestEnter.TabIndex = 6;
            this.guestEnter.Text = "Войти как гость";
            this.guestEnter.UseVisualStyleBackColor = true;
            this.guestEnter.Click += new System.EventHandler(this.guestEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 340);
            this.Controls.Add(this.guestEnter);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordString);
            this.Controls.Add(this.loginString);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox loginString;
        private System.Windows.Forms.TextBox passwordString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button guestEnter;
    }
}

