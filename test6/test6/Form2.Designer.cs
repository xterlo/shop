namespace test6
{
    partial class Form2
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
            this.createUser = new System.Windows.Forms.Button();
            this.textRole = new System.Windows.Forms.Label();
            this.modDelButton = new System.Windows.Forms.Button();
            this.deletedUsers = new System.Windows.Forms.Button();
            this.findTovar = new System.Windows.Forms.Button();
            this.addTovar = new System.Windows.Forms.Button();
            this.dohodi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(12, 44);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(173, 23);
            this.createUser.TabIndex = 0;
            this.createUser.Text = "Создать нового пользователя";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // textRole
            // 
            this.textRole.AutoSize = true;
            this.textRole.Location = new System.Drawing.Point(13, 425);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(0, 13);
            this.textRole.TabIndex = 1;
            // 
            // modDelButton
            // 
            this.modDelButton.Location = new System.Drawing.Point(13, 74);
            this.modDelButton.Name = "modDelButton";
            this.modDelButton.Size = new System.Drawing.Size(172, 23);
            this.modDelButton.TabIndex = 2;
            this.modDelButton.Text = "Редактировать/удалить";
            this.modDelButton.UseVisualStyleBackColor = true;
            this.modDelButton.Click += new System.EventHandler(this.modDelButton_Click);
            // 
            // deletedUsers
            // 
            this.deletedUsers.Location = new System.Drawing.Point(12, 103);
            this.deletedUsers.Name = "deletedUsers";
            this.deletedUsers.Size = new System.Drawing.Size(173, 23);
            this.deletedUsers.TabIndex = 3;
            this.deletedUsers.Text = "Удаленные пользователи";
            this.deletedUsers.UseVisualStyleBackColor = true;
            this.deletedUsers.Click += new System.EventHandler(this.deletedUsers_Click);
            // 
            // findTovar
            // 
            this.findTovar.Location = new System.Drawing.Point(437, 74);
            this.findTovar.Name = "findTovar";
            this.findTovar.Size = new System.Drawing.Size(153, 23);
            this.findTovar.TabIndex = 4;
            this.findTovar.Text = "Посмотреть товары";
            this.findTovar.UseVisualStyleBackColor = true;
            this.findTovar.Click += new System.EventHandler(this.findTovar_Click);
            // 
            // addTovar
            // 
            this.addTovar.Location = new System.Drawing.Point(437, 44);
            this.addTovar.Name = "addTovar";
            this.addTovar.Size = new System.Drawing.Size(153, 23);
            this.addTovar.TabIndex = 5;
            this.addTovar.Text = "Поставка";
            this.addTovar.UseVisualStyleBackColor = true;
            this.addTovar.Click += new System.EventHandler(this.addTovar_Click);
            // 
            // dohodi
            // 
            this.dohodi.Location = new System.Drawing.Point(16, 133);
            this.dohodi.Name = "dohodi";
            this.dohodi.Size = new System.Drawing.Size(169, 23);
            this.dohodi.TabIndex = 6;
            this.dohodi.Text = "Посмотреть доходы";
            this.dohodi.UseVisualStyleBackColor = true;
            this.dohodi.Click += new System.EventHandler(this.dohodi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dohodi);
            this.Controls.Add(this.addTovar);
            this.Controls.Add(this.findTovar);
            this.Controls.Add(this.deletedUsers);
            this.Controls.Add(this.modDelButton);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.createUser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button modDelButton;
        public System.Windows.Forms.Label textRole;
        private System.Windows.Forms.Button deletedUsers;
        private System.Windows.Forms.Button findTovar;
        private System.Windows.Forms.Button addTovar;
        private System.Windows.Forms.Button dohodi;
    }
}