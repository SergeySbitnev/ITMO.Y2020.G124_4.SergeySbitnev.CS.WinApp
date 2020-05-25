namespace ITMO.CS.WinApp.LabWork2.Task8.KeyPressValidatingErrorProvide
{
    partial class RegistrationForm
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
            this.labelHead = new System.Windows.Forms.Label();
            this.groupBoxRegistrationData = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.checkBoxExtended = new System.Windows.Forms.CheckBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxRegistrationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Location = new System.Drawing.Point(12, 9);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(114, 13);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Select registration type";
            // 
            // groupBoxRegistrationData
            // 
            this.groupBoxRegistrationData.Controls.Add(this.textBoxName);
            this.groupBoxRegistrationData.Controls.Add(this.textBoxPIN);
            this.groupBoxRegistrationData.Controls.Add(this.labelPIN);
            this.groupBoxRegistrationData.Controls.Add(this.labelName);
            this.groupBoxRegistrationData.Location = new System.Drawing.Point(15, 41);
            this.groupBoxRegistrationData.Name = "groupBoxRegistrationData";
            this.groupBoxRegistrationData.Size = new System.Drawing.Size(357, 148);
            this.groupBoxRegistrationData.TabIndex = 1;
            this.groupBoxRegistrationData.TabStop = false;
            this.groupBoxRegistrationData.Text = "Enter registration data";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(47, 71);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(200, 20);
            this.textBoxPIN.TabIndex = 2;
            this.textBoxPIN.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPIN_Validating);
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(6, 74);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(25, 13);
            this.labelPIN.TabIndex = 1;
            this.labelPIN.Text = "PIN";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(29, 225);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(115, 23);
            this.buttonRegistration.TabIndex = 2;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtended
            // 
            this.checkBoxExtended.AutoSize = true;
            this.checkBoxExtended.Location = new System.Drawing.Point(246, 195);
            this.checkBoxExtended.Name = "checkBoxExtended";
            this.checkBoxExtended.Size = new System.Drawing.Size(126, 17);
            this.checkBoxExtended.TabIndex = 3;
            this.checkBoxExtended.Text = "Extended capabilities";
            this.checkBoxExtended.UseVisualStyleBackColor = true;
            this.checkBoxExtended.CheckedChanged += new System.EventHandler(this.checkBoxExtended_CheckedChanged);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.checkBoxExtended);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.groupBoxRegistrationData);
            this.Controls.Add(this.labelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.groupBoxRegistrationData.ResumeLayout(false);
            this.groupBoxRegistrationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.GroupBox groupBoxRegistrationData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.CheckBox checkBoxExtended;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}

