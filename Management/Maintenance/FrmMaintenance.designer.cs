namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmInsert = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmSearchItems = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.labToDate = new System.Windows.Forms.Label();
            this.cbSubDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.btmExit = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datWorkGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMaintenanceItem = new System.Windows.Forms.Button();
            this.chbDateCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // btmInsert
            // 
            this.btmInsert.Location = new System.Drawing.Point(730, 706);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(156, 44);
            this.btmInsert.TabIndex = 66;
            this.btmInsert.Text = "ورود";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(542, 706);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(156, 44);
            this.btmDelete.TabIndex = 65;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // btmSearchItems
            // 
            this.btmSearchItems.Location = new System.Drawing.Point(1280, 201);
            this.btmSearchItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmSearchItems.Name = "btmSearchItems";
            this.btmSearchItems.Size = new System.Drawing.Size(206, 44);
            this.btmSearchItems.TabIndex = 43;
            this.btmSearchItems.Text = "جستجو";
            this.btmSearchItems.UseVisualStyleBackColor = true;
            this.btmSearchItems.Click += new System.EventHandler(this.BtmSearchItems_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Enabled = false;
            this.dtpToDate.Location = new System.Drawing.Point(924, 49);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(249, 32);
            this.dtpToDate.TabIndex = 63;
            // 
            // labToDate
            // 
            this.labToDate.AutoSize = true;
            this.labToDate.Enabled = false;
            this.labToDate.Location = new System.Drawing.Point(892, 55);
            this.labToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(27, 26);
            this.labToDate.TabIndex = 62;
            this.labToDate.Text = "تا:";
            // 
            // cbSubDepartment
            // 
            this.cbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubDepartment.FormattingEnabled = true;
            this.cbSubDepartment.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.cbSubDepartment.Location = new System.Drawing.Point(554, 136);
            this.cbSubDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSubDepartment.Name = "cbSubDepartment";
            this.cbSubDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSubDepartment.Size = new System.Drawing.Size(178, 32);
            this.cbSubDepartment.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "زیربخش:";
            // 
            // cbShift
            // 
            this.cbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "",
            "صبح",
            "عصر",
            "شب"});
            this.cbShift.Location = new System.Drawing.Point(939, 136);
            this.cbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShift.Name = "cbShift";
            this.cbShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbShift.Size = new System.Drawing.Size(186, 32);
            this.cbShift.TabIndex = 59;
            this.cbShift.SelectedIndexChanged += new System.EventHandler(this.CbShift_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "نوبت کاری:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Enabled = false;
            this.dtpFromDate.Location = new System.Drawing.Point(592, 49);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(249, 32);
            this.dtpFromDate.TabIndex = 57;
            // 
            // labFromDate
            // 
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Location = new System.Drawing.Point(558, 55);
            this.labFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(29, 26);
            this.labFromDate.TabIndex = 56;
            this.labFromDate.Text = "از:";
            // 
            // btmExit
            // 
            this.btmExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmExit.Location = new System.Drawing.Point(730, 782);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(156, 44);
            this.btmExit.TabIndex = 44;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.AllowUserToOrderColumns = true;
            this.dgvMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.datWorkGroup,
            this.nameSubDepartment,
            this.nameShift,
            this.Workers,
            this.LeaderWorker});
            this.dgvMaintenance.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMaintenance.Location = new System.Drawing.Point(154, 255);
            this.dgvMaintenance.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMaintenance.RowTemplate.Height = 55;
            this.dgvMaintenance.Size = new System.Drawing.Size(1375, 441);
            this.dgvMaintenance.TabIndex = 67;
            this.dgvMaintenance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaintenance_CellDoubleClick);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.Visible = false;
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle3;
            this.bitSelect.FillWeight = 85.27919F;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            // 
            // datWorkGroup
            // 
            this.datWorkGroup.DataPropertyName = "datWorkGroup";
            this.datWorkGroup.FillWeight = 85.27919F;
            this.datWorkGroup.HeaderText = "تاریخ";
            this.datWorkGroup.MinimumWidth = 6;
            this.datWorkGroup.Name = "datWorkGroup";
            // 
            // nameSubDepartment
            // 
            this.nameSubDepartment.DataPropertyName = "nameSubDepartment";
            this.nameSubDepartment.FillWeight = 85.27919F;
            this.nameSubDepartment.HeaderText = "زیربخش";
            this.nameSubDepartment.MinimumWidth = 6;
            this.nameSubDepartment.Name = "nameSubDepartment";
            // 
            // nameShift
            // 
            this.nameShift.DataPropertyName = "nameShift";
            this.nameShift.FillWeight = 85.27919F;
            this.nameShift.HeaderText = "نوبت کاری";
            this.nameShift.MinimumWidth = 6;
            this.nameShift.Name = "nameShift";
            // 
            // Workers
            // 
            this.Workers.DataPropertyName = "workers";
            this.Workers.FillWeight = 203.0457F;
            this.Workers.HeaderText = "افراد گروه";
            this.Workers.MinimumWidth = 6;
            this.Workers.Name = "Workers";
            // 
            // LeaderWorker
            // 
            this.LeaderWorker.DataPropertyName = "leaderWorker";
            this.LeaderWorker.FillWeight = 85.27919F;
            this.LeaderWorker.HeaderText = "سرگروه";
            this.LeaderWorker.MinimumWidth = 6;
            this.LeaderWorker.Name = "LeaderWorker";
            // 
            // btnMaintenanceItem
            // 
            this.btnMaintenanceItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaintenanceItem.Location = new System.Drawing.Point(922, 706);
            this.btnMaintenanceItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaintenanceItem.Name = "btnMaintenanceItem";
            this.btnMaintenanceItem.Size = new System.Drawing.Size(156, 44);
            this.btnMaintenanceItem.TabIndex = 68;
            this.btnMaintenanceItem.Text = "ورود مورد کاری";
            this.btnMaintenanceItem.UseVisualStyleBackColor = true;
            this.btnMaintenanceItem.Click += new System.EventHandler(this.BtnMaintenanceItem_Click);
            // 
            // chbDateCheck
            // 
            this.chbDateCheck.AutoSize = true;
            this.chbDateCheck.Location = new System.Drawing.Point(481, 54);
            this.chbDateCheck.Margin = new System.Windows.Forms.Padding(4);
            this.chbDateCheck.Name = "chbDateCheck";
            this.chbDateCheck.Size = new System.Drawing.Size(66, 30);
            this.chbDateCheck.TabIndex = 71;
            this.chbDateCheck.Text = "تاریخ";
            this.chbDateCheck.UseVisualStyleBackColor = true;
            this.chbDateCheck.CheckedChanged += new System.EventHandler(this.ChbDateCheck_CheckedChanged);
            // 
            // FrmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1708, 936);
            this.Controls.Add(this.chbDateCheck);
            this.Controls.Add(this.btnMaintenanceItem);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmSearchItems);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.labToDate);
            this.Controls.Add(this.cbSubDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmMaintenance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعمیرات برق کوره";
            this.Load += new System.EventHandler(this.FrmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmSearchItems;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.ComboBox cbSubDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.Button btnMaintenanceItem;
        private System.Windows.Forms.CheckBox chbDateCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn datWorkGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderWorker;
    }
}