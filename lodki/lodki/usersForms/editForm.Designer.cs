namespace lodki.usersForms
{
    partial class editForm
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
            this.but_add = new System.Windows.Forms.Button();
            this.fie_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fie_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fie_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(10, 91);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(261, 23);
            this.but_add.TabIndex = 13;
            this.but_add.Text = "Изменить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // fie_role
            // 
            this.fie_role.FormattingEnabled = true;
            this.fie_role.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.fie_role.Location = new System.Drawing.Point(100, 64);
            this.fie_role.Name = "fie_role";
            this.fie_role.Size = new System.Drawing.Size(171, 21);
            this.fie_role.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Роль:";
            // 
            // fie_pass
            // 
            this.fie_pass.Location = new System.Drawing.Point(100, 38);
            this.fie_pass.Name = "fie_pass";
            this.fie_pass.Size = new System.Drawing.Size(171, 20);
            this.fie_pass.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль:";
            // 
            // fie_login
            // 
            this.fie_login.Location = new System.Drawing.Point(100, 12);
            this.fie_login.Name = "fie_login";
            this.fie_login.Size = new System.Drawing.Size(171, 20);
            this.fie_login.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин:";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 122);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.fie_role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fie_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fie_login);
            this.Controls.Add(this.label1);
            this.Name = "editForm";
            this.Text = "Изменить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ComboBox fie_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fie_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fie_login;
        private System.Windows.Forms.Label label1;
    }
}