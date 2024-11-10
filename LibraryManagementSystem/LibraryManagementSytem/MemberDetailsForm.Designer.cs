namespace LibraryManagementSytem
{
    partial class MemberDetailsForm
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
            this.dataGridViewMem = new System.Windows.Forms.DataGridView();
            this.memIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofmembeshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofbooksissuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberRecordTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSdatabaseDataSet2 = new LibraryManagementSytem.LMSdatabaseDataSet2();
            this.label10 = new System.Windows.Forms.Label();
            this.BttnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BttnView = new System.Windows.Forms.Button();
            this.txtBoxMemberId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPhoneNo = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textNoOfBooks = new System.Windows.Forms.TextBox();
            this.textMemBDate = new System.Windows.Forms.TextBox();
            this.textMemDate = new System.Windows.Forms.TextBox();
            this.textMemName = new System.Windows.Forms.TextBox();
            this.textMemId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.BttnEdit = new System.Windows.Forms.Button();
            this.BttnAddNew = new System.Windows.Forms.Button();
            this.BttnReset = new System.Windows.Forms.Button();
            this.memberRecord_TableTableAdapter = new LibraryManagementSytem.LMSdatabaseDataSet2TableAdapters.MemberRecord_TableTableAdapter();
            this.bookRecordTableTableAdapter = new LibraryManagementSytem.LMSdatabaseDataSet3TableAdapters.BookRecordTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberRecordTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSdatabaseDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMem
            // 
            this.dataGridViewMem.AutoGenerateColumns = false;
            this.dataGridViewMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memIdDataGridViewTextBoxColumn,
            this.dateofmembeshipDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn,
            this.noofbooksissuedDataGridViewTextBoxColumn});
            this.dataGridViewMem.DataSource = this.memberRecordTableBindingSource;
            this.dataGridViewMem.Location = new System.Drawing.Point(37, 512);
            this.dataGridViewMem.Name = "dataGridViewMem";
            this.dataGridViewMem.RowHeadersWidth = 51;
            this.dataGridViewMem.RowTemplate.Height = 24;
            this.dataGridViewMem.Size = new System.Drawing.Size(871, 129);
            this.dataGridViewMem.TabIndex = 10;
            // 
            // memIdDataGridViewTextBoxColumn
            // 
            this.memIdDataGridViewTextBoxColumn.DataPropertyName = "mem_Id";
            this.memIdDataGridViewTextBoxColumn.HeaderText = "mem_Id";
            this.memIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memIdDataGridViewTextBoxColumn.Name = "memIdDataGridViewTextBoxColumn";
            this.memIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.memIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofmembeshipDataGridViewTextBoxColumn
            // 
            this.dateofmembeshipDataGridViewTextBoxColumn.DataPropertyName = "date_of_membeship";
            this.dateofmembeshipDataGridViewTextBoxColumn.HeaderText = "date_of_membeship";
            this.dateofmembeshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofmembeshipDataGridViewTextBoxColumn.Name = "dateofmembeshipDataGridViewTextBoxColumn";
            this.dateofmembeshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenoDataGridViewTextBoxColumn
            // 
            this.phonenoDataGridViewTextBoxColumn.DataPropertyName = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.HeaderText = "phone_no";
            this.phonenoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenoDataGridViewTextBoxColumn.Name = "phonenoDataGridViewTextBoxColumn";
            this.phonenoDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofbooksissuedDataGridViewTextBoxColumn
            // 
            this.noofbooksissuedDataGridViewTextBoxColumn.DataPropertyName = "no_of_books_issued";
            this.noofbooksissuedDataGridViewTextBoxColumn.HeaderText = "no_of_books_issued";
            this.noofbooksissuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofbooksissuedDataGridViewTextBoxColumn.Name = "noofbooksissuedDataGridViewTextBoxColumn";
            this.noofbooksissuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberRecordTableBindingSource
            // 
            this.memberRecordTableBindingSource.DataMember = "MemberRecord_Table";
            this.memberRecordTableBindingSource.DataSource = this.lMSdatabaseDataSet2;
            // 
            // lMSdatabaseDataSet2
            // 
            this.lMSdatabaseDataSet2.DataSetName = "LMSdatabaseDataSet2";
            this.lMSdatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, -97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Member Record";
            // 
            // BttnBack
            // 
            this.BttnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBack.Location = new System.Drawing.Point(763, 472);
            this.BttnBack.Name = "BttnBack";
            this.BttnBack.Size = new System.Drawing.Size(145, 34);
            this.BttnBack.TabIndex = 8;
            this.BttnBack.Text = "Back to Home";
            this.BttnBack.UseVisualStyleBackColor = true;
            this.BttnBack.Click += new System.EventHandler(this.BttnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BttnView);
            this.groupBox2.Controls.Add(this.txtBoxMemberId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BttnDelete);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(603, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View or Delete Member";
            // 
            // BttnView
            // 
            this.BttnView.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnView.Location = new System.Drawing.Point(30, 107);
            this.BttnView.Name = "BttnView";
            this.BttnView.Size = new System.Drawing.Size(96, 34);
            this.BttnView.TabIndex = 6;
            this.BttnView.Text = "View";
            this.BttnView.UseVisualStyleBackColor = true;
            this.BttnView.Click += new System.EventHandler(this.BttnView_Click);
            // 
            // txtBoxMemberId
            // 
            this.txtBoxMemberId.Location = new System.Drawing.Point(128, 29);
            this.txtBoxMemberId.Name = "txtBoxMemberId";
            this.txtBoxMemberId.Size = new System.Drawing.Size(149, 34);
            this.txtBoxMemberId.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SansSerif", 9F);
            this.label9.Location = new System.Drawing.Point(14, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Member Id";
            // 
            // BttnDelete
            // 
            this.BttnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(160, 106);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(96, 34);
            this.BttnDelete.TabIndex = 3;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Member Record";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textPhoneNo);
            this.groupBox4.Controls.Add(this.textAddress);
            this.groupBox4.Controls.Add(this.textNoOfBooks);
            this.groupBox4.Controls.Add(this.textMemBDate);
            this.groupBox4.Controls.Add(this.textMemDate);
            this.groupBox4.Controls.Add(this.textMemName);
            this.groupBox4.Controls.Add(this.textMemId);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.BttnEdit);
            this.groupBox4.Controls.Add(this.BttnAddNew);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(37, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 433);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add or Edit Memeber Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(363, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "**(mm / dd / yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(363, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "**(mm / dd / yyyy)";
            // 
            // textPhoneNo
            // 
            this.textPhoneNo.Location = new System.Drawing.Point(175, 322);
            this.textPhoneNo.Name = "textPhoneNo";
            this.textPhoneNo.Size = new System.Drawing.Size(174, 34);
            this.textPhoneNo.TabIndex = 17;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(175, 267);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(378, 38);
            this.textAddress.TabIndex = 16;
            // 
            // textNoOfBooks
            // 
            this.textNoOfBooks.Location = new System.Drawing.Point(175, 213);
            this.textNoOfBooks.Name = "textNoOfBooks";
            this.textNoOfBooks.Size = new System.Drawing.Size(111, 34);
            this.textNoOfBooks.TabIndex = 14;
            // 
            // textMemBDate
            // 
            this.textMemBDate.Location = new System.Drawing.Point(175, 166);
            this.textMemBDate.Name = "textMemBDate";
            this.textMemBDate.Size = new System.Drawing.Size(174, 34);
            this.textMemBDate.TabIndex = 13;
            // 
            // textMemDate
            // 
            this.textMemDate.Location = new System.Drawing.Point(175, 119);
            this.textMemDate.Name = "textMemDate";
            this.textMemDate.Size = new System.Drawing.Size(174, 34);
            this.textMemDate.TabIndex = 12;
            // 
            // textMemName
            // 
            this.textMemName.Location = new System.Drawing.Point(174, 76);
            this.textMemName.Name = "textMemName";
            this.textMemName.Size = new System.Drawing.Size(378, 34);
            this.textMemName.TabIndex = 11;
            // 
            // textMemId
            // 
            this.textMemId.Location = new System.Drawing.Point(175, 33);
            this.textMemId.Name = "textMemId";
            this.textMemId.Size = new System.Drawing.Size(151, 34);
            this.textMemId.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SansSerif", 9F);
            this.label13.Location = new System.Drawing.Point(21, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Phone No : ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.Location = new System.Drawing.Point(21, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Address :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.Location = new System.Drawing.Point(21, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "No of Books Issued :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.Location = new System.Drawing.Point(21, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Date of Birth :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SansSerif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.Location = new System.Drawing.Point(21, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Date of Membership :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SansSerif", 9F);
            this.label19.Location = new System.Drawing.Point(21, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "Member Name :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SansSerif", 9F);
            this.label20.Location = new System.Drawing.Point(21, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Member Id :";
            // 
            // BttnEdit
            // 
            this.BttnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnEdit.Location = new System.Drawing.Point(24, 383);
            this.BttnEdit.Name = "BttnEdit";
            this.BttnEdit.Size = new System.Drawing.Size(223, 34);
            this.BttnEdit.TabIndex = 1;
            this.BttnEdit.Text = "Edit Member Details";
            this.BttnEdit.UseVisualStyleBackColor = true;
            this.BttnEdit.Click += new System.EventHandler(this.BttnEdit_Click);
            // 
            // BttnAddNew
            // 
            this.BttnAddNew.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAddNew.Location = new System.Drawing.Point(320, 383);
            this.BttnAddNew.Name = "BttnAddNew";
            this.BttnAddNew.Size = new System.Drawing.Size(232, 34);
            this.BttnAddNew.TabIndex = 0;
            this.BttnAddNew.Text = "Add New Member";
            this.BttnAddNew.UseVisualStyleBackColor = true;
            this.BttnAddNew.Click += new System.EventHandler(this.BttnAddNew_Click);
            // 
            // BttnReset
            // 
            this.BttnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnReset.Location = new System.Drawing.Point(766, 419);
            this.BttnReset.Name = "BttnReset";
            this.BttnReset.Size = new System.Drawing.Size(113, 34);
            this.BttnReset.TabIndex = 15;
            this.BttnReset.Text = "ResetAll";
            this.BttnReset.UseVisualStyleBackColor = true;
            this.BttnReset.Click += new System.EventHandler(this.BttnReset_Click);
            // 
            // memberRecord_TableTableAdapter
            // 
            this.memberRecord_TableTableAdapter.ClearBeforeFill = true;
            // 
            // bookRecordTableTableAdapter
            // 
            this.bookRecordTableTableAdapter.ClearBeforeFill = true;
            // 
            // MemberDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 688);
            this.Controls.Add(this.BttnReset);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridViewMem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BttnBack);
            this.Controls.Add(this.groupBox2);
            this.Name = "MemberDetailsForm";
            this.Text = "MemberDetailsForm";
            this.Load += new System.EventHandler(this.MemberDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberRecordTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSdatabaseDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BttnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxMemberId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textPhoneNo;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textNoOfBooks;
        private System.Windows.Forms.TextBox textMemBDate;
        private System.Windows.Forms.TextBox textMemDate;
        private System.Windows.Forms.TextBox textMemName;
        private System.Windows.Forms.TextBox textMemId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BttnEdit;
        private System.Windows.Forms.Button BttnAddNew;
        private System.Windows.Forms.Button BttnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnReset;
        private LMSdatabaseDataSet2 lMSdatabaseDataSet2;
        private System.Windows.Forms.BindingSource memberRecordTableBindingSource;
        private LMSdatabaseDataSet2TableAdapters.MemberRecord_TableTableAdapter memberRecord_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofmembeshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofbooksissuedDataGridViewTextBoxColumn;
        private LMSdatabaseDataSet3TableAdapters.BookRecordTableTableAdapter bookRecordTableTableAdapter;
    }
}