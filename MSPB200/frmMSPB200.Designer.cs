namespace MSPB200.MSPB200
{
    partial class frmMSPB200
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.StaffName = new System.Windows.Forms.Label();
            this.lblRegistDate = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.header0 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.Label();
            this.registCnt = new System.Windows.Forms.Label();
            this.lblRegistCount = new System.Windows.Forms.Label();
            this.lblRegistCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtControlNo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPB10 = new System.Windows.Forms.Label();
            this.labelPB9 = new System.Windows.Forms.Label();
            this.labelPB8 = new System.Windows.Forms.Label();
            this.labelPB7 = new System.Windows.Forms.Label();
            this.labelPB6 = new System.Windows.Forms.Label();
            this.labelPB5 = new System.Windows.Forms.Label();
            this.labelPB4 = new System.Windows.Forms.Label();
            this.labelPB3 = new System.Windows.Forms.Label();
            this.labelPB2 = new System.Windows.Forms.Label();
            this.checkBoxPB4 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB5 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB6 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB7 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB10 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxPB1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB9 = new System.Windows.Forms.CheckBox();
            this.checkBoxPB8 = new System.Windows.Forms.CheckBox();
            this.labelPB1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtETC = new System.Windows.Forms.TextBox();
            this.labelETC = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxETC = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegistDate = new System.Windows.Forms.TextBox();
            this.picBoxQRCode = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStaffName
            // 
            this.txtStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaffName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStaffName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtStaffName.ForeColor = System.Drawing.Color.Black;
            this.txtStaffName.Location = new System.Drawing.Point(515, 117);
            this.txtStaffName.MaxLength = 10;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(173, 31);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_StaffName_KeyDown);
            // 
            // btnRegist
            // 
            this.btnRegist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegist.Enabled = false;
            this.btnRegist.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRegist.ForeColor = System.Drawing.Color.Black;
            this.btnRegist.Location = new System.Drawing.Point(490, 579);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(151, 34);
            this.btnRegist.TabIndex = 7;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // End
            // 
            this.End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.End.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.End.ForeColor = System.Drawing.Color.Black;
            this.End.Location = new System.Drawing.Point(32, 579);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(151, 34);
            this.End.TabIndex = 6;
            this.End.Text = "終了";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // StaffName
            // 
            this.StaffName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StaffName.ForeColor = System.Drawing.Color.Black;
            this.StaffName.Location = new System.Drawing.Point(384, 117);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(125, 31);
            this.StaffName.TabIndex = 17;
            this.StaffName.Text = "担当者名";
            this.StaffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistDate
            // 
            this.lblRegistDate.AutoSize = true;
            this.lblRegistDate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRegistDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegistDate.Location = new System.Drawing.Point(58, 119);
            this.lblRegistDate.Name = "lblRegistDate";
            this.lblRegistDate.Size = new System.Drawing.Size(58, 24);
            this.lblRegistDate.TabIndex = 22;
            this.lblRegistDate.Text = "登録日";
            // 
            // panelTitle
            // 
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.header0);
            this.panelTitle.Controls.Add(this.header1);
            this.panelTitle.Location = new System.Drawing.Point(9, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(696, 100);
            this.panelTitle.TabIndex = 25;
            // 
            // header0
            // 
            this.header0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header0.AutoSize = true;
            this.header0.BackColor = System.Drawing.Color.Transparent;
            this.header0.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.header0.ForeColor = System.Drawing.Color.Black;
            this.header0.Location = new System.Drawing.Point(223, 15);
            this.header0.Name = "header0";
            this.header0.Size = new System.Drawing.Size(258, 36);
            this.header0.TabIndex = 0;
            this.header0.Text = "MS　私物返却管理DB";
            // 
            // header1
            // 
            this.header1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header1.AutoSize = true;
            this.header1.BackColor = System.Drawing.Color.Transparent;
            this.header1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.header1.ForeColor = System.Drawing.Color.Black;
            this.header1.Location = new System.Drawing.Point(285, 54);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(111, 36);
            this.header1.TabIndex = 0;
            this.header1.Text = "私物登録";
            // 
            // registCnt
            // 
            this.registCnt.Enabled = false;
            this.registCnt.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registCnt.Location = new System.Drawing.Point(262, 139);
            this.registCnt.Name = "registCnt";
            this.registCnt.Size = new System.Drawing.Size(111, 24);
            this.registCnt.TabIndex = 27;
            // 
            // lblRegistCount
            // 
            this.lblRegistCount.AutoSize = true;
            this.lblRegistCount.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRegistCount.ForeColor = System.Drawing.Color.Black;
            this.lblRegistCount.Location = new System.Drawing.Point(218, 119);
            this.lblRegistCount.Name = "lblRegistCount";
            this.lblRegistCount.Size = new System.Drawing.Size(74, 24);
            this.lblRegistCount.TabIndex = 26;
            this.lblRegistCount.Text = "登録件数";
            // 
            // lblRegistCnt
            // 
            this.lblRegistCnt.BackColor = System.Drawing.SystemColors.Window;
            this.lblRegistCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistCnt.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRegistCnt.Location = new System.Drawing.Point(221, 143);
            this.lblRegistCnt.Name = "lblRegistCnt";
            this.lblRegistCnt.Size = new System.Drawing.Size(111, 32);
            this.lblRegistCnt.TabIndex = 27;
            this.lblRegistCnt.Text = "0";
            this.lblRegistCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "読込";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtControlNo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(61, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 66);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "管理番号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtControlNo
            // 
            this.txtControlNo.Enabled = false;
            this.txtControlNo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtControlNo.Location = new System.Drawing.Point(4, 36);
            this.txtControlNo.MaxLength = 20;
            this.txtControlNo.Name = "txtControlNo";
            this.txtControlNo.Size = new System.Drawing.Size(170, 25);
            this.txtControlNo.TabIndex = 4;
            this.txtControlNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CONTROL_NO_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProductType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblContractNo, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(363, 207);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 55);
            this.tableLayoutPanel2.TabIndex = 30;
            this.tableLayoutPanel2.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel2_CellPaint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "種別";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(96, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "証券番号";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // lblProductType
            // 
            this.lblProductType.BackColor = System.Drawing.Color.White;
            this.lblProductType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductType.Location = new System.Drawing.Point(4, 30);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(85, 24);
            this.lblProductType.TabIndex = 5;
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContractNo
            // 
            this.lblContractNo.BackColor = System.Drawing.Color.White;
            this.lblContractNo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblContractNo.Location = new System.Drawing.Point(96, 30);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(242, 24);
            this.lblContractNo.TabIndex = 6;
            this.lblContractNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "私物内容";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel3.Controls.Add(this.labelPB10, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.labelPB9, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.labelPB8, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.labelPB7, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.labelPB6, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.labelPB5, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelPB4, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelPB3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelPB2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB6, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB7, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB10, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB9, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxPB8, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.labelPB1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(37, 302);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(307, 244);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel2_CellPaint);
            // 
            // labelPB10
            // 
            this.labelPB10.BackColor = System.Drawing.Color.White;
            this.labelPB10.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB10.Location = new System.Drawing.Point(96, 221);
            this.labelPB10.Name = "labelPB10";
            this.labelPB10.Size = new System.Drawing.Size(207, 19);
            this.labelPB10.TabIndex = 49;
            this.labelPB10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB10.Visible = false;
            // 
            // labelPB9
            // 
            this.labelPB9.BackColor = System.Drawing.Color.White;
            this.labelPB9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB9.Location = new System.Drawing.Point(96, 199);
            this.labelPB9.Name = "labelPB9";
            this.labelPB9.Size = new System.Drawing.Size(207, 19);
            this.labelPB9.TabIndex = 48;
            this.labelPB9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB9.Visible = false;
            // 
            // labelPB8
            // 
            this.labelPB8.BackColor = System.Drawing.Color.White;
            this.labelPB8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB8.Location = new System.Drawing.Point(96, 177);
            this.labelPB8.Name = "labelPB8";
            this.labelPB8.Size = new System.Drawing.Size(207, 19);
            this.labelPB8.TabIndex = 47;
            this.labelPB8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB8.Visible = false;
            // 
            // labelPB7
            // 
            this.labelPB7.BackColor = System.Drawing.Color.White;
            this.labelPB7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB7.Location = new System.Drawing.Point(96, 155);
            this.labelPB7.Name = "labelPB7";
            this.labelPB7.Size = new System.Drawing.Size(207, 19);
            this.labelPB7.TabIndex = 46;
            this.labelPB7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB7.Visible = false;
            // 
            // labelPB6
            // 
            this.labelPB6.BackColor = System.Drawing.Color.White;
            this.labelPB6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB6.Location = new System.Drawing.Point(96, 133);
            this.labelPB6.Name = "labelPB6";
            this.labelPB6.Size = new System.Drawing.Size(207, 19);
            this.labelPB6.TabIndex = 45;
            this.labelPB6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB6.Visible = false;
            // 
            // labelPB5
            // 
            this.labelPB5.BackColor = System.Drawing.Color.White;
            this.labelPB5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB5.Location = new System.Drawing.Point(96, 111);
            this.labelPB5.Name = "labelPB5";
            this.labelPB5.Size = new System.Drawing.Size(207, 19);
            this.labelPB5.TabIndex = 44;
            this.labelPB5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB5.Visible = false;
            // 
            // labelPB4
            // 
            this.labelPB4.BackColor = System.Drawing.Color.White;
            this.labelPB4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB4.Location = new System.Drawing.Point(96, 89);
            this.labelPB4.Name = "labelPB4";
            this.labelPB4.Size = new System.Drawing.Size(207, 19);
            this.labelPB4.TabIndex = 43;
            this.labelPB4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB4.Visible = false;
            // 
            // labelPB3
            // 
            this.labelPB3.BackColor = System.Drawing.Color.White;
            this.labelPB3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB3.Location = new System.Drawing.Point(96, 67);
            this.labelPB3.Name = "labelPB3";
            this.labelPB3.Size = new System.Drawing.Size(207, 19);
            this.labelPB3.TabIndex = 42;
            this.labelPB3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB3.Visible = false;
            // 
            // labelPB2
            // 
            this.labelPB2.BackColor = System.Drawing.Color.White;
            this.labelPB2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB2.Location = new System.Drawing.Point(96, 45);
            this.labelPB2.Name = "labelPB2";
            this.labelPB2.Size = new System.Drawing.Size(207, 19);
            this.labelPB2.TabIndex = 41;
            this.labelPB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB2.Visible = false;
            // 
            // checkBoxPB4
            // 
            this.checkBoxPB4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB4.AutoSize = true;
            this.checkBoxPB4.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB4.Enabled = false;
            this.checkBoxPB4.Location = new System.Drawing.Point(4, 92);
            this.checkBoxPB4.Name = "checkBoxPB4";
            this.checkBoxPB4.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB4.TabIndex = 7;
            this.checkBoxPB4.UseVisualStyleBackColor = false;
            this.checkBoxPB4.Visible = false;
            // 
            // checkBoxPB5
            // 
            this.checkBoxPB5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB5.AutoSize = true;
            this.checkBoxPB5.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB5.Enabled = false;
            this.checkBoxPB5.Location = new System.Drawing.Point(4, 114);
            this.checkBoxPB5.Name = "checkBoxPB5";
            this.checkBoxPB5.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB5.TabIndex = 8;
            this.checkBoxPB5.UseVisualStyleBackColor = false;
            this.checkBoxPB5.Visible = false;
            // 
            // checkBoxPB6
            // 
            this.checkBoxPB6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB6.AutoSize = true;
            this.checkBoxPB6.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB6.Enabled = false;
            this.checkBoxPB6.Location = new System.Drawing.Point(4, 136);
            this.checkBoxPB6.Name = "checkBoxPB6";
            this.checkBoxPB6.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB6.TabIndex = 9;
            this.checkBoxPB6.UseVisualStyleBackColor = false;
            this.checkBoxPB6.Visible = false;
            // 
            // checkBoxPB7
            // 
            this.checkBoxPB7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB7.AutoSize = true;
            this.checkBoxPB7.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB7.Enabled = false;
            this.checkBoxPB7.Location = new System.Drawing.Point(4, 158);
            this.checkBoxPB7.Name = "checkBoxPB7";
            this.checkBoxPB7.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB7.TabIndex = 10;
            this.checkBoxPB7.UseVisualStyleBackColor = false;
            this.checkBoxPB7.Visible = false;
            // 
            // checkBoxPB3
            // 
            this.checkBoxPB3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB3.AutoSize = true;
            this.checkBoxPB3.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB3.Enabled = false;
            this.checkBoxPB3.Location = new System.Drawing.Point(4, 70);
            this.checkBoxPB3.Name = "checkBoxPB3";
            this.checkBoxPB3.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB3.TabIndex = 6;
            this.checkBoxPB3.UseVisualStyleBackColor = false;
            this.checkBoxPB3.Visible = false;
            // 
            // checkBoxPB2
            // 
            this.checkBoxPB2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB2.AutoSize = true;
            this.checkBoxPB2.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB2.Enabled = false;
            this.checkBoxPB2.Location = new System.Drawing.Point(4, 48);
            this.checkBoxPB2.Name = "checkBoxPB2";
            this.checkBoxPB2.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB2.TabIndex = 5;
            this.checkBoxPB2.UseVisualStyleBackColor = false;
            this.checkBoxPB2.Visible = false;
            // 
            // checkBoxPB10
            // 
            this.checkBoxPB10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB10.AutoSize = true;
            this.checkBoxPB10.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB10.Enabled = false;
            this.checkBoxPB10.Location = new System.Drawing.Point(4, 224);
            this.checkBoxPB10.Name = "checkBoxPB10";
            this.checkBoxPB10.Size = new System.Drawing.Size(85, 16);
            this.checkBoxPB10.TabIndex = 13;
            this.checkBoxPB10.UseVisualStyleBackColor = false;
            this.checkBoxPB10.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "チェック";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPB1
            // 
            this.checkBoxPB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB1.AutoSize = true;
            this.checkBoxPB1.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB1.Enabled = false;
            this.checkBoxPB1.Location = new System.Drawing.Point(4, 26);
            this.checkBoxPB1.Name = "checkBoxPB1";
            this.checkBoxPB1.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB1.TabIndex = 5;
            this.checkBoxPB1.UseVisualStyleBackColor = false;
            this.checkBoxPB1.Visible = false;
            // 
            // checkBoxPB9
            // 
            this.checkBoxPB9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB9.AutoSize = true;
            this.checkBoxPB9.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB9.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB9.Enabled = false;
            this.checkBoxPB9.Location = new System.Drawing.Point(4, 202);
            this.checkBoxPB9.Name = "checkBoxPB9";
            this.checkBoxPB9.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB9.TabIndex = 12;
            this.checkBoxPB9.UseVisualStyleBackColor = false;
            this.checkBoxPB9.Visible = false;
            // 
            // checkBoxPB8
            // 
            this.checkBoxPB8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPB8.AutoSize = true;
            this.checkBoxPB8.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxPB8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPB8.Enabled = false;
            this.checkBoxPB8.Location = new System.Drawing.Point(4, 180);
            this.checkBoxPB8.Name = "checkBoxPB8";
            this.checkBoxPB8.Size = new System.Drawing.Size(85, 15);
            this.checkBoxPB8.TabIndex = 11;
            this.checkBoxPB8.UseVisualStyleBackColor = false;
            this.checkBoxPB8.Visible = false;
            // 
            // labelPB1
            // 
            this.labelPB1.BackColor = System.Drawing.Color.White;
            this.labelPB1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPB1.Location = new System.Drawing.Point(96, 23);
            this.labelPB1.Name = "labelPB1";
            this.labelPB1.Size = new System.Drawing.Size(207, 19);
            this.labelPB1.TabIndex = 6;
            this.labelPB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPB1.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(96, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "私物内容";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(362, 302);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19048F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.80952F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(343, 85);
            this.tableLayoutPanel4.TabIndex = 33;
            this.tableLayoutPanel4.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel2_CellPaint);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.txtETC, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelETC, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(96, 26);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(243, 52);
            this.tableLayoutPanel6.TabIndex = 4;
            this.tableLayoutPanel6.TabStop = true;
            this.tableLayoutPanel6.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel3_CellPaint);
            // 
            // txtETC
            // 
            this.txtETC.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtETC.Enabled = false;
            this.txtETC.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtETC.Location = new System.Drawing.Point(3, 26);
            this.txtETC.MaxLength = 50;
            this.txtETC.Name = "txtETC";
            this.txtETC.Size = new System.Drawing.Size(232, 23);
            this.txtETC.TabIndex = 5;
            this.txtETC.Visible = false;
            this.txtETC.WordWrap = false;
            // 
            // labelETC
            // 
            this.labelETC.BackColor = System.Drawing.Color.White;
            this.labelETC.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelETC.Location = new System.Drawing.Point(3, 0);
            this.labelETC.Name = "labelETC";
            this.labelETC.Size = new System.Drawing.Size(235, 22);
            this.labelETC.TabIndex = 7;
            this.labelETC.Text = "その他";
            this.labelETC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelETC.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(4, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "チェック";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.BackColor = System.Drawing.Color.LightGray;
            this.label19.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(96, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(243, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "私物内容";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label19.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.checkBoxETC, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 26);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(84, 44);
            this.tableLayoutPanel5.TabIndex = 2;
            this.tableLayoutPanel5.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel3_CellPaint);
            // 
            // checkBoxETC
            // 
            this.checkBoxETC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxETC.AutoSize = true;
            this.checkBoxETC.BackColor = System.Drawing.SystemColors.Window;
            this.checkBoxETC.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxETC.Enabled = false;
            this.checkBoxETC.Location = new System.Drawing.Point(3, 3);
            this.checkBoxETC.Name = "checkBoxETC";
            this.checkBoxETC.Size = new System.Drawing.Size(78, 16);
            this.checkBoxETC.TabIndex = 14;
            this.checkBoxETC.UseVisualStyleBackColor = false;
            this.checkBoxETC.Visible = false;
            this.checkBoxETC.CheckedChanged += new System.EventHandler(this.checkBox_Check);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(472, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "QRコード表示";
            // 
            // txtRegistDate
            // 
            this.txtRegistDate.Enabled = false;
            this.txtRegistDate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRegistDate.Location = new System.Drawing.Point(61, 144);
            this.txtRegistDate.MaxLength = 8;
            this.txtRegistDate.Name = "txtRegistDate";
            this.txtRegistDate.Size = new System.Drawing.Size(122, 31);
            this.txtRegistDate.TabIndex = 36;
            this.txtRegistDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputRegistDateCheck);
            this.txtRegistDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressRegistDateCheck);
            // 
            // picBoxQRCode
            // 
            this.picBoxQRCode.BackColor = System.Drawing.SystemColors.Window;
            this.picBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQRCode.Location = new System.Drawing.Point(448, 423);
            this.picBoxQRCode.Name = "picBoxQRCode";
            this.picBoxQRCode.Size = new System.Drawing.Size(163, 134);
            this.picBoxQRCode.TabIndex = 37;
            this.picBoxQRCode.TabStop = false;
            // 
            // frmMSPB200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(715, 638);
            this.Controls.Add(this.txtRegistDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistCnt);
            this.Controls.Add(this.lblRegistCount);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.lblRegistDate);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.End);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.picBoxQRCode);
            this.Name = "frmMSPB200";
            this.Text = "MS 私物返却管理DB 私物登録";
            this.Load += new System.EventHandler(this.MSPB200_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label StaffName;
        private System.Windows.Forms.Label lblRegistDate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label header0;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label registCnt;
        private System.Windows.Forms.Label lblRegistCount;
        private System.Windows.Forms.Label lblRegistCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtControlNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxPB1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPB1;
        private System.Windows.Forms.CheckBox checkBoxPB2;
        private System.Windows.Forms.CheckBox checkBoxPB10;
        private System.Windows.Forms.CheckBox checkBoxPB9;
        private System.Windows.Forms.CheckBox checkBoxPB8;
        private System.Windows.Forms.CheckBox checkBoxPB3;
        private System.Windows.Forms.Label labelPB10;
        private System.Windows.Forms.Label labelPB9;
        private System.Windows.Forms.Label labelPB8;
        private System.Windows.Forms.Label labelPB7;
        private System.Windows.Forms.Label labelPB6;
        private System.Windows.Forms.Label labelPB5;
        private System.Windows.Forms.Label labelPB4;
        private System.Windows.Forms.Label labelPB3;
        private System.Windows.Forms.Label labelPB2;
        private System.Windows.Forms.CheckBox checkBoxPB4;
        private System.Windows.Forms.CheckBox checkBoxPB5;
        private System.Windows.Forms.CheckBox checkBoxPB6;
        private System.Windows.Forms.CheckBox checkBoxPB7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox checkBoxETC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtETC;
        private System.Windows.Forms.Label labelETC;
        private System.Windows.Forms.TextBox txtRegistDate;
        private System.Windows.Forms.PictureBox picBoxQRCode;
    }
}

