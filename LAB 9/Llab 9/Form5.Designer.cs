﻿namespace Llab_9
{
    partial class Form5
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
            System.Windows.Forms.Label id_salesLabel;
            System.Windows.Forms.Label date_salesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.bOOKSDataSet = new Llab_9.BOOKSDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Llab_9.BOOKSDataSetTableAdapters.salesTableAdapter();
            this.tableAdapterManager = new Llab_9.BOOKSDataSetTableAdapters.TableAdapterManager();
            this.salesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_salesTextBox = new System.Windows.Forms.TextBox();
            this.date_salesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            id_salesLabel = new System.Windows.Forms.Label();
            date_salesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).BeginInit();
            this.salesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_salesLabel
            // 
            id_salesLabel.AutoSize = true;
            id_salesLabel.Location = new System.Drawing.Point(240, 177);
            id_salesLabel.Name = "id_salesLabel";
            id_salesLabel.Size = new System.Drawing.Size(60, 17);
            id_salesLabel.TabIndex = 10;
            id_salesLabel.Text = "id sales:";
            // 
            // date_salesLabel
            // 
            date_salesLabel.AutoSize = true;
            date_salesLabel.Location = new System.Drawing.Point(223, 243);
            date_salesLabel.Name = "date_salesLabel";
            date_salesLabel.Size = new System.Drawing.Size(77, 17);
            date_salesLabel.TabIndex = 11;
            date_salesLabel.Text = "date sales:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(201, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Таблица \"Заказы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bOOKSDataSet
            // 
            this.bOOKSDataSet.DataSetName = "BOOKSDataSet";
            this.bOOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.bOOKSDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.composition_salesTableAdapter = null;
            this.tableAdapterManager.publisherTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Llab_9.BOOKSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesBindingNavigator
            // 
            this.salesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesBindingNavigator.BindingSource = this.salesBindingSource;
            this.salesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.salesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salesBindingNavigatorSaveItem});
            this.salesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesBindingNavigator.Name = "salesBindingNavigator";
            this.salesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.salesBindingNavigator.TabIndex = 10;
            this.salesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // salesBindingNavigatorSaveItem
            // 
            this.salesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesBindingNavigatorSaveItem.Image")));
            this.salesBindingNavigatorSaveItem.Name = "salesBindingNavigatorSaveItem";
            this.salesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.salesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.salesBindingNavigatorSaveItem.Click += new System.EventHandler(this.salesBindingNavigatorSaveItem_Click);
            // 
            // id_salesTextBox
            // 
            this.id_salesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "id_sales", true));
            this.id_salesTextBox.Location = new System.Drawing.Point(306, 174);
            this.id_salesTextBox.Name = "id_salesTextBox";
            this.id_salesTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_salesTextBox.TabIndex = 11;
            // 
            // date_salesDateTimePicker
            // 
            this.date_salesDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesBindingSource, "date_sales", true));
            this.date_salesDateTimePicker.Location = new System.Drawing.Point(306, 239);
            this.date_salesDateTimePicker.Name = "date_salesDateTimePicker";
            this.date_salesDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_salesDateTimePicker.TabIndex = 12;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(date_salesLabel);
            this.Controls.Add(this.date_salesDateTimePicker);
            this.Controls.Add(id_salesLabel);
            this.Controls.Add(this.id_salesTextBox);
            this.Controls.Add(this.salesBindingNavigator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица \"Заказы\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingNavigator)).EndInit();
            this.salesBindingNavigator.ResumeLayout(false);
            this.salesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BOOKSDataSet bOOKSDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private BOOKSDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private BOOKSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_salesTextBox;
        private System.Windows.Forms.DateTimePicker date_salesDateTimePicker;
    }
}