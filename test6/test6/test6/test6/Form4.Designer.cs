namespace test6
{
    partial class Form4
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
            this.cadr = new System.Windows.Forms.Button();
            this.sclad = new System.Windows.Forms.Button();
            this.kasprod = new System.Windows.Forms.Button();
            this.buhg = new System.Windows.Forms.Button();
            this.pokyp = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadr
            // 
            this.cadr.Location = new System.Drawing.Point(13, 90);
            this.cadr.Name = "cadr";
            this.cadr.Size = new System.Drawing.Size(252, 34);
            this.cadr.TabIndex = 0;
            this.cadr.Text = "Кадры";
            this.cadr.UseVisualStyleBackColor = true;
            this.cadr.Click += new System.EventHandler(this.cadr_Click);
            // 
            // sclad
            // 
            this.sclad.Location = new System.Drawing.Point(12, 151);
            this.sclad.Name = "sclad";
            this.sclad.Size = new System.Drawing.Size(253, 31);
            this.sclad.TabIndex = 1;
            this.sclad.Text = "Склад";
            this.sclad.UseVisualStyleBackColor = true;
            this.sclad.Click += new System.EventHandler(this.sclad_Click);
            // 
            // kasprod
            // 
            this.kasprod.Location = new System.Drawing.Point(12, 216);
            this.kasprod.Name = "kasprod";
            this.kasprod.Size = new System.Drawing.Size(253, 31);
            this.kasprod.TabIndex = 2;
            this.kasprod.Text = "Кассир-продавец";
            this.kasprod.UseVisualStyleBackColor = true;
            this.kasprod.Click += new System.EventHandler(this.kasprod_Click);
            // 
            // buhg
            // 
            this.buhg.Location = new System.Drawing.Point(12, 279);
            this.buhg.Name = "buhg";
            this.buhg.Size = new System.Drawing.Size(253, 28);
            this.buhg.TabIndex = 3;
            this.buhg.Text = "Бухгалтерия";
            this.buhg.UseVisualStyleBackColor = true;
            this.buhg.Click += new System.EventHandler(this.buhg_Click);
            // 
            // pokyp
            // 
            this.pokyp.Location = new System.Drawing.Point(13, 332);
            this.pokyp.Name = "pokyp";
            this.pokyp.Size = new System.Drawing.Size(252, 27);
            this.pokyp.TabIndex = 4;
            this.pokyp.Text = "Покупатели";
            this.pokyp.UseVisualStyleBackColor = true;
            this.pokyp.Click += new System.EventHandler(this.pokyp_Click);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(13, 36);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(252, 33);
            this.admin.TabIndex = 5;
            this.admin.Text = "Администатор";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 379);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.pokyp);
            this.Controls.Add(this.buhg);
            this.Controls.Add(this.kasprod);
            this.Controls.Add(this.sclad);
            this.Controls.Add(this.cadr);
            this.Name = "Form4";
            this.Text = "Редактировать/удалить";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button cadr;
        public System.Windows.Forms.Button sclad;
        public System.Windows.Forms.Button kasprod;
        public System.Windows.Forms.Button buhg;
        public System.Windows.Forms.Button pokyp;
        public System.Windows.Forms.Button admin;
    }
}