namespace FUNShare
{
    partial class FrmSupplierDetail
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
            System.Windows.Forms.Label labCity_ID;
            System.Windows.Forms.Label labTaxID;
            System.Windows.Forms.Label labSuppierName;
            System.Windows.Forms.Label labSuppierPhone;
            System.Windows.Forms.Label labEmail;
            System.Windows.Forms.Label labFax;
            System.Windows.Forms.Label labContactPerson;
            System.Windows.Forms.Label labLogo;
            System.Windows.Forms.Label labDescription;
            System.Windows.Forms.Label status_IDLabel;
            System.Windows.Forms.Label labAddress;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplierDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comCity_ID = new System.Windows.Forms.ComboBox();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.txtSuppierName = new System.Windows.Forms.TextBox();
            this.txtSuppierPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            labCity_ID = new System.Windows.Forms.Label();
            labTaxID = new System.Windows.Forms.Label();
            labSuppierName = new System.Windows.Forms.Label();
            labSuppierPhone = new System.Windows.Forms.Label();
            labEmail = new System.Windows.Forms.Label();
            labFax = new System.Windows.Forms.Label();
            labContactPerson = new System.Windows.Forms.Label();
            labLogo = new System.Windows.Forms.Label();
            labDescription = new System.Windows.Forms.Label();
            status_IDLabel = new System.Windows.Forms.Label();
            labAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCity_ID
            // 
            labCity_ID.AutoSize = true;
            labCity_ID.Location = new System.Drawing.Point(46, 148);
            labCity_ID.Name = "labCity_ID";
            labCity_ID.Size = new System.Drawing.Size(115, 30);
            labCity_ID.TabIndex = 60;
            labCity_ID.Text = "城市編號:";
            // 
            // labTaxID
            // 
            labTaxID.AutoSize = true;
            labTaxID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labTaxID.Location = new System.Drawing.Point(46, 49);
            labTaxID.Name = "labTaxID";
            labTaxID.Size = new System.Drawing.Size(126, 30);
            labTaxID.TabIndex = 37;
            labTaxID.Text = "*統一編號:";
            // 
            // labSuppierName
            // 
            labSuppierName.AutoSize = true;
            labSuppierName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labSuppierName.Location = new System.Drawing.Point(46, 97);
            labSuppierName.Name = "labSuppierName";
            labSuppierName.Size = new System.Drawing.Size(150, 30);
            labSuppierName.TabIndex = 39;
            labSuppierName.Text = "*供應商名稱:";
            // 
            // labSuppierPhone
            // 
            labSuppierPhone.AutoSize = true;
            labSuppierPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labSuppierPhone.Location = new System.Drawing.Point(46, 306);
            labSuppierPhone.Name = "labSuppierPhone";
            labSuppierPhone.Size = new System.Drawing.Size(115, 30);
            labSuppierPhone.TabIndex = 41;
            labSuppierPhone.Text = "連絡電話:";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labEmail.Location = new System.Drawing.Point(46, 200);
            labEmail.Name = "labEmail";
            labEmail.Size = new System.Drawing.Size(126, 30);
            labEmail.TabIndex = 43;
            labEmail.Text = "*電子郵件:";
            // 
            // labFax
            // 
            labFax.AutoSize = true;
            labFax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labFax.Location = new System.Drawing.Point(46, 367);
            labFax.Name = "labFax";
            labFax.Size = new System.Drawing.Size(67, 30);
            labFax.TabIndex = 47;
            labFax.Text = "傳真:";
            // 
            // labContactPerson
            // 
            labContactPerson.AutoSize = true;
            labContactPerson.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labContactPerson.Location = new System.Drawing.Point(46, 254);
            labContactPerson.Name = "labContactPerson";
            labContactPerson.Size = new System.Drawing.Size(102, 30);
            labContactPerson.TabIndex = 51;
            labContactPerson.Text = "*聯絡人:";
            // 
            // labLogo
            // 
            labLogo.AutoSize = true;
            labLogo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labLogo.Location = new System.Drawing.Point(457, 97);
            labLogo.Name = "labLogo";
            labLogo.Size = new System.Drawing.Size(115, 30);
            labLogo.TabIndex = 53;
            labLogo.Text = "廠商圖示:";
            // 
            // labDescription
            // 
            labDescription.AutoSize = true;
            labDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labDescription.Location = new System.Drawing.Point(46, 480);
            labDescription.Name = "labDescription";
            labDescription.Size = new System.Drawing.Size(67, 30);
            labDescription.TabIndex = 55;
            labDescription.Text = "備註:";
            // 
            // status_IDLabel
            // 
            status_IDLabel.AutoSize = true;
            status_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            status_IDLabel.Location = new System.Drawing.Point(451, 364);
            status_IDLabel.Name = "status_IDLabel";
            status_IDLabel.Size = new System.Drawing.Size(121, 30);
            status_IDLabel.TabIndex = 57;
            status_IDLabel.Text = "Status ID:";
            // 
            // labAddress
            // 
            labAddress.AutoSize = true;
            labAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            labAddress.Location = new System.Drawing.Point(46, 424);
            labAddress.Name = "labAddress";
            labAddress.Size = new System.Drawing.Size(139, 30);
            labAddress.TabIndex = 59;
            labAddress.Text = "供應商地址:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(labCity_ID);
            this.groupBox1.Controls.Add(this.comCity_ID);
            this.groupBox1.Controls.Add(labTaxID);
            this.groupBox1.Controls.Add(this.txtTaxID);
            this.groupBox1.Controls.Add(labSuppierName);
            this.groupBox1.Controls.Add(this.txtSuppierName);
            this.groupBox1.Controls.Add(labSuppierPhone);
            this.groupBox1.Controls.Add(this.txtSuppierPhone);
            this.groupBox1.Controls.Add(labEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(labFax);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(labContactPerson);
            this.groupBox1.Controls.Add(this.txtContactPerson);
            this.groupBox1.Controls.Add(labLogo);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(labDescription);
            this.groupBox1.Controls.Add(this.richDescription);
            this.groupBox1.Controls.Add(status_IDLabel);
            this.groupBox1.Controls.Add(labAddress);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 798);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "廠商資料表";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowse.Location = new System.Drawing.Point(670, 306);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(152, 43);
            this.btnBrowse.TabIndex = 64;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(632, 600);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(171, 75);
            this.btnModify.TabIndex = 63;
            this.btnModify.Text = "修改並儲存";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "審核通過",
            "審核未通過",
            "待審核"});
            this.comboBoxStatus.Location = new System.Drawing.Point(578, 361);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(244, 38);
            this.comboBoxStatus.TabIndex = 62;
            // 
            // comCity_ID
            // 
            this.comCity_ID.FormattingEnabled = true;
            this.comCity_ID.Location = new System.Drawing.Point(201, 145);
            this.comCity_ID.Name = "comCity_ID";
            this.comCity_ID.Size = new System.Drawing.Size(214, 38);
            this.comCity_ID.TabIndex = 61;
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(201, 46);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(214, 39);
            this.txtTaxID.TabIndex = 38;
            // 
            // txtSuppierName
            // 
            this.txtSuppierName.Location = new System.Drawing.Point(201, 94);
            this.txtSuppierName.Name = "txtSuppierName";
            this.txtSuppierName.Size = new System.Drawing.Size(214, 39);
            this.txtSuppierName.TabIndex = 40;
            // 
            // txtSuppierPhone
            // 
            this.txtSuppierPhone.Location = new System.Drawing.Point(201, 303);
            this.txtSuppierPhone.Name = "txtSuppierPhone";
            this.txtSuppierPhone.Size = new System.Drawing.Size(214, 39);
            this.txtSuppierPhone.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 39);
            this.txtEmail.TabIndex = 44;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(201, 364);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(214, 39);
            this.txtFax.TabIndex = 48;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtContactPerson.Location = new System.Drawing.Point(201, 251);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(214, 39);
            this.txtContactPerson.TabIndex = 52;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(578, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(257, 267);
            this.picLogo.TabIndex = 54;
            this.picLogo.TabStop = false;
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(201, 477);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(621, 117);
            this.richDescription.TabIndex = 56;
            this.richDescription.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(201, 421);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(621, 39);
            this.txtAddress.TabIndex = 60;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 798);
            this.panel1.TabIndex = 65;
            // 
            // FrmSupplierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 798);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSupplierDetail";
            this.Text = "FrmSupplierDetail";
            this.Load += new System.EventHandler(this.FrmSupplierDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comCity_ID;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.TextBox txtSuppierName;
        private System.Windows.Forms.TextBox txtSuppierPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}