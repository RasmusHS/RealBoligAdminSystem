
namespace RealBolig
{
    partial class UpdateKunde
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
            this.dataGridViewOpdaterKunder = new System.Windows.Forms.DataGridView();
            this.kaspermark_dk_db_realboligDataSet1 = new RealBolig.kaspermark_dk_db_realboligDataSet1();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new RealBolig.kaspermark_dk_db_realboligDataSet1TableAdapters.KundeTableAdapter();
            this.kiDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuldeNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelKundeOpdateringsDataGridView = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpdaterKunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            this.panelKundeOpdateringsDataGridView.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOpdaterKunder
            // 
            this.dataGridViewOpdaterKunder.AutoGenerateColumns = false;
            this.dataGridViewOpdaterKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpdaterKunder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiDDataGridViewTextBoxColumn,
            this.fuldeNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridViewOpdaterKunder.DataSource = this.kundeBindingSource;
            this.dataGridViewOpdaterKunder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOpdaterKunder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOpdaterKunder.Name = "dataGridViewOpdaterKunder";
            this.dataGridViewOpdaterKunder.RowHeadersWidth = 51;
            this.dataGridViewOpdaterKunder.RowTemplate.Height = 24;
            this.dataGridViewOpdaterKunder.Size = new System.Drawing.Size(936, 240);
            this.dataGridViewOpdaterKunder.TabIndex = 0;
            // 
            // kaspermark_dk_db_realboligDataSet1
            // 
            this.kaspermark_dk_db_realboligDataSet1.DataSetName = "kaspermark_dk_db_realboligDataSet1";
            this.kaspermark_dk_db_realboligDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.kaspermark_dk_db_realboligDataSet1;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // kiDDataGridViewTextBoxColumn
            // 
            this.kiDDataGridViewTextBoxColumn.DataPropertyName = "KiD";
            this.kiDDataGridViewTextBoxColumn.HeaderText = "KiD";
            this.kiDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiDDataGridViewTextBoxColumn.Name = "kiDDataGridViewTextBoxColumn";
            this.kiDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuldeNavnDataGridViewTextBoxColumn
            // 
            this.fuldeNavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fuldeNavnDataGridViewTextBoxColumn.DataPropertyName = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.HeaderText = "FuldeNavn";
            this.fuldeNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuldeNavnDataGridViewTextBoxColumn.Name = "fuldeNavnDataGridViewTextBoxColumn";
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "Tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "Tlf";
            this.tlfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            this.tlfDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // panelKundeOpdateringsDataGridView
            // 
            this.panelKundeOpdateringsDataGridView.Controls.Add(this.dataGridViewOpdaterKunder);
            this.panelKundeOpdateringsDataGridView.Location = new System.Drawing.Point(122, 75);
            this.panelKundeOpdateringsDataGridView.Name = "panelKundeOpdateringsDataGridView";
            this.panelKundeOpdateringsDataGridView.Size = new System.Drawing.Size(936, 240);
            this.panelKundeOpdateringsDataGridView.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(122, 320);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 50);
            this.panel3.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(253, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 29);
            this.label3.TabIndex = 86;
            this.label3.Text = "ÆNDRING AF KUNDEOPLYSNINGER";
            // 
            // UpdateKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 958);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelKundeOpdateringsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateKunde";
            this.Text = "UpdateKunde";
            this.Load += new System.EventHandler(this.UpdateKunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpdaterKunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_realboligDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            this.panelKundeOpdateringsDataGridView.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOpdaterKunder;
        private kaspermark_dk_db_realboligDataSet1 kaspermark_dk_db_realboligDataSet1;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private kaspermark_dk_db_realboligDataSet1TableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuldeNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelKundeOpdateringsDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}