namespace lodki
{
    partial class orders_form
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
            this.but_del = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_addUser = new System.Windows.Forms.Button();
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            this.SuspendLayout();
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(584, 421);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(179, 23);
            this.but_del.TabIndex = 7;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = true;
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(298, 421);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(179, 23);
            this.but_edit.TabIndex = 6;
            this.but_edit.Text = "Изменить";
            this.but_edit.UseVisualStyleBackColor = true;
            // 
            // but_addUser
            // 
            this.but_addUser.Location = new System.Drawing.Point(12, 421);
            this.but_addUser.Name = "but_addUser";
            this.but_addUser.Size = new System.Drawing.Size(179, 23);
            this.but_addUser.TabIndex = 5;
            this.but_addUser.Text = "Добавить";
            this.but_addUser.UseVisualStyleBackColor = true;
            // 
            // grid_users
            // 
            this.grid_users.AllowUserToAddRows = false;
            this.grid_users.AllowUserToDeleteRows = false;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grid_users.Location = new System.Drawing.Point(12, 12);
            this.grid_users.Name = "grid_users";
            this.grid_users.ReadOnly = true;
            this.grid_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_users.Size = new System.Drawing.Size(751, 403);
            this.grid_users.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "order_id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "deliveryAddress";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "city";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "boat_id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "customer_id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "salesperson_id";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_addUser);
            this.Controls.Add(this.grid_users);
            this.Name = "orders_form";
            this.Text = "orders";
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_addUser;
        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}