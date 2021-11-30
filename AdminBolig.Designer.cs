
namespace RealBolig
{
    partial class AdminBolig
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
            this.btnCreateBolig = new System.Windows.Forms.Button();
            this.btnReadBolig = new System.Windows.Forms.Button();
            this.btnUpdateBolig = new System.Windows.Forms.Button();
            this.btnDeleteBolig = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCreateBolig
            // 
            this.btnCreateBolig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateBolig.AutoSize = true;
            this.btnCreateBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCreateBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBolig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateBolig.Location = new System.Drawing.Point(79, 176);
            this.btnCreateBolig.Name = "btnCreateBolig";
            this.btnCreateBolig.Size = new System.Drawing.Size(174, 70);
            this.btnCreateBolig.TabIndex = 0;
            this.btnCreateBolig.Text = "Opret Ny Bolig";
            this.btnCreateBolig.UseVisualStyleBackColor = false;
            this.btnCreateBolig.Click += new System.EventHandler(this.btnCreateBolig_Click);
            // 
            // btnReadBolig
            // 
            this.btnReadBolig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadBolig.AutoSize = true;
            this.btnReadBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReadBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadBolig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReadBolig.Location = new System.Drawing.Point(258, 176);
            this.btnReadBolig.Name = "btnReadBolig";
            this.btnReadBolig.Size = new System.Drawing.Size(173, 70);
            this.btnReadBolig.TabIndex = 1;
            this.btnReadBolig.Text = "Indlæs Boliger";
            this.btnReadBolig.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBolig
            // 
            this.btnUpdateBolig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateBolig.AutoSize = true;
            this.btnUpdateBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnUpdateBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBolig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateBolig.Location = new System.Drawing.Point(437, 176);
            this.btnUpdateBolig.Name = "btnUpdateBolig";
            this.btnUpdateBolig.Size = new System.Drawing.Size(173, 70);
            this.btnUpdateBolig.TabIndex = 2;
            this.btnUpdateBolig.Text = "Opdater Bolig";
            this.btnUpdateBolig.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBolig
            // 
            this.btnDeleteBolig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteBolig.AutoSize = true;
            this.btnDeleteBolig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleteBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBolig.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBolig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteBolig.Location = new System.Drawing.Point(616, 176);
            this.btnDeleteBolig.Name = "btnDeleteBolig";
            this.btnDeleteBolig.Size = new System.Drawing.Size(173, 70);
            this.btnDeleteBolig.TabIndex = 3;
            this.btnDeleteBolig.Text = "Slet Bolig";
            this.btnDeleteBolig.UseVisualStyleBackColor = false;
            // 
            // pContainer
            // 
            this.pContainer.AutoSize = true;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(871, 442);
            this.pContainer.TabIndex = 4;
            // 
            // AdminBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 442);
            this.Controls.Add(this.btnDeleteBolig);
            this.Controls.Add(this.btnUpdateBolig);
            this.Controls.Add(this.btnReadBolig);
            this.Controls.Add(this.btnCreateBolig);
            this.Controls.Add(this.pContainer);
            this.Name = "AdminBolig";
            this.Text = "AdminBolig";
            this.Load += new System.EventHandler(this.AdminBolig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBolig;
        private System.Windows.Forms.Button btnReadBolig;
        private System.Windows.Forms.Button btnUpdateBolig;
        private System.Windows.Forms.Button btnDeleteBolig;
        private System.Windows.Forms.Panel pContainer;
    }
}