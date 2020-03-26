namespace lodki
{
    partial class loginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fie_login = new System.Windows.Forms.TextBox();
            this.fie_pass = new System.Windows.Forms.TextBox();
            this.but_auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // fie_login
            // 
            this.fie_login.Location = new System.Drawing.Point(100, 12);
            this.fie_login.Name = "fie_login";
            this.fie_login.Size = new System.Drawing.Size(172, 20);
            this.fie_login.TabIndex = 2;
            // 
            // fie_pass
            // 
            this.fie_pass.Location = new System.Drawing.Point(100, 46);
            this.fie_pass.Name = "fie_pass";
            this.fie_pass.Size = new System.Drawing.Size(172, 20);
            this.fie_pass.TabIndex = 3;
            // 
            // but_auth
            // 
            this.but_auth.Location = new System.Drawing.Point(16, 81);
            this.but_auth.Name = "but_auth";
            this.but_auth.Size = new System.Drawing.Size(256, 23);
            this.but_auth.TabIndex = 4;
            this.but_auth.Text = "Войти";
            this.but_auth.UseVisualStyleBackColor = true;
            this.but_auth.Click += new System.EventHandler(this.but_auth_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.but_auth);
            this.Controls.Add(this.fie_pass);
            this.Controls.Add(this.fie_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fie_login;
        private System.Windows.Forms.TextBox fie_pass;
        private System.Windows.Forms.Button but_auth;

    }
}

