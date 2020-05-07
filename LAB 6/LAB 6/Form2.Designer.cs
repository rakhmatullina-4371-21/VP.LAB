namespace LAB_6
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_2 = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.ok_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ЛОГИН";
            // 
            // textBox2_2
            // 
            this.textBox2_2.Location = new System.Drawing.Point(100, 96);
            this.textBox2_2.Name = "textBox2_2";
            this.textBox2_2.Size = new System.Drawing.Size(193, 22);
            this.textBox2_2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ПАРОЛЬ";
            // 
            // textBox1_2
            // 
            this.textBox1_2.Location = new System.Drawing.Point(100, 47);
            this.textBox1_2.Name = "textBox1_2";
            this.textBox1_2.Size = new System.Drawing.Size(193, 22);
            this.textBox1_2.TabIndex = 5;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(114, 169);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 10;
            this.edit.Text = "edit ";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // ok_2
            // 
            this.ok_2.Location = new System.Drawing.Point(218, 169);
            this.ok_2.Name = "ok_2";
            this.ok_2.Size = new System.Drawing.Size(75, 23);
            this.ok_2.TabIndex = 9;
            this.ok_2.Text = "ok";
            this.ok_2.UseVisualStyleBackColor = true;
            this.ok_2.Click += new System.EventHandler(this.ok_2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 225);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.ok_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button ok_2;
        public System.Windows.Forms.TextBox textBox2_2;
        public System.Windows.Forms.TextBox textBox1_2;
    }
}