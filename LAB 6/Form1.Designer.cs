namespace LAB_6
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
            this.textBox1_1 = new System.Windows.Forms.TextBox();
            this.ok_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_1 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_1
            // 
            this.textBox1_1.Location = new System.Drawing.Point(84, 43);
            this.textBox1_1.Name = "textBox1_1";
            this.textBox1_1.Size = new System.Drawing.Size(209, 22);
            this.textBox1_1.TabIndex = 0;
            // 
            // ok_1
            // 
            this.ok_1.Location = new System.Drawing.Point(389, 139);
            this.ok_1.Name = "ok_1";
            this.ok_1.Size = new System.Drawing.Size(75, 23);
            this.ok_1.TabIndex = 1;
            this.ok_1.Text = "ok";
            this.ok_1.UseVisualStyleBackColor = true;
            this.ok_1.Click += new System.EventHandler(this.ok_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ПАРОЛЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ЛОГИН";
            // 
            // textBox2_1
            // 
            this.textBox2_1.Location = new System.Drawing.Point(84, 92);
            this.textBox2_1.Name = "textBox2_1";
            this.textBox2_1.PasswordChar = '*';
            this.textBox2_1.Size = new System.Drawing.Size(209, 22);
            this.textBox2_1.TabIndex = 3;
            this.textBox2_1.UseSystemPasswordChar = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(269, 139);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 179);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok_1);
            this.Controls.Add(this.textBox1_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АВТОРИЗАЦИЯ ПОЛЬЗОВАТЕЛЯ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ok_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.TextBox textBox1_1;
        public System.Windows.Forms.TextBox textBox2_1;
    }
}

