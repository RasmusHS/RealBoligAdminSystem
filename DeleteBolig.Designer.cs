
namespace RealBolig
{
    partial class DeleteBolig
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
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnSletBolig = new System.Windows.Forms.Button();
            this.mBoligIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelBiD = new System.Windows.Forms.Label();
            this.boligTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSetTableAdapters.BoligTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
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
            this.dataGridView1.Location = new System.Drawing.Point(498, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 725);
            this.dataGridView1.TabIndex = 72;
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
            // btnSletBolig
            // 
            this.btnSletBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSletBolig.Location = new System.Drawing.Point(209, 48);
            this.btnSletBolig.Name = "btnSletBolig";
            this.btnSletBolig.Size = new System.Drawing.Size(152, 40);
            this.btnSletBolig.TabIndex = 71;
            this.btnSletBolig.Text = "Slet Bolig";
            this.btnSletBolig.UseVisualStyleBackColor = true;
            this.btnSletBolig.Click += new System.EventHandler(this.btnSletBolig_Click);
            // 
            // mBoligIDTextBox
            // 
            this.mBoligIDTextBox.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBoligIDTextBox.Location = new System.Drawing.Point(127, 12);
            this.mBoligIDTextBox.Name = "mBoligIDTextBox";
            this.mBoligIDTextBox.Size = new System.Drawing.Size(330, 30);
            this.mBoligIDTextBox.TabIndex = 56;
            // 
            // labelBiD
            // 
            this.labelBiD.AutoSize = true;
            this.labelBiD.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiD.Location = new System.Drawing.Point(31, 12);
            this.labelBiD.Name = "labelBiD";
            this.labelBiD.Size = new System.Drawing.Size(88, 26);
            this.labelBiD.TabIndex = 55;
            this.labelBiD.Text = "Bolig ID";
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 960);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSletBolig);
            this.Controls.Add(this.mBoligIDTextBox);
            this.Controls.Add(this.labelBiD);
            this.Name = "DeleteBolig";
            this.Text = "DeleteBolig";
            this.Load += new System.EventHandler(this.DeleteBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource boligBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSletBolig;
        private System.Windows.Forms.MaskedTextBox mBoligIDTextBox;
        private System.Windows.Forms.Label labelBiD;
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
    }
}