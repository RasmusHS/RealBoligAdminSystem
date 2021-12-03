
namespace RealBolig
{
    partial class CreateBolig
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
            this.mOmrådeTextbox = new System.Windows.Forms.MaskedTextBox();
            this.btnOpretBolig = new System.Windows.Forms.Button();
            this.btnForslåPris = new System.Windows.Forms.Button();
            this.mSalgsPrisTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelSalgsPris = new System.Windows.Forms.Label();
            this.mKvmTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelKvm = new System.Windows.Forms.Label();
            this.labelOmråde = new System.Windows.Forms.Label();
            this.mAdresseTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.mPostNRTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelPostNR = new System.Windows.Forms.Label();
            this.mKiDTextbox = new System.Windows.Forms.MaskedTextBox();
            this.labelKiD = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBoligTabel = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.områdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_realboligDataSet = new RealBolig.kaspermark_dk_db_realboligDataSet();
            this.tabKundeTabel = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kiDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermarkdkdbrealboligDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.KundeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabBoligTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            this.tabKundeTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mOmrådeTextbox
            // 
            this.mOmrådeTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mOmrådeTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOmrådeTextbox.Location = new System.Drawing.Point(352, 287);
            this.mOmrådeTextbox.Name = "mOmrådeTextbox";
            this.mOmrådeTextbox.Size = new System.Drawing.Size(330, 30);
            this.mOmrådeTextbox.TabIndex = 27;
            // 
            // btnOpretBolig
            // 
            this.btnOpretBolig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpretBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretBolig.Location = new System.Drawing.Point(430, 649);
            this.btnOpretBolig.Name = "btnOpretBolig";
            this.btnOpretBolig.Size = new System.Drawing.Size(152, 40);
            this.btnOpretBolig.TabIndex = 33;
            this.btnOpretBolig.Text = "Opret Bolig";
            this.btnOpretBolig.UseVisualStyleBackColor = true;
            // 
            // btnForslåPris
            // 
            this.btnForslåPris.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnForslåPris.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForslåPris.Location = new System.Drawing.Point(435, 499);
            this.btnForslåPris.Name = "btnForslåPris";
            this.btnForslåPris.Size = new System.Drawing.Size(152, 40);
            this.btnForslåPris.TabIndex = 32;
            this.btnForslåPris.Text = "Forslå Pris";
            this.btnForslåPris.UseVisualStyleBackColor = true;
            // 
            // mSalgsPrisTextbox
            // 
            this.mSalgsPrisTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mSalgsPrisTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSalgsPrisTextbox.Location = new System.Drawing.Point(352, 463);
            this.mSalgsPrisTextbox.Name = "mSalgsPrisTextbox";
            this.mSalgsPrisTextbox.Size = new System.Drawing.Size(330, 30);
            this.mSalgsPrisTextbox.TabIndex = 31;
            // 
            // labelSalgsPris
            // 
            this.labelSalgsPris.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSalgsPris.AutoSize = true;
            this.labelSalgsPris.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalgsPris.Location = new System.Drawing.Point(237, 463);
            this.labelSalgsPris.Name = "labelSalgsPris";
            this.labelSalgsPris.Size = new System.Drawing.Size(105, 26);
            this.labelSalgsPris.TabIndex = 30;
            this.labelSalgsPris.Text = "Salgs Pris";
            // 
            // mKvmTextbox
            // 
            this.mKvmTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mKvmTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKvmTextbox.Location = new System.Drawing.Point(352, 346);
            this.mKvmTextbox.Name = "mKvmTextbox";
            this.mKvmTextbox.Size = new System.Drawing.Size(330, 30);
            this.mKvmTextbox.TabIndex = 29;
            // 
            // labelKvm
            // 
            this.labelKvm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKvm.AutoSize = true;
            this.labelKvm.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKvm.Location = new System.Drawing.Point(286, 346);
            this.labelKvm.Name = "labelKvm";
            this.labelKvm.Size = new System.Drawing.Size(56, 26);
            this.labelKvm.TabIndex = 28;
            this.labelKvm.Text = "Kvm";
            // 
            // labelOmråde
            // 
            this.labelOmråde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOmråde.AutoSize = true;
            this.labelOmråde.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOmråde.Location = new System.Drawing.Point(250, 287);
            this.labelOmråde.Name = "labelOmråde";
            this.labelOmråde.Size = new System.Drawing.Size(92, 26);
            this.labelOmråde.TabIndex = 26;
            this.labelOmråde.Text = "Område";
            // 
            // mAdresseTextbox
            // 
            this.mAdresseTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mAdresseTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAdresseTextbox.Location = new System.Drawing.Point(352, 231);
            this.mAdresseTextbox.Name = "mAdresseTextbox";
            this.mAdresseTextbox.Size = new System.Drawing.Size(330, 30);
            this.mAdresseTextbox.TabIndex = 25;
            // 
            // labelAdresse
            // 
            this.labelAdresse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(251, 231);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(91, 26);
            this.labelAdresse.TabIndex = 24;
            this.labelAdresse.Text = "Adresse";
            // 
            // mPostNRTextbox
            // 
            this.mPostNRTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mPostNRTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPostNRTextbox.Location = new System.Drawing.Point(352, 178);
            this.mPostNRTextbox.Name = "mPostNRTextbox";
            this.mPostNRTextbox.Size = new System.Drawing.Size(330, 30);
            this.mPostNRTextbox.TabIndex = 23;
            // 
            // labelPostNR
            // 
            this.labelPostNR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPostNR.AutoSize = true;
            this.labelPostNR.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostNR.Location = new System.Drawing.Point(256, 178);
            this.labelPostNR.Name = "labelPostNR";
            this.labelPostNR.Size = new System.Drawing.Size(86, 26);
            this.labelPostNR.TabIndex = 22;
            this.labelPostNR.Text = "Post nr.";
            // 
            // mKiDTextbox
            // 
            this.mKiDTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mKiDTextbox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mKiDTextbox.Location = new System.Drawing.Point(352, 127);
            this.mKiDTextbox.Name = "mKiDTextbox";
            this.mKiDTextbox.Size = new System.Drawing.Size(330, 30);
            this.mKiDTextbox.TabIndex = 21;
            // 
            // labelKiD
            // 
            this.labelKiD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKiD.AutoSize = true;
            this.labelKiD.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKiD.Location = new System.Drawing.Point(238, 127);
            this.labelKiD.Name = "labelKiD";
            this.labelKiD.Size = new System.Drawing.Size(104, 26);
            this.labelKiD.TabIndex = 20;
            this.labelKiD.Text = "Kunde ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabBoligTabel);
            this.tabControl1.Controls.Add(this.tabKundeTabel);
            this.tabControl1.Location = new System.Drawing.Point(737, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 630);
            this.tabControl1.TabIndex = 19;
            // 
            // tabBoligTabel
            // 
            this.tabBoligTabel.Controls.Add(this.dataGridView1);
            this.tabBoligTabel.Location = new System.Drawing.Point(4, 22);
            this.tabBoligTabel.Name = "tabBoligTabel";
            this.tabBoligTabel.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoligTabel.Size = new System.Drawing.Size(856, 604);
            this.tabBoligTabel.TabIndex = 0;
            this.tabBoligTabel.Text = "Bolig Tabel";
            this.tabBoligTabel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biDDataGridViewTextBoxColumn,
            this.kiDDataGridViewTextBoxColumn,
            this.postNRDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.områdeDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.salgsDatoDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 598);
            this.dataGridView1.TabIndex = 0;
            // 
            // biDDataGridViewTextBoxColumn
            // 
            this.biDDataGridViewTextBoxColumn.DataPropertyName = "BiD";
            this.biDDataGridViewTextBoxColumn.HeaderText = "BiD";
            this.biDDataGridViewTextBoxColumn.Name = "biDDataGridViewTextBoxColumn";
            this.biDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiDDataGridViewTextBoxColumn
            // 
            this.kiDDataGridViewTextBoxColumn.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn.Name = "kiDDataGridViewTextBoxColumn";
            // 
            // postNRDataGridViewTextBoxColumn
            // 
            this.postNRDataGridViewTextBoxColumn.DataPropertyName = "PostNR";
            this.postNRDataGridViewTextBoxColumn.HeaderText = "PostNR";
            this.postNRDataGridViewTextBoxColumn.Name = "postNRDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // områdeDataGridViewTextBoxColumn
            // 
            this.områdeDataGridViewTextBoxColumn.DataPropertyName = "Område";
            this.områdeDataGridViewTextBoxColumn.HeaderText = "Område";
            this.områdeDataGridViewTextBoxColumn.Name = "områdeDataGridViewTextBoxColumn";
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "SalgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            // 
            // salgsDatoDataGridViewTextBoxColumn
            // 
            this.salgsDatoDataGridViewTextBoxColumn.DataPropertyName = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.HeaderText = "SalgsDato";
            this.salgsDatoDataGridViewTextBoxColumn.Name = "salgsDatoDataGridViewTextBoxColumn";
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "Kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "Kvm";
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            // 
            // boligBindingSource1
            // 
            this.boligBindingSource1.DataMember = "Bolig";
            this.boligBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet;
            // 
            // kaspermark_dk_db_realboligDataSet
            // 
            this.kaspermark_dk_db_realboligDataSet.DataSetName = "kaspermark_dk_db_realboligDataSet";
            this.kaspermark_dk_db_realboligDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabKundeTabel
            // 
            this.tabKundeTabel.Controls.Add(this.dataGridView2);
            this.tabKundeTabel.Location = new System.Drawing.Point(4, 22);
            this.tabKundeTabel.Name = "tabKundeTabel";
            this.tabKundeTabel.Padding = new System.Windows.Forms.Padding(3);
            this.tabKundeTabel.Size = new System.Drawing.Size(856, 604);
            this.tabKundeTabel.TabIndex = 1;
            this.tabKundeTabel.Text = "Kunde Tabel";
            this.tabKundeTabel.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiDDataGridViewTextBoxColumn1,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.kundeBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(850, 598);
            this.dataGridView2.TabIndex = 0;
            // 
            // kiDDataGridViewTextBoxColumn1
            // 
            this.kiDDataGridViewTextBoxColumn1.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn1.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn1.Name = "kiDDataGridViewTextBoxColumn1";
            this.kiDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fuldeNavnDataGridViewTextBoxColumn
            // 
            this.fuldeNavnDataGridViewTextBoxColumn.DataPropertyName = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.HeaderText = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.Name = "fuldeNavnDataGridViewTextBoxColumn";
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn1
            // 
            this.adresseDataGridViewTextBoxColumn1.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn1.Name = "adresseDataGridViewTextBoxColumn1";
            // 
            // kundeBindingSource1
            // 
            this.kundeBindingSource1.DataMember = "Kunde";
            this.kundeBindingSource1.DataSource = this.kaspermark_dk_db_realboligDataSet;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // CreateBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 780);
            this.Controls.Add(this.mOmrådeTextbox);
            this.Controls.Add(this.btnOpretBolig);
            this.Controls.Add(this.btnForslåPris);
            this.Controls.Add(this.mSalgsPrisTextbox);
            this.Controls.Add(this.labelSalgsPris);
            this.Controls.Add(this.mKvmTextbox);
            this.Controls.Add(this.labelKvm);
            this.Controls.Add(this.labelOmråde);
            this.Controls.Add(this.mAdresseTextbox);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.mPostNRTextbox);
            this.Controls.Add(this.labelPostNR);
            this.Controls.Add(this.mKiDTextbox);
            this.Controls.Add(this.labelKiD);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateBolig";
            this.Text = "CreateBolig";
            this.Load += new System.EventHandler(this.CreateBolig_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabBoligTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            this.tabKundeTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermarkdkdbrealboligDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource kaspermarkdkdbrealboligDataSetBindingSource;
        private System.Windows.Forms.MaskedTextBox mOmrådeTextbox;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private System.Windows.Forms.Button btnOpretBolig;
        private System.Windows.Forms.Button btnForslåPris;
        private System.Windows.Forms.MaskedTextBox mSalgsPrisTextbox;
        private System.Windows.Forms.Label labelSalgsPris;
        private System.Windows.Forms.MaskedTextBox mKvmTextbox;
        private System.Windows.Forms.Label labelKvm;
        private System.Windows.Forms.Label labelOmråde;
        private System.Windows.Forms.MaskedTextBox mAdresseTextbox;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.MaskedTextBox mPostNRTextbox;
        private System.Windows.Forms.Label labelPostNR;
        private System.Windows.Forms.MaskedTextBox mKiDTextbox;
        private System.Windows.Forms.Label labelKiD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBoligTabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private System.Windows.Forms.TabPage tabKundeTabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private kaspermark_dk_db_realboligDataSet kaspermark_dk_db_realboligDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource1;
        private kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kundeBindingSource1;
        private kaspermark_dk_db_realboligDataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn1;
    }
}