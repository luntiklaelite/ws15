namespace lodki
{
    partial class changePassForm
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
            this.fie_old = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fie_new = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fie_reap = new System.Windows.Forms.TextBox();
            this.but_smena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fie_old
            // 
            this.fie_old.Location = new System.Drawing.Point(226, 13);
            this.fie_old.Name = "fie_old";
            this.fie_old.Size = new System.Drawing.Size(204, 20);
            this.fie_old.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш старый пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваш новый пароль:";
            // 
            // fie_new
            // 
            this.fie_new.Location = new System.Drawing.Point(226, 39);
            this.fie_new.Name = "fie_new";
            this.fie_new.Size = new System.Drawing.Size(204, 20);
            this.fie_new.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите:";
            // 
            // fie_reap
            // 
            this.fie_reap.Location = new System.Drawing.Point(226, 65);
            this.fie_reap.Name = "fie_reap";
            this.fie_reap.Size = new System.Drawing.Size(204, 20);
            this.fie_reap.TabIndex = 4;
            // 
            // but_smena
            // 
            this.but_smena.Location = new System.Drawing.Point(16, 91);
            this.but_smena.Name = "but_smena";
            this.but_smena.Size = new System.Drawing.Size(414, 23);
            this.but_smena.TabIndex = 6;
            this.but_smena.Text = "Сменить пароль";
            this.but_smena.UseVisualStyleBackColor = true;
            this.but_smena.Click += new System.EventHandler(this.but_smena_Click);
            // 
            // changePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 121);
            this.Controls.Add(this.but_smena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fie_reap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fie_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fie_old);
            this.Name = "changePassForm";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fie_old;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fie_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fie_reap;
        private System.Windows.Forms.Button but_smena;
    }
}