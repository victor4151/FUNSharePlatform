namespace FUNShare
{
    partial class FrmAddRelatives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRelatives));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labIDNumberError = new System.Windows.Forms.Label();
            this.labNameError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadiobtnParent = new System.Windows.Forms.RadioButton();
            this.RadiobtnChild = new System.Windows.Forms.RadioButton();
            this.labRelatives = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelAllergy = new System.Windows.Forms.Panel();
            this.RadiobtnAllergyYes = new System.Windows.Forms.RadioButton();
            this.RadiobtnAllergyNo = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.RadiobtnMale = new System.Windows.Forms.RadioButton();
            this.RadiobtnFemale = new System.Windows.Forms.RadioButton();
            this.RadiobtnSecret = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labPicture = new System.Windows.Forms.Label();
            this.RichtxtAllergyHistory = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labBirth = new System.Windows.Forms.Label();
            this.labAllergyHistory = new System.Windows.Forms.Label();
            this.labAllergy = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labIDNumber = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddRelatives = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAllergy.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labIDNumberError);
            this.groupBox1.Controls.Add(this.labNameError);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labRelatives);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.panelAllergy);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labPicture);
            this.groupBox1.Controls.Add(this.RichtxtAllergyHistory);
            this.groupBox1.Controls.Add(this.dateTimePickerBirth);
            this.groupBox1.Controls.Add(this.labBirth);
            this.groupBox1.Controls.Add(this.labAllergyHistory);
            this.groupBox1.Controls.Add(this.labAllergy);
            this.groupBox1.Controls.Add(this.labGender);
            this.groupBox1.Controls.Add(this.labIDNumber);
            this.groupBox1.Controls.Add(this.txtIDNumber);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 355);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本資料";
            // 
            // labIDNumberError
            // 
            this.labIDNumberError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIDNumberError.ForeColor = System.Drawing.Color.Red;
            this.labIDNumberError.Location = new System.Drawing.Point(365, 81);
            this.labIDNumberError.Name = "labIDNumberError";
            this.labIDNumberError.Size = new System.Drawing.Size(187, 17);
            this.labIDNumberError.TabIndex = 5;
            this.labIDNumberError.Text = "請輸入身分證字號";
            this.labIDNumberError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labNameError
            // 
            this.labNameError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameError.ForeColor = System.Drawing.Color.Red;
            this.labNameError.Location = new System.Drawing.Point(365, 46);
            this.labNameError.Name = "labNameError";
            this.labNameError.Size = new System.Drawing.Size(187, 17);
            this.labNameError.TabIndex = 2;
            this.labNameError.Text = "請輸入姓名";
            this.labNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadiobtnParent);
            this.panel1.Controls.Add(this.RadiobtnChild);
            this.panel1.Location = new System.Drawing.Point(122, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 29);
            this.panel1.TabIndex = 14;
            // 
            // RadiobtnParent
            // 
            this.RadiobtnParent.AutoSize = true;
            this.RadiobtnParent.Location = new System.Drawing.Point(0, 0);
            this.RadiobtnParent.Name = "RadiobtnParent";
            this.RadiobtnParent.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnParent.TabIndex = 12;
            this.RadiobtnParent.Text = "父母";
            this.RadiobtnParent.UseVisualStyleBackColor = true;
            // 
            // RadiobtnChild
            // 
            this.RadiobtnChild.AutoSize = true;
            this.RadiobtnChild.Checked = true;
            this.RadiobtnChild.Location = new System.Drawing.Point(65, 0);
            this.RadiobtnChild.Name = "RadiobtnChild";
            this.RadiobtnChild.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnChild.TabIndex = 13;
            this.RadiobtnChild.TabStop = true;
            this.RadiobtnChild.Text = "孩子";
            this.RadiobtnChild.UseVisualStyleBackColor = true;
            // 
            // labRelatives
            // 
            this.labRelatives.Location = new System.Drawing.Point(16, 146);
            this.labRelatives.Name = "labRelatives";
            this.labRelatives.Size = new System.Drawing.Size(100, 20);
            this.labRelatives.TabIndex = 11;
            this.labRelatives.Text = "與您的關係";
            this.labRelatives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(611, 208);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 28);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelAllergy
            // 
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyYes);
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyNo);
            this.panelAllergy.Location = new System.Drawing.Point(122, 214);
            this.panelAllergy.Name = "panelAllergy";
            this.panelAllergy.Size = new System.Drawing.Size(237, 29);
            this.panelAllergy.TabIndex = 20;
            // 
            // RadiobtnAllergyYes
            // 
            this.RadiobtnAllergyYes.AutoSize = true;
            this.RadiobtnAllergyYes.Location = new System.Drawing.Point(0, 1);
            this.RadiobtnAllergyYes.Name = "RadiobtnAllergyYes";
            this.RadiobtnAllergyYes.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyYes.TabIndex = 18;
            this.RadiobtnAllergyYes.Text = "是";
            this.RadiobtnAllergyYes.UseVisualStyleBackColor = true;
            this.RadiobtnAllergyYes.Click += new System.EventHandler(this.RadiobtnAllergyYes_CheckedChanged);
            // 
            // RadiobtnAllergyNo
            // 
            this.RadiobtnAllergyNo.AutoSize = true;
            this.RadiobtnAllergyNo.Checked = true;
            this.RadiobtnAllergyNo.Location = new System.Drawing.Point(49, 1);
            this.RadiobtnAllergyNo.Name = "RadiobtnAllergyNo";
            this.RadiobtnAllergyNo.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyNo.TabIndex = 19;
            this.RadiobtnAllergyNo.TabStop = true;
            this.RadiobtnAllergyNo.Text = "否";
            this.RadiobtnAllergyNo.UseVisualStyleBackColor = true;
            this.RadiobtnAllergyNo.CheckedChanged += new System.EventHandler(this.RadiobtnAllergyNo_CheckedChanged);
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.RadiobtnMale);
            this.panelGender.Controls.Add(this.RadiobtnFemale);
            this.panelGender.Controls.Add(this.RadiobtnSecret);
            this.panelGender.Location = new System.Drawing.Point(122, 109);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(237, 29);
            this.panelGender.TabIndex = 10;
            // 
            // RadiobtnMale
            // 
            this.RadiobtnMale.AutoSize = true;
            this.RadiobtnMale.Location = new System.Drawing.Point(0, 0);
            this.RadiobtnMale.Name = "RadiobtnMale";
            this.RadiobtnMale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnMale.TabIndex = 7;
            this.RadiobtnMale.Text = "男性";
            this.RadiobtnMale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnFemale
            // 
            this.RadiobtnFemale.AutoSize = true;
            this.RadiobtnFemale.Location = new System.Drawing.Point(65, 0);
            this.RadiobtnFemale.Name = "RadiobtnFemale";
            this.RadiobtnFemale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnFemale.TabIndex = 8;
            this.RadiobtnFemale.Text = "女性";
            this.RadiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnSecret
            // 
            this.RadiobtnSecret.AutoSize = true;
            this.RadiobtnSecret.Checked = true;
            this.RadiobtnSecret.Location = new System.Drawing.Point(130, 0);
            this.RadiobtnSecret.Name = "RadiobtnSecret";
            this.RadiobtnSecret.Size = new System.Drawing.Size(107, 24);
            this.RadiobtnSecret.TabIndex = 9;
            this.RadiobtnSecret.TabStop = true;
            this.RadiobtnSecret.Text = "不方便透漏";
            this.RadiobtnSecret.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labPicture
            // 
            this.labPicture.Location = new System.Drawing.Point(558, 43);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(100, 20);
            this.labPicture.TabIndex = 23;
            this.labPicture.Text = "照片";
            // 
            // RichtxtAllergyHistory
            // 
            this.RichtxtAllergyHistory.Location = new System.Drawing.Point(122, 249);
            this.RichtxtAllergyHistory.Name = "RichtxtAllergyHistory";
            this.RichtxtAllergyHistory.Size = new System.Drawing.Size(581, 96);
            this.RichtxtAllergyHistory.TabIndex = 22;
            this.RichtxtAllergyHistory.Text = "";
            this.RichtxtAllergyHistory.Visible = false;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(122, 179);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(237, 29);
            this.dateTimePickerBirth.TabIndex = 16;
            // 
            // labBirth
            // 
            this.labBirth.Location = new System.Drawing.Point(16, 185);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(100, 20);
            this.labBirth.TabIndex = 15;
            this.labBirth.Text = "生日";
            this.labBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAllergyHistory
            // 
            this.labAllergyHistory.Location = new System.Drawing.Point(16, 252);
            this.labAllergyHistory.Name = "labAllergyHistory";
            this.labAllergyHistory.Size = new System.Drawing.Size(100, 20);
            this.labAllergyHistory.TabIndex = 21;
            this.labAllergyHistory.Text = "過敏史";
            this.labAllergyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAllergyHistory.Visible = false;
            // 
            // labAllergy
            // 
            this.labAllergy.Location = new System.Drawing.Point(16, 216);
            this.labAllergy.Name = "labAllergy";
            this.labAllergy.Size = new System.Drawing.Size(100, 20);
            this.labAllergy.TabIndex = 17;
            this.labAllergy.Text = "過敏";
            this.labAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(16, 111);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(100, 20);
            this.labGender.TabIndex = 6;
            this.labGender.Text = "性別";
            this.labGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labIDNumber
            // 
            this.labIDNumber.Location = new System.Drawing.Point(16, 77);
            this.labIDNumber.Name = "labIDNumber";
            this.labIDNumber.Size = new System.Drawing.Size(100, 20);
            this.labIDNumber.TabIndex = 3;
            this.labIDNumber.Text = "身分證字號";
            this.labIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(122, 74);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(237, 29);
            this.txtIDNumber.TabIndex = 4;
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtIDNumber_TextChanged);
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(16, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(100, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnAddRelatives
            // 
            this.btnAddRelatives.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddRelatives.Location = new System.Drawing.Point(588, 373);
            this.btnAddRelatives.Name = "btnAddRelatives";
            this.btnAddRelatives.Size = new System.Drawing.Size(136, 36);
            this.btnAddRelatives.TabIndex = 26;
            this.btnAddRelatives.Text = "確認新增";
            this.btnAddRelatives.UseVisualStyleBackColor = true;
            this.btnAddRelatives.Click += new System.EventHandler(this.btnAddRelatives_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(446, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddRelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(731, 415);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddRelatives);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAddRelatives";
            this.Text = "FrmAddRelatives";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAllergy.ResumeLayout(false);
            this.panelAllergy.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelAllergy;
        private System.Windows.Forms.RadioButton RadiobtnAllergyYes;
        private System.Windows.Forms.RadioButton RadiobtnAllergyNo;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton RadiobtnMale;
        private System.Windows.Forms.RadioButton RadiobtnFemale;
        private System.Windows.Forms.RadioButton RadiobtnSecret;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labPicture;
        private System.Windows.Forms.RichTextBox RichtxtAllergyHistory;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labAllergyHistory;
        private System.Windows.Forms.Label labAllergy;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddRelatives;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadiobtnParent;
        private System.Windows.Forms.RadioButton RadiobtnChild;
        private System.Windows.Forms.Label labRelatives;
        private System.Windows.Forms.Label labIDNumberError;
        private System.Windows.Forms.Label labNameError;
        private System.Windows.Forms.Button btnCancel;
    }
}