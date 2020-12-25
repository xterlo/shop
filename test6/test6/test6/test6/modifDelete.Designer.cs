namespace test6
{
    partial class modifDelete
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
            this.pickUser = new System.Windows.Forms.ComboBox();
            this.redact = new System.Windows.Forms.Button();
            this.delUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.obrLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.placeLabel = new System.Windows.Forms.Label();
            this.zpLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickUser
            // 
            this.pickUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickUser.FormattingEnabled = true;
            this.pickUser.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pickUser.Location = new System.Drawing.Point(12, 12);
            this.pickUser.Name = "pickUser";
            this.pickUser.Size = new System.Drawing.Size(371, 21);
            this.pickUser.TabIndex = 0;
            this.pickUser.SelectedIndexChanged += new System.EventHandler(this.pickUser_SelectedIndexChanged);
            // 
            // redact
            // 
            this.redact.Location = new System.Drawing.Point(12, 328);
            this.redact.Name = "redact";
            this.redact.Size = new System.Drawing.Size(122, 34);
            this.redact.TabIndex = 1;
            this.redact.Text = "Редактировать";
            this.redact.UseVisualStyleBackColor = true;
            // 
            // delUser
            // 
            this.delUser.Location = new System.Drawing.Point(250, 328);
            this.delUser.Name = "delUser";
            this.delUser.Size = new System.Drawing.Size(133, 34);
            this.delUser.TabIndex = 2;
            this.delUser.Text = "Удалить";
            this.delUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Возраст: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заработная плата: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Место работы: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Должность: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Опыт работы: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Образование: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Пароль: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Логин: ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(130, 252);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 13);
            this.loginLabel.TabIndex = 20;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(130, 289);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel.TabIndex = 19;
            // 
            // obrLabel
            // 
            this.obrLabel.AutoSize = true;
            this.obrLabel.Location = new System.Drawing.Point(130, 100);
            this.obrLabel.Name = "obrLabel";
            this.obrLabel.Size = new System.Drawing.Size(0, 13);
            this.obrLabel.TabIndex = 18;
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Location = new System.Drawing.Point(130, 131);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(0, 13);
            this.expLabel.TabIndex = 17;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(130, 160);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(0, 13);
            this.roleLabel.TabIndex = 16;
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(130, 191);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(0, 13);
            this.placeLabel.TabIndex = 15;
            // 
            // zpLabel
            // 
            this.zpLabel.AutoSize = true;
            this.zpLabel.Location = new System.Drawing.Point(130, 223);
            this.zpLabel.Name = "zpLabel";
            this.zpLabel.Size = new System.Drawing.Size(0, 13);
            this.zpLabel.TabIndex = 14;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(130, 69);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 13);
            this.ageLabel.TabIndex = 13;
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(130, 40);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(0, 13);
            this.fioLabel.TabIndex = 12;
            // 
            // modifDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 368);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.obrLabel);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.zpLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delUser);
            this.Controls.Add(this.redact);
            this.Controls.Add(this.pickUser);
            this.Name = "modifDelete";
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.modifDelete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox pickUser;
        public System.Windows.Forms.Button redact;
        public System.Windows.Forms.Button delUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label loginLabel;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.Label obrLabel;
        public System.Windows.Forms.Label expLabel;
        public System.Windows.Forms.Label roleLabel;
        public System.Windows.Forms.Label placeLabel;
        public System.Windows.Forms.Label zpLabel;
        public System.Windows.Forms.Label ageLabel;
        public System.Windows.Forms.Label fioLabel;
    }
}