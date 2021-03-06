﻿using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    partial class FrmSelectEquip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btmSelect = new System.Windows.Forms.Button();
            this.dgvEquips = new System.Windows.Forms.DataGridView();
            this.cbEqiupName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubZones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.cbLocationes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subZoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquips)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(469, 476);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 35);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "رد";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btmSelect
            // 
            this.btmSelect.Location = new System.Drawing.Point(274, 476);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(125, 35);
            this.btmSelect.TabIndex = 60;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // dgvEquips
            // 
            this.dgvEquips.AllowUserToAddRows = false;
            this.dgvEquips.AllowUserToDeleteRows = false;
            this.dgvEquips.AllowUserToOrderColumns = true;
            this.dgvEquips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquips.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.companyTitle,
            this.locationTitle,
            this.zoneTitle,
            this.subZoneTitle,
            this.categoryTitle,
            this.equipNameTitle});
            this.dgvEquips.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEquips.Location = new System.Drawing.Point(25, 211);
            this.dgvEquips.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquips.Name = "dgvEquips";
            this.dgvEquips.ReadOnly = true;
            this.dgvEquips.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEquips.RowTemplate.Height = 55;
            this.dgvEquips.Size = new System.Drawing.Size(835, 228);
            this.dgvEquips.TabIndex = 59;
            // 
            // cbEqiupName
            // 
            this.cbEqiupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEqiupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEqiupName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbEqiupName.FormattingEnabled = true;
            this.cbEqiupName.Location = new System.Drawing.Point(715, 95);
            this.cbEqiupName.Margin = new System.Windows.Forms.Padding(4);
            this.cbEqiupName.Name = "cbEqiupName";
            this.cbEqiupName.Size = new System.Drawing.Size(120, 28);
            this.cbEqiupName.TabIndex = 72;
            this.cbEqiupName.SelectedIndexChanged += new System.EventHandler(this.CbEqiupName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(678, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "نام:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(521, 95);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 28);
            this.cbCategories.TabIndex = 69;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(471, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "رسته:";
            // 
            // cbSubZones
            // 
            this.cbSubZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubZones.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSubZones.FormattingEnabled = true;
            this.cbSubZones.Location = new System.Drawing.Point(317, 95);
            this.cbSubZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubZones.Name = "cbSubZones";
            this.cbSubZones.Size = new System.Drawing.Size(120, 28);
            this.cbSubZones.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(251, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "زیربخش:";
            // 
            // cbZones
            // 
            this.cbZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZones.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbZones.FormattingEnabled = true;
            this.cbZones.Location = new System.Drawing.Point(96, 94);
            this.cbZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbZones.Name = "cbZones";
            this.cbZones.Size = new System.Drawing.Size(120, 28);
            this.cbZones.TabIndex = 63;
            this.cbZones.SelectedIndexChanged += new System.EventHandler(this.CbZones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "بخش:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Location = new System.Drawing.Point(125, 167);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(146, 23);
            this.labCode.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "کد:";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Location = new System.Drawing.Point(364, 167);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(207, 23);
            this.labName.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "نام:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmSearch.Location = new System.Drawing.Point(674, 162);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(186, 28);
            this.btmSearch.TabIndex = 78;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.BtmSearch_Click);
            // 
            // cbLocationes
            // 
            this.cbLocationes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocationes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbLocationes.FormattingEnabled = true;
            this.cbLocationes.Location = new System.Drawing.Point(537, 36);
            this.cbLocationes.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocationes.Name = "cbLocationes";
            this.cbLocationes.Size = new System.Drawing.Size(120, 28);
            this.cbLocationes.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label5.Location = new System.Drawing.Point(500, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "محل:";
            // 
            // cbCompanies
            // 
            this.cbCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanies.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(266, 34);
            this.cbCompanies.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(120, 28);
            this.cbCompanies.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label6.Location = new System.Drawing.Point(216, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "شرکت:";
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle4;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // companyTitle
            // 
            this.companyTitle.DataPropertyName = "companyTitle";
            this.companyTitle.HeaderText = "شرکت";
            this.companyTitle.Name = "companyTitle";
            this.companyTitle.ReadOnly = true;
            // 
            // locationTitle
            // 
            this.locationTitle.DataPropertyName = "locationTitle";
            this.locationTitle.HeaderText = "محل";
            this.locationTitle.Name = "locationTitle";
            this.locationTitle.ReadOnly = true;
            // 
            // zoneTitle
            // 
            this.zoneTitle.DataPropertyName = "zoneTitle";
            this.zoneTitle.HeaderText = "بخش";
            this.zoneTitle.Name = "zoneTitle";
            this.zoneTitle.ReadOnly = true;
            // 
            // subZoneTitle
            // 
            this.subZoneTitle.DataPropertyName = "subZoneTitle";
            this.subZoneTitle.HeaderText = "زیربخش";
            this.subZoneTitle.Name = "subZoneTitle";
            this.subZoneTitle.ReadOnly = true;
            // 
            // categoryTitle
            // 
            this.categoryTitle.DataPropertyName = "categoryTitle";
            this.categoryTitle.HeaderText = "رسته";
            this.categoryTitle.Name = "categoryTitle";
            this.categoryTitle.ReadOnly = true;
            // 
            // equipNameTitle
            // 
            this.equipNameTitle.DataPropertyName = "equipNameTitle";
            this.equipNameTitle.HeaderText = "نام تجهیز";
            this.equipNameTitle.Name = "equipNameTitle";
            this.equipNameTitle.ReadOnly = true;
            // 
            // FrmSelectEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.cbLocationes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEqiupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSubZones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btmSelect);
            this.Controls.Add(this.dgvEquips);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectEquip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب تجهیز";
            this.Load += new System.EventHandler(this.FrmSelectEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button btnClose;
        private Button btmSelect;
        private DataGridView dgvEquips;
        private ComboBox cbEqiupName;
        private Label label3;
        private ComboBox cbCategories;
        private Label label4;
        private ComboBox cbSubZones;
        private Label label1;
        private ComboBox cbZones;
        private Label label2;
        private Label labCode;
        private Label label8;
        private Label labName;
        private Label label7;
        private Button btmSearch;
        private ComboBox cbLocationes;
        private Label label5;
        private ComboBox cbCompanies;
        private Label label6;
        private DataGridViewTextBoxColumn intID;
        private DataGridViewTextBoxColumn companyTitle;
        private DataGridViewTextBoxColumn locationTitle;
        private DataGridViewTextBoxColumn zoneTitle;
        private DataGridViewTextBoxColumn subZoneTitle;
        private DataGridViewTextBoxColumn categoryTitle;
        private DataGridViewTextBoxColumn equipNameTitle;
    }
}

