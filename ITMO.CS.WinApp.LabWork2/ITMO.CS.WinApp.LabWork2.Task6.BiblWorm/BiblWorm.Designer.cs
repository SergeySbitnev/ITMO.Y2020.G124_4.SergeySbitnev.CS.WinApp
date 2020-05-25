namespace ITMO.CS.WinApp.LabWork2.Task6.BiblWorm
{
    partial class BiblWorm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublishHouse = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPublishHouse = new System.Windows.Forms.Label();
            this.numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInvNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPeriodUse = new System.Windows.Forms.NumericUpDown();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelInvNumber = new System.Windows.Forms.Label();
            this.labelPeriodUse = new System.Windows.Forms.Label();
            this.checkBoxExistence = new System.Windows.Forms.CheckBox();
            this.checkBoxReturnTime = new System.Windows.Forms.CheckBox();
            this.checkBoxSortInvNumber = new System.Windows.Forms.CheckBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodUse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxReturnTime);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.checkBoxExistence);
            this.tabPage1.Controls.Add(this.labelPeriodUse);
            this.tabPage1.Controls.Add(this.labelInvNumber);
            this.tabPage1.Controls.Add(this.labelYear);
            this.tabPage1.Controls.Add(this.labelPage);
            this.tabPage1.Controls.Add(this.numericUpDownPeriodUse);
            this.tabPage1.Controls.Add(this.numericUpDownInvNumber);
            this.tabPage1.Controls.Add(this.numericUpDownYear);
            this.tabPage1.Controls.Add(this.numericUpDownPage);
            this.tabPage1.Controls.Add(this.labelPublishHouse);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.labelAuthor);
            this.tabPage1.Controls.Add(this.textBoxPublishHouse);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(255, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(255, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журналы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(100, 6);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(130, 20);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(100, 41);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(130, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxPublishHouse
            // 
            this.textBoxPublishHouse.Location = new System.Drawing.Point(100, 76);
            this.textBoxPublishHouse.Name = "textBoxPublishHouse";
            this.textBoxPublishHouse.Size = new System.Drawing.Size(130, 20);
            this.textBoxPublishHouse.TabIndex = 2;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(37, 13);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Автор";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Название";
            // 
            // labelPublishHouse
            // 
            this.labelPublishHouse.AutoSize = true;
            this.labelPublishHouse.Location = new System.Drawing.Point(12, 79);
            this.labelPublishHouse.Name = "labelPublishHouse";
            this.labelPublishHouse.Size = new System.Drawing.Size(79, 13);
            this.labelPublishHouse.TabIndex = 5;
            this.labelPublishHouse.Text = "Издательство";
            // 
            // numericUpDownPage
            // 
            this.numericUpDownPage.Location = new System.Drawing.Point(100, 111);
            this.numericUpDownPage.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPage.Name = "numericUpDownPage";
            this.numericUpDownPage.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownPage.TabIndex = 6;
            this.numericUpDownPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(100, 146);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownYear.TabIndex = 7;
            // 
            // numericUpDownInvNumber
            // 
            this.numericUpDownInvNumber.Location = new System.Drawing.Point(100, 181);
            this.numericUpDownInvNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownInvNumber.Name = "numericUpDownInvNumber";
            this.numericUpDownInvNumber.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownInvNumber.TabIndex = 8;
            // 
            // numericUpDownPeriodUse
            // 
            this.numericUpDownPeriodUse.Location = new System.Drawing.Point(130, 216);
            this.numericUpDownPeriodUse.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownPeriodUse.Name = "numericUpDownPeriodUse";
            this.numericUpDownPeriodUse.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPeriodUse.TabIndex = 9;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(12, 113);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(49, 13);
            this.labelPage.TabIndex = 10;
            this.labelPage.Text = "Страниц";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 148);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(70, 13);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Год издания";
            // 
            // labelInvNumber
            // 
            this.labelInvNumber.AutoSize = true;
            this.labelInvNumber.Location = new System.Drawing.Point(12, 183);
            this.labelInvNumber.Name = "labelInvNumber";
            this.labelInvNumber.Size = new System.Drawing.Size(76, 13);
            this.labelInvNumber.TabIndex = 12;
            this.labelInvNumber.Text = "Инвертарный";
            // 
            // labelPeriodUse
            // 
            this.labelPeriodUse.AutoSize = true;
            this.labelPeriodUse.Location = new System.Drawing.Point(12, 218);
            this.labelPeriodUse.Name = "labelPeriodUse";
            this.labelPeriodUse.Size = new System.Drawing.Size(101, 13);
            this.labelPeriodUse.TabIndex = 13;
            this.labelPeriodUse.Text = "Срок пользования";
            // 
            // checkBoxExistence
            // 
            this.checkBoxExistence.AutoSize = true;
            this.checkBoxExistence.Location = new System.Drawing.Point(15, 273);
            this.checkBoxExistence.Name = "checkBoxExistence";
            this.checkBoxExistence.Size = new System.Drawing.Size(69, 17);
            this.checkBoxExistence.TabIndex = 14;
            this.checkBoxExistence.Text = "Наличие";
            this.checkBoxExistence.UseVisualStyleBackColor = true;
            // 
            // checkBoxReturnTime
            // 
            this.checkBoxReturnTime.AutoSize = true;
            this.checkBoxReturnTime.Location = new System.Drawing.Point(105, 273);
            this.checkBoxReturnTime.Name = "checkBoxReturnTime";
            this.checkBoxReturnTime.Size = new System.Drawing.Size(125, 17);
            this.checkBoxReturnTime.TabIndex = 15;
            this.checkBoxReturnTime.Text = "Возвращает в срок";
            this.checkBoxReturnTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortInvNumber
            // 
            this.checkBoxSortInvNumber.AutoSize = true;
            this.checkBoxSortInvNumber.Location = new System.Drawing.Point(461, 382);
            this.checkBoxSortInvNumber.Name = "checkBoxSortInvNumber";
            this.checkBoxSortInvNumber.Size = new System.Drawing.Size(181, 17);
            this.checkBoxSortInvNumber.TabIndex = 16;
            this.checkBoxSortInvNumber.Text = "Сортировать по инвертарному";
            this.checkBoxSortInvNumber.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(269, 20);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(373, 344);
            this.richTextBoxInfo.TabIndex = 17;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(215, 40);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(269, 376);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(110, 23);
            this.buttonLock.TabIndex = 19;
            this.buttonLock.Text = "Просмотреть";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // BiblWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.checkBoxSortInvNumber);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BiblWorm";
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelPeriodUse;
        private System.Windows.Forms.Label labelInvNumber;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriodUse;
        private System.Windows.Forms.NumericUpDown numericUpDownInvNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.Label labelPublishHouse;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxPublishHouse;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxReturnTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxExistence;
        private System.Windows.Forms.CheckBox checkBoxSortInvNumber;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonLock;
    }
}

