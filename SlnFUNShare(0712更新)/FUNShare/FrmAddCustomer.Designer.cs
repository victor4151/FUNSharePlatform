namespace FUNShare
{
    partial class FrmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCustomer));
            this.btnAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSurePasswordError = new System.Windows.Forms.Label();
            this.labPasswordError = new System.Windows.Forms.Label();
            this.labEmailError = new System.Windows.Forms.Label();
            this.labSurePassword = new System.Windows.Forms.Label();
            this.labIDNumberError = new System.Windows.Forms.Label();
            this.txtSurePassword = new System.Windows.Forms.TextBox();
            this.labNameError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panelAllergy.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(613, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 36);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "確認註冊";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSurePasswordError);
            this.groupBox1.Controls.Add(this.labPasswordError);
            this.groupBox1.Controls.Add(this.labEmailError);
            this.groupBox1.Controls.Add(this.labSurePassword);
            this.groupBox1.Controls.Add(this.labIDNumberError);
            this.groupBox1.Controls.Add(this.txtSurePassword);
            this.groupBox1.Controls.Add(this.labNameError);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.labPassword);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 491);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本資料";
            // 
            // labSurePasswordError
            // 
            this.labSurePasswordError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSurePasswordError.ForeColor = System.Drawing.Color.Red;
            this.labSurePasswordError.Location = new System.Drawing.Point(365, 221);
            this.labSurePasswordError.Name = "labSurePasswordError";
            this.labSurePasswordError.Size = new System.Drawing.Size(200, 17);
            this.labSurePasswordError.TabIndex = 16;
            this.labSurePasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPasswordError
            // 
            this.labPasswordError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labPasswordError.Location = new System.Drawing.Point(365, 186);
            this.labPasswordError.Name = "labPasswordError";
            this.labPasswordError.Size = new System.Drawing.Size(200, 17);
            this.labPasswordError.TabIndex = 13;
            this.labPasswordError.Text = "請輸入密碼";
            this.labPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labEmailError
            // 
            this.labEmailError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmailError.ForeColor = System.Drawing.Color.Red;
            this.labEmailError.Location = new System.Drawing.Point(365, 116);
            this.labEmailError.Name = "labEmailError";
            this.labEmailError.Size = new System.Drawing.Size(200, 17);
            this.labEmailError.TabIndex = 8;
            this.labEmailError.Text = "請輸入Email";
            this.labEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSurePassword
            // 
            this.labSurePassword.Location = new System.Drawing.Point(16, 217);
            this.labSurePassword.Name = "labSurePassword";
            this.labSurePassword.Size = new System.Drawing.Size(100, 20);
            this.labSurePassword.TabIndex = 14;
            this.labSurePassword.Text = "確認密碼";
            this.labSurePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labIDNumberError
            // 
            this.labIDNumberError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIDNumberError.ForeColor = System.Drawing.Color.Red;
            this.labIDNumberError.Location = new System.Drawing.Point(365, 81);
            this.labIDNumberError.Name = "labIDNumberError";
            this.labIDNumberError.Size = new System.Drawing.Size(200, 17);
            this.labIDNumberError.TabIndex = 5;
            this.labIDNumberError.Text = "請輸入身分證字號";
            this.labIDNumberError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSurePassword
            // 
            this.txtSurePassword.Location = new System.Drawing.Point(122, 214);
            this.txtSurePassword.Name = "txtSurePassword";
            this.txtSurePassword.PasswordChar = '*';
            this.txtSurePassword.Size = new System.Drawing.Size(237, 29);
            this.txtSurePassword.TabIndex = 15;
            this.txtSurePassword.TextChanged += new System.EventHandler(this.txtSurePassword_TextChanged);
            // 
            // labNameError
            // 
            this.labNameError.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameError.ForeColor = System.Drawing.Color.Red;
            this.labNameError.Location = new System.Drawing.Point(365, 46);
            this.labNameError.Name = "labNameError";
            this.labNameError.Size = new System.Drawing.Size(200, 17);
            this.labNameError.TabIndex = 2;
            this.labNameError.Text = "請輸入姓名";
            this.labNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(237, 29);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labPassword
            // 
            this.labPassword.Location = new System.Drawing.Point(16, 182);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(100, 20);
            this.labPassword.TabIndex = 11;
            this.labPassword.Text = "密碼";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(616, 213);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 28);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelAllergy
            // 
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyYes);
            this.panelAllergy.Controls.Add(this.RadiobtnAllergyNo);
            this.panelAllergy.Location = new System.Drawing.Point(122, 355);
            this.panelAllergy.Name = "panelAllergy";
            this.panelAllergy.Size = new System.Drawing.Size(237, 29);
            this.panelAllergy.TabIndex = 33;
            // 
            // RadiobtnAllergyYes
            // 
            this.RadiobtnAllergyYes.AutoSize = true;
            this.RadiobtnAllergyYes.Location = new System.Drawing.Point(0, 1);
            this.RadiobtnAllergyYes.Name = "RadiobtnAllergyYes";
            this.RadiobtnAllergyYes.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyYes.TabIndex = 31;
            this.RadiobtnAllergyYes.Text = "是";
            this.RadiobtnAllergyYes.UseVisualStyleBackColor = true;
            this.RadiobtnAllergyYes.CheckedChanged += new System.EventHandler(this.RadiobtnAllergyYes_CheckedChanged);
            // 
            // RadiobtnAllergyNo
            // 
            this.RadiobtnAllergyNo.AutoSize = true;
            this.RadiobtnAllergyNo.Checked = true;
            this.RadiobtnAllergyNo.Location = new System.Drawing.Point(49, 1);
            this.RadiobtnAllergyNo.Name = "RadiobtnAllergyNo";
            this.RadiobtnAllergyNo.Size = new System.Drawing.Size(43, 24);
            this.RadiobtnAllergyNo.TabIndex = 32;
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
            this.panelGender.Location = new System.Drawing.Point(122, 249);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(237, 29);
            this.panelGender.TabIndex = 21;
            // 
            // RadiobtnMale
            // 
            this.RadiobtnMale.AutoSize = true;
            this.RadiobtnMale.Location = new System.Drawing.Point(0, 0);
            this.RadiobtnMale.Name = "RadiobtnMale";
            this.RadiobtnMale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnMale.TabIndex = 18;
            this.RadiobtnMale.Text = "男性";
            this.RadiobtnMale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnFemale
            // 
            this.RadiobtnFemale.AutoSize = true;
            this.RadiobtnFemale.Location = new System.Drawing.Point(65, 0);
            this.RadiobtnFemale.Name = "RadiobtnFemale";
            this.RadiobtnFemale.Size = new System.Drawing.Size(59, 24);
            this.RadiobtnFemale.TabIndex = 19;
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
            this.RadiobtnSecret.TabIndex = 20;
            this.RadiobtnSecret.TabStop = true;
            this.RadiobtnSecret.Text = "不方便透漏";
            this.RadiobtnSecret.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labPicture
            // 
            this.labPicture.Location = new System.Drawing.Point(570, 42);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(89, 20);
            this.labPicture.TabIndex = 36;
            this.labPicture.Text = "照片";
            // 
            // RichtxtAllergyHistory
            // 
            this.RichtxtAllergyHistory.Location = new System.Drawing.Point(122, 385);
            this.RichtxtAllergyHistory.Name = "RichtxtAllergyHistory";
            this.RichtxtAllergyHistory.Size = new System.Drawing.Size(585, 96);
            this.RichtxtAllergyHistory.TabIndex = 35;
            this.RichtxtAllergyHistory.Text = "";
            this.RichtxtAllergyHistory.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 320);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(585, 29);
            this.txtAddress.TabIndex = 29;
            // 
            // labNickName
            // 
            this.labNickName.Location = new System.Drawing.Point(364, 253);
            this.labNickName.Name = "labNickName";
            this.labNickName.Size = new System.Drawing.Size(100, 20);
            this.labNickName.TabIndex = 22;
            this.labNickName.Text = "暱稱";
            this.labNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAddress
            // 
            this.labAddress.Location = new System.Drawing.Point(16, 323);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(100, 20);
            this.labAddress.TabIndex = 28;
            this.labAddress.Text = "地址";
            this.labAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(470, 248);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(237, 29);
            this.txtNickName.TabIndex = 23;
            // 
            // labDistrict
            // 
            this.labDistrict.Location = new System.Drawing.Point(15, 287);
            this.labDistrict.Name = "labDistrict";
            this.labDistrict.Size = new System.Drawing.Size(100, 20);
            this.labDistrict.TabIndex = 24;
            this.labDistrict.Text = "行政區";
            this.labDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(122, 286);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(237, 28);
            this.comboBoxDistrict.TabIndex = 25;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(470, 283);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(237, 29);
            this.dateTimePickerBirth.TabIndex = 27;
            // 
            // labBirth
            // 
            this.labBirth.Location = new System.Drawing.Point(364, 289);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(100, 20);
            this.labBirth.TabIndex = 26;
            this.labBirth.Text = "生日";
            this.labBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAllergyHistory
            // 
            this.labAllergyHistory.Location = new System.Drawing.Point(16, 388);
            this.labAllergyHistory.Name = "labAllergyHistory";
            this.labAllergyHistory.Size = new System.Drawing.Size(100, 20);
            this.labAllergyHistory.TabIndex = 34;
            this.labAllergyHistory.Text = "過敏史";
            this.labAllergyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAllergyHistory.Visible = false;
            // 
            // labAllergy
            // 
            this.labAllergy.Location = new System.Drawing.Point(16, 357);
            this.labAllergy.Name = "labAllergy";
            this.labAllergy.Size = new System.Drawing.Size(100, 20);
            this.labAllergy.TabIndex = 30;
            this.labAllergy.Text = "過敏";
            this.labAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEmail
            // 
            this.labEmail.Location = new System.Drawing.Point(16, 112);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(100, 20);
            this.labEmail.TabIndex = 6;
            this.labEmail.Text = "Email";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 29);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // labPhone
            // 
            this.labPhone.Location = new System.Drawing.Point(16, 147);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(100, 20);
            this.labPhone.TabIndex = 9;
            this.labPhone.Text = "電話";
            this.labPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(16, 251);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(100, 20);
            this.labGender.TabIndex = 17;
            this.labGender.Text = "性別";
            this.labGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(237, 29);
            this.txtPhone.TabIndex = 10;
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
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAddCustomer";
            this.Text = "FrmAddCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAllergy.ResumeLayout(false);
            this.panelAllergy.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSurePassword;
        private System.Windows.Forms.TextBox txtSurePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labPassword;
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
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labNickName;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label labDistrict;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labAllergyHistory;
        private System.Windows.Forms.Label labAllergy;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labSurePasswordError;
        private System.Windows.Forms.Label labPasswordError;
        private System.Windows.Forms.Label labEmailError;
        private System.Windows.Forms.Label labIDNumberError;
        private System.Windows.Forms.Label labNameError;
    }
}