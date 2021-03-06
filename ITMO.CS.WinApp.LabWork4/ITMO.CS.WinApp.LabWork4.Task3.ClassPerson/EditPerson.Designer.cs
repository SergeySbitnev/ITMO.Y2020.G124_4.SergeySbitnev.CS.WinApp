﻿namespace ITMO.CS.WinApp.LabWork4.Task3.ClassPerson
{
    partial class EditPerson
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
            this.personsListView = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.richTextBoxView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.age});
            this.personsListView.HideSelection = false;
            this.personsListView.Location = new System.Drawing.Point(1, 1);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(450, 200);
            this.personsListView.TabIndex = 0;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            this.personsListView.VirtualMode = true;
            this.personsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView_RetrieveVirtualItem_1);
            // 
            // firstName
            // 
            this.firstName.Text = "Имя";
            this.firstName.Width = 152;
            // 
            // lastName
            // 
            this.lastName.Text = "Фамилия";
            this.lastName.Width = 146;
            // 
            // age
            // 
            this.age.Text = "Возраст";
            this.age.Width = 148;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(56, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(288, 258);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(56, 321);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(332, 23);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "Просмотреть список";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // richTextBoxView
            // 
            this.richTextBoxView.Location = new System.Drawing.Point(56, 376);
            this.richTextBoxView.Name = "richTextBoxView";
            this.richTextBoxView.Size = new System.Drawing.Size(332, 96);
            this.richTextBoxView.TabIndex = 4;
            this.richTextBoxView.Text = "";
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 495);
            this.Controls.Add(this.richTextBoxView);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.personsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditPerson";
            this.Text = "Список сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.RichTextBox richTextBoxView;
    }
}

