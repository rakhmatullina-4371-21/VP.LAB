namespace LAB_9
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_birthLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSDataSet = new LAB_9.BOOKSDataSet();
            this.authorsTableAdapter = new LAB_9.BOOKSDataSetTableAdapters.authorsTableAdapter();
            this.tableAdapterManager = new LAB_9.BOOKSDataSetTableAdapters.TableAdapterManager();
            this.bOOKSDataSet1 = new LAB_9.BOOKSDataSet1();
            this.authorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter1 = new LAB_9.BOOKSDataSet1TableAdapters.authorsTableAdapter();
            this.tableAdapterManager1 = new LAB_9.BOOKSDataSet1TableAdapters.TableAdapterManager();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            surnameLabel = new System.Windows.Forms.Label();
            date_birthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Авторы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.bOOKSDataSet;
            // 
            // bOOKSDataSet
            // 
            this.bOOKSDataSet.DataSetName = "BOOKSDataSet";
            this.bOOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.composition_salesTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LAB_9.BOOKSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOOKSDataSet1
            // 
            this.bOOKSDataSet1.DataSetName = "BOOKSDataSet1";
            this.bOOKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource1
            // 
            this.authorsBindingSource1.DataMember = "authors";
            this.authorsBindingSource1.DataSource = this.bOOKSDataSet1;
            // 
            // authorsTableAdapter1
            // 
            this.authorsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.authorsTableAdapter = this.authorsTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.booksTableAdapter = null;
            this.tableAdapterManager1.composition_salesTableAdapter = null;
            this.tableAdapterManager1.publisherTableAdapter = null;
            this.tableAdapterManager1.publishTableAdapter = null;
            this.tableAdapterManager1.salesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LAB_9.BOOKSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(74, 142);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(67, 17);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource1, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(74, 139);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(227, 22);
            this.surnameTextBox.TabIndex = 2;
            // 
            // date_birthLabel
            // 
            date_birthLabel.AutoSize = true;
            date_birthLabel.Location = new System.Drawing.Point(74, 231);
            date_birthLabel.Name = "date_birthLabel";
            date_birthLabel.Size = new System.Drawing.Size(72, 17);
            date_birthLabel.TabIndex = 3;
            date_birthLabel.Text = "date birth:";
            // 
            // date_birthDateTimePicker
            // 
            this.date_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorsBindingSource1, "date_birth", true));
            this.date_birthDateTimePicker.Location = new System.Drawing.Point(74, 227);
            this.date_birthDateTimePicker.Name = "date_birthDateTimePicker";
            this.date_birthDateTimePicker.Size = new System.Drawing.Size(327, 22);
            this.date_birthDateTimePicker.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(date_birthLabel);
            this.Controls.Add(this.date_birthDateTimePicker);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Таблица \"Авторы\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BOOKSDataSet bOOKSDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BOOKSDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private BOOKSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BOOKSDataSet1 bOOKSDataSet1;
        private System.Windows.Forms.BindingSource authorsBindingSource1;
        private BOOKSDataSet1TableAdapters.authorsTableAdapter authorsTableAdapter1;
        private BOOKSDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker date_birthDateTimePicker;
    }
}