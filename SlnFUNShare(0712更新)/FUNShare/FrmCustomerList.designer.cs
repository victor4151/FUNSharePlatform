namespace FUNShare
{
    partial class FrmCustomerList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labBetween = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.checkBoxSuspension = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistered = new System.Windows.Forms.CheckBox();
            this.checkBoxUnregistered = new System.Windows.Forms.CheckBox();
            this.txtAgeTo = new System.Windows.Forms.TextBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labName = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.txtAgeFrom = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labAgeRange = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.panelGender = new System.Windows.Forms.Panel();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labIDNumber = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labBetween
            // 
            this.labBetween.AutoSize = true;
            this.labBetween.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBetween.Location = new System.Drawing.Point(600, 135);
            this.labBetween.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labBetween.Name = "labBetween";
            this.labBetween.Size = new System.Drawing.Size(25, 20);
            this.labBetween.TabIndex = 36;
            this.labBetween.Text = "～";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(761, 155);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(84, 31);
            this.btnSearchCustomer.TabIndex = 33;
            this.btnSearchCustomer.Text = "查詢";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchCustomer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 555);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(761, 114);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 31);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "清除條件";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelStatus);
            this.groupBox1.Controls.Add(this.txtAgeTo);
            this.groupBox1.Controls.Add(this.comboBoxCity);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.labStatus);
            this.groupBox1.Controls.Add(this.labBetween);
            this.groupBox1.Controls.Add(this.labCity);
            this.groupBox1.Controls.Add(this.txtAgeFrom);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.labAgeRange);
            this.groupBox1.Controls.Add(this.txtIDNumber);
            this.groupBox1.Controls.Add(this.panelGender);
            this.groupBox1.Controls.Add(this.labIDNumber);
            this.groupBox1.Controls.Add(this.labEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.labGender);
            this.groupBox1.Controls.Add(this.labPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 174);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢項目";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.checkBoxSuspension);
            this.panelStatus.Controls.Add(this.checkBoxRegistered);
            this.panelStatus.Controls.Add(this.checkBoxUnregistered);
            this.panelStatus.Location = new System.Drawing.Point(489, 56);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(246, 29);
            this.panelStatus.TabIndex = 59;
            // 
            // checkBoxSuspension
            // 
            this.checkBoxSuspension.AutoSize = true;
            this.checkBoxSuspension.Checked = true;
            this.checkBoxSuspension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSuspension.Location = new System.Drawing.Point(164, 2);
            this.checkBoxSuspension.Name = "checkBoxSuspension";
            this.checkBoxSuspension.Size = new System.Drawing.Size(76, 24);
            this.checkBoxSuspension.TabIndex = 33;
            this.checkBoxSuspension.Text = "停權中";
            this.checkBoxSuspension.UseVisualStyleBackColor = true;
            this.checkBoxSuspension.CheckedChanged += new System.EventHandler(this.CheckCustomerStatus);
            // 
            // checkBoxRegistered
            // 
            this.checkBoxRegistered.AutoSize = true;
            this.checkBoxRegistered.Checked = true;
            this.checkBoxRegistered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegistered.Location = new System.Drawing.Point(0, 2);
            this.checkBoxRegistered.Name = "checkBoxRegistered";
            this.checkBoxRegistered.Size = new System.Drawing.Size(76, 24);
            this.checkBoxRegistered.TabIndex = 31;
            this.checkBoxRegistered.Text = "已註冊";
            this.checkBoxRegistered.UseVisualStyleBackColor = true;
            this.checkBoxRegistered.CheckedChanged += new System.EventHandler(this.CheckCustomerStatus);
            // 
            // checkBoxUnregistered
            // 
            this.checkBoxUnregistered.AutoSize = true;
            this.checkBoxUnregistered.Checked = true;
            this.checkBoxUnregistered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUnregistered.Location = new System.Drawing.Point(82, 2);
            this.checkBoxUnregistered.Name = "checkBoxUnregistered";
            this.checkBoxUnregistered.Size = new System.Drawing.Size(76, 24);
            this.checkBoxUnregistered.TabIndex = 32;
            this.checkBoxUnregistered.Text = "未註冊";
            this.checkBoxUnregistered.UseVisualStyleBackColor = true;
            this.checkBoxUnregistered.CheckedChanged += new System.EventHandler(this.CheckCustomerStatus);
            // 
            // txtAgeTo
            // 
            this.txtAgeTo.Location = new System.Drawing.Point(632, 132);
            this.txtAgeTo.Name = "txtAgeTo";
            this.txtAgeTo.Size = new System.Drawing.Size(103, 29);
            this.txtAgeTo.TabIndex = 56;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(489, 22);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(246, 28);
            this.comboBoxCity.TabIndex = 57;
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(20, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(100, 20);
            this.labName.TabIndex = 37;
            this.labName.Text = "姓名";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labStatus
            // 
            this.labStatus.Location = new System.Drawing.Point(383, 60);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(100, 20);
            this.labStatus.TabIndex = 58;
            this.labStatus.Text = "狀態";
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCity
            // 
            this.labCity.Location = new System.Drawing.Point(383, 25);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(100, 20);
            this.labCity.TabIndex = 57;
            this.labCity.Text = "城市";
            this.labCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAgeFrom
            // 
            this.txtAgeFrom.Location = new System.Drawing.Point(489, 132);
            this.txtAgeFrom.Name = "txtAgeFrom";
            this.txtAgeFrom.Size = new System.Drawing.Size(103, 29);
            this.txtAgeFrom.TabIndex = 54;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 29);
            this.txtName.TabIndex = 38;
            // 
            // labAgeRange
            // 
            this.labAgeRange.Location = new System.Drawing.Point(383, 135);
            this.labAgeRange.Name = "labAgeRange";
            this.labAgeRange.Size = new System.Drawing.Size(100, 20);
            this.labAgeRange.TabIndex = 53;
            this.labAgeRange.Text = "年齡區間";
            this.labAgeRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(126, 57);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(246, 29);
            this.txtIDNumber.TabIndex = 40;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.checkBoxMale);
            this.panelGender.Controls.Add(this.checkBoxFemale);
            this.panelGender.Location = new System.Drawing.Point(489, 93);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(246, 29);
            this.panelGender.TabIndex = 52;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Location = new System.Drawing.Point(0, 1);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(60, 24);
            this.checkBoxMale.TabIndex = 29;
            this.checkBoxMale.Text = "男性";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.CheckCustomerGender);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Checked = true;
            this.checkBoxFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFemale.Location = new System.Drawing.Point(66, 1);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(60, 24);
            this.checkBoxFemale.TabIndex = 30;
            this.checkBoxFemale.Text = "女性";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.CheckCustomerGender);
            // 
            // labIDNumber
            // 
            this.labIDNumber.Location = new System.Drawing.Point(20, 60);
            this.labIDNumber.Name = "labIDNumber";
            this.labIDNumber.Size = new System.Drawing.Size(100, 20);
            this.labIDNumber.TabIndex = 39;
            this.labIDNumber.Text = "身分證字號";
            this.labIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEmail
            // 
            this.labEmail.Location = new System.Drawing.Point(20, 95);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(100, 20);
            this.labEmail.TabIndex = 45;
            this.labEmail.Text = "Email";
            this.labEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(246, 29);
            this.txtPhone.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 29);
            this.txtEmail.TabIndex = 44;
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(383, 95);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(100, 20);
            this.labGender.TabIndex = 42;
            this.labGender.Text = "性別";
            this.labGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPhone
            // 
            this.labPhone.Location = new System.Drawing.Point(20, 130);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(100, 20);
            this.labPhone.TabIndex = 43;
            this.labPhone.Text = "電話";
            this.labPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 555);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCustomerList";
            this.Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labBetween;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labAgeRange;
        private System.Windows.Forms.TextBox txtAgeFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtAgeTo;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxSuspension;
        private System.Windows.Forms.CheckBox checkBoxRegistered;
        private System.Windows.Forms.CheckBox checkBoxUnregistered;
        private System.Windows.Forms.Button btnClear;
    }
}