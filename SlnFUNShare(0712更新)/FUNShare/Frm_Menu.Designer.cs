namespace FUNShare
{
    partial class Frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMember = new System.Windows.Forms.ToolStripButton();
            this.btnSupplier = new System.Windows.Forms.ToolStripButton();
            this.btnProduct = new System.Windows.Forms.ToolStripButton();
            this.btnOrder = new System.Windows.Forms.ToolStripButton();
            this.btnDiscount = new System.Windows.Forms.ToolStripButton();
            this.btnMarketing = new System.Windows.Forms.ToolStripButton();
            this.brnReport = new System.Windows.Forms.ToolStripButton();
            this.btnLeave = new System.Windows.Forms.ToolStripButton();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.廠商資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.廠商資料ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.商品資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折扣設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行銷管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.視窗ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 視窗ToolStripMenuItem
            // 
            this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
            this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.視窗ToolStripMenuItem.Text = "視窗";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMember,
            this.btnSupplier,
            this.btnProduct,
            this.btnOrder,
            this.btnDiscount,
            this.btnMarketing,
            this.brnReport,
            this.btnLeave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMember
            // 
            this.btnMember.Image = global::FUNShare.Properties.Resources.member;
            this.btnMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(67, 36);
            this.btnMember.Text = "會員";
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = global::FUNShare.Properties.Resources.supplier;
            this.btnSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(67, 36);
            this.btnSupplier.Text = "廠商";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::FUNShare.Properties.Resources.product;
            this.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(67, 36);
            this.btnProduct.Text = "產品";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::FUNShare.Properties.Resources.order;
            this.btnOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(67, 36);
            this.btnOrder.Text = "訂單";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Image = global::FUNShare.Properties.Resources.discount;
            this.btnDiscount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(91, 36);
            this.btnDiscount.Text = "折扣設定";
            // 
            // btnMarketing
            // 
            this.btnMarketing.Image = global::FUNShare.Properties.Resources.marketing;
            this.btnMarketing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(67, 36);
            this.btnMarketing.Text = "行銷";
            // 
            // brnReport
            // 
            this.brnReport.Image = global::FUNShare.Properties.Resources.report;
            this.brnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brnReport.Name = "brnReport";
            this.brnReport.Size = new System.Drawing.Size(67, 36);
            this.brnReport.Text = "報表";
            this.brnReport.Click += new System.EventHandler(this.brnReport_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Image = global::FUNShare.Properties.Resources.leave;
            this.btnLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(67, 36);
            this.btnLeave.Text = "離開";
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.廠商資料ToolStripMenuItem,
            this.廠商資料ToolStripMenuItem1,
            this.商品資料ToolStripMenuItem,
            this.訂單資料ToolStripMenuItem,
            this.折扣設定ToolStripMenuItem,
            this.行銷管理ToolStripMenuItem,
            this.toolStripSeparator1,
            this.離開ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.all;
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // 廠商資料ToolStripMenuItem
            // 
            this.廠商資料ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.member;
            this.廠商資料ToolStripMenuItem.Name = "廠商資料ToolStripMenuItem";
            this.廠商資料ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.廠商資料ToolStripMenuItem.Text = "會員資料";
            // 
            // 廠商資料ToolStripMenuItem1
            // 
            this.廠商資料ToolStripMenuItem1.Image = global::FUNShare.Properties.Resources.supplier;
            this.廠商資料ToolStripMenuItem1.Name = "廠商資料ToolStripMenuItem1";
            this.廠商資料ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.廠商資料ToolStripMenuItem1.Text = "廠商資料";
            // 
            // 商品資料ToolStripMenuItem
            // 
            this.商品資料ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.product;
            this.商品資料ToolStripMenuItem.Name = "商品資料ToolStripMenuItem";
            this.商品資料ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.商品資料ToolStripMenuItem.Text = "產品資料";
            // 
            // 訂單資料ToolStripMenuItem
            // 
            this.訂單資料ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.order;
            this.訂單資料ToolStripMenuItem.Name = "訂單資料ToolStripMenuItem";
            this.訂單資料ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.訂單資料ToolStripMenuItem.Text = "訂單資料";
            // 
            // 折扣設定ToolStripMenuItem
            // 
            this.折扣設定ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.discount;
            this.折扣設定ToolStripMenuItem.Name = "折扣設定ToolStripMenuItem";
            this.折扣設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.折扣設定ToolStripMenuItem.Text = "折扣設定";
            // 
            // 行銷管理ToolStripMenuItem
            // 
            this.行銷管理ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.marketing;
            this.行銷管理ToolStripMenuItem.Name = "行銷管理ToolStripMenuItem";
            this.行銷管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.行銷管理ToolStripMenuItem.Text = "行銷管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Image = global::FUNShare.Properties.Resources.leave;
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.離開ToolStripMenuItem.Text = "離開";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMember;
        private System.Windows.Forms.ToolStripButton btnSupplier;
        private System.Windows.Forms.ToolStripButton btnProduct;
        private System.Windows.Forms.ToolStripButton btnOrder;
        private System.Windows.Forms.ToolStripButton btnDiscount;
        private System.Windows.Forms.ToolStripButton btnMarketing;
        private System.Windows.Forms.ToolStripButton btnLeave;
        private System.Windows.Forms.ToolStripMenuItem 廠商資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 廠商資料ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 商品資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折扣設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行銷管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton brnReport;
    }
}

