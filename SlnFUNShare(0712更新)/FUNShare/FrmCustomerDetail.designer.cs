namespace FUNShare
{
    partial class FrmCustomerDetail
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labEmailError = new System.Windows.Forms.Label();
            this.labIDNumberError = new System.Windows.Forms.Label();
            this.labNameError = new System.Windows.Forms.Label();
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labNickName = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.labDistrict = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labBirth = new System.Windows.Forms.Label();
            this.labAllergyHistory = new System.Windows.Forms.Label();
            this.labAllergy = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labIDNumber = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnSuspension = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelAllergy.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(6, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(100, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labEmailError);
            this.groupBox1.Controls.Add(this.labIDNumberError);
            this.groupBox1.Controls.Add(this.labNameError);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.panelAllergy);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labPicture);
            this.groupBox1.Controls.Add(this.RichtxtAllergyHistory);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.labNickName);
            this.groupBox1.Controls.Add(this.labAddress);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.labDistrict);
            this.groupBox1.Controls.Add(this.comboBoxDistrict);
            this.groupBox1.Controls.Add(this.dateTimePickerBirth);
            this.groupBox1.Controls.Add(this.labBirth);
            this.groupBox1.Controls.Add(this.labAllergyHistory);
            this.groupBox1.Controls.Add(this.labAllergy);
            this.groupBox1.Controls.Add(this.labEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.labPhone);
            this.groupBox1.Controls.Add(this.labGender);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.labIDNumber);
            this.groupBox1.Controls.Add(this.txtIDNumber);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 520);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本資料";
            // 
            // labEmailError
            // 
            this.labEmailError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmailError.ForeColor = System.Drawing.Color.Red;
            this.labEmailError.Location = new System.Drawing.Point(112, 158);
            this.labEmailError.Name = "labEmailError";
            this.labEmailError.Size = new System.Drawing.Size(237, 17);
            this.labEmailError.TabIndex = 8;
            this.labEmailError.Text = "請輸入Email";
            this.labEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labIDNumberError
            // 
            this.labIDNumberError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIDNumberError.ForeColor = System.Drawing.Color.Red;
            this.labIDNumberError.Location = new System.Drawing.Point(112, 106);
            this.labIDNumberError.Name = "labIDNumberError";
            this.labIDNumberError.Size = new System.Drawing.Size(237, 17);
            this.labIDNumberError.TabIndex = 5;
            this.labIDNumberError.Text = "請輸入身分證字號";
            this.labIDNumberError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labNameError
            // 
            this.labNameError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameError.ForeColor = System.Drawing.Color.Red;
            this.labNameError.Location = new System.Drawing.Point(112, 54);
            this.labNameError.Name = "labNameError";
            this.labNameError.Size = new System.Drawing.Size(237, 17);
            this.labNameError.TabIndex = 2;
            this.labNameError.Text = "請輸入姓名";
            this.labNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(471, 261);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 28);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelAllergy
            // 
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyYes);
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyNo);
            this.panelAllergy.Location = new System.Drawing.Point(112, 387);
            this.panelAllergy.Name = "panelAllergy";
            this.panelAllergy.Size = new System.Drawing.Size(237, 29);
            this.panelAllergy.TabIndex = 27;
            // 
            // RadiobtnAllergyYes
            // 
            this.RadiobtnAllergyYes.AutoSize = true;
            this.RadiobtnAllergyYes.Location = new System.Drawing.Point(0, 1);
            this.RadiobtnAllergyYes.Name = "RadiobtnAllergyYes";
            this.RadiobtnAllergyYes.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyYes.TabIndex = 25;
            this.RadiobtnAllergyYes.TabStop = true;
            this.RadiobtnAllergyYes.Text = "是";
            this.RadiobtnAllergyYes.UseVisualStyleBackColor = true;
            this.RadiobtnAllergyYes.CheckedChanged += new System.EventHandler(this.RadiobtnAllergyYes_CheckedChanged);
            // 
            // RadiobtnAllergyNo
            // 
            this.RadiobtnAllergyNo.AutoSize = true;
            this.RadiobtnAllergyNo.Location = new System.Drawing.Point(49, 1);
            this.RadiobtnAllergyNo.Name = "RadiobtnAllergyNo";
            this.RadiobtnAllergyNo.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyNo.TabIndex = 26;
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
            this.panelGender.Location = new System.Drawing.Point(112, 213);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(237, 29);
            this.panelGender.TabIndex = 15;
            // 
            // RadiobtnMale
            // 
            this.RadiobtnMale.AutoSize = true;
            this.RadiobtnMale.Location = new System.Drawing.Point(0, 0);
            this.RadiobtnMale.Name = "RadiobtnMale";
            this.RadiobtnMale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnMale.TabIndex = 12;
            this.RadiobtnMale.Text = "男性";
            this.RadiobtnMale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnFemale
            // 
            this.RadiobtnFemale.AutoSize = true;
            this.RadiobtnFemale.Location = new System.Drawing.Point(65, 0);
            this.RadiobtnFemale.Name = "RadiobtnFemale";
            this.RadiobtnFemale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnFemale.TabIndex = 13;
            this.RadiobtnFemale.Text = "女性";
            this.RadiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnSecret
            // 
            this.RadiobtnSecret.AutoSize = true;
            this.RadiobtnSecret.Location = new System.Drawing.Point(130, 0);
            this.RadiobtnSecret.Name = "RadiobtnSecret";
            this.RadiobtnSecret.Size = new System.Drawing.Size(107, 24);
            this.RadiobtnSecret.TabIndex = 14;
            this.RadiobtnSecret.Text = "不方便透漏";
            this.RadiobtnSecret.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(355, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labPicture
            // 
            this.labPicture.Location = new System.Drawing.Point(355, 25);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(100, 20);
            this.labPicture.TabIndex = 30;
            this.labPicture.Text = "照片";
            // 
            // RichtxtAllergyHistory
            // 
            this.RichtxtAllergyHistory.Location = new System.Drawing.Point(112, 417);
            this.RichtxtAllergyHistory.Name = "RichtxtAllergyHistory";
            this.RichtxtAllergyHistory.Size = new System.Drawing.Size(455, 96);
            this.RichtxtAllergyHistory.TabIndex = 29;
            this.RichtxtAllergyHistory.Text = "";
            this.RichtxtAllergyHistory.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 352);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(455, 29);
            this.txtAddress.TabIndex = 23;
            // 
            // labNickName
            // 
            this.labNickName.Location = new System.Drawing.Point(6, 286);
            this.labNickName.Name = "labNickName";
            this.labNickName.Size = new System.Drawing.Size(100, 20);
            this.labNickName.TabIndex = 18;
            this.labNickName.Text = "暱稱";
            this.labNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAddress
            // 
            this.labAddress.Location = new System.Drawing.Point(6, 355);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(100, 20);
            this.labAddress.TabIndex = 22;
            this.labAddress.Text = "地址";
            this.labAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(112, 283);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(237, 29);
            this.txtNickName.TabIndex = 19;
            // 
            // labDistrict
            // 
            this.labDistrict.Location = new System.Drawing.Point(6, 321);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(100, 20);
            this.labDistrict.TabIndex = 20;
            this.labDistrict.Text = "行政區";
            this.labDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(112, 318);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(237, 28);
            this.comboBoxDistrict.TabIndex = 21;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(112, 248);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(237, 29);
            this.dateTimePickerBirth.TabIndex = 17;
            // 
            // labBirth
            // 
            this.labBirth.Location = new System.Drawing.Point(6, 254);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(100, 20);
            this.labBirth.TabIndex = 16;
            this.labBirth.Text = "生日";
            this.labBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAllergyHistory
            // 
            this.labAllergyHistory.Location = new System.Drawing.Point(6, 420);
            this.labAllergyHistory.Name = "labAllergyHistory";
            this.labAllergyHistory.Size = new System.Drawing.Size(100, 20);
            this.labAllergyHistory.TabIndex = 28;
            this.labAllergyHistory.Text = "過敏史";
            this.labAllergyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAllergyHistory.Visible = false;
            // 
            // labAllergy
            // 
            this.labAllergy.Location = new System.Drawing.Point(6, 390);
            this.labAllergy.Name = "labAllergy";
            this.labAllergy.Size = new System.Drawing.Size(100, 20);
            this.labAllergy.TabIndex = 24;
            this.labAllergy.Text = "過敏";
            this.labAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEmail
            // 
            this.labEmail.Location = new System.Drawing.Point(6, 129);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(100, 20);
            this.labEmail.TabIndex = 6;
            this.labEmail.Text = "Email";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 29);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // labPhone
            // 
            this.labPhone.Location = new System.Drawing.Point(6, 181);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(100, 20);
            this.labPhone.TabIndex = 9;
            this.labPhone.Text = "電話";
            this.labPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(6, 215);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(100, 20);
            this.labGender.TabIndex = 11;
            this.labGender.Text = "性別";
            this.labGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 178);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(237, 29);
            this.txtPhone.TabIndex = 10;
            // 
            // labIDNumber
            // 
            this.labIDNumber.Location = new System.Drawing.Point(6, 77);
            this.labIDNumber.Name = "labIDNumber";
            this.labIDNumber.Size = new System.Drawing.Size(100, 20);
            this.labIDNumber.TabIndex = 3;
            this.labIDNumber.Text = "身分證字號";
            this.labIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(112, 74);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(237, 29);
            this.txtIDNumber.TabIndex = 4;
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtIDNumber_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 36);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "確認修改並儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSuspension);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(802, 584);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 35;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(202, 582);
            this.treeView1.TabIndex = 34;
            // 
            // btnSuspension
            // 
            this.btnSuspension.Location = new System.Drawing.Point(12, 538);
            this.btnSuspension.Name = "btnSuspension";
            this.btnSuspension.Size = new System.Drawing.Size(136, 36);
            this.btnSuspension.TabIndex = 34;
            this.btnSuspension.Text = "停權此會員帳戶";
            this.btnSuspension.UseVisualStyleBackColor = true;
            this.btnSuspension.Click += new System.EventHandler(this.btnSuspension_Click);
            // 
            // FrmCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 584);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCustomerDetail";
            this.Text = "CustomerDetail";
            this.Load += new System.EventHandler(this.FrmCustomerDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAllergy.ResumeLayout(false);
            this.panelAllergy.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labAllergyHistory;
        private System.Windows.Forms.RadioButton RadiobtnAllergyNo;
        private System.Windows.Forms.RadioButton RadiobtnAllergyYes;
        private System.Windows.Forms.Label labAllergy;
        private System.Windows.Forms.Label labNickName;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.RichTextBox RichtxtAllergyHistory;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labDistrict;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton RadiobtnSecret;
        private System.Windows.Forms.RadioButton RadiobtnFemale;
        private System.Windows.Forms.RadioButton RadiobtnMale;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labPicture;
        private System.Windows.Forms.Panel panelAllergy;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labEmailError;
        private System.Windows.Forms.Label labIDNumberError;
        private System.Windows.Forms.Label labNameError;
        private System.Windows.Forms.Button btnSuspension;
    }
}

