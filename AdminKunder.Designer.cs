
namespace RealBolig
{
    partial class AdminKunder
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
            this.btnDeleteKunde = new System.Windows.Forms.Button();
            this.btnUpdateKunde = new System.Windows.Forms.Button();
            this.btnReadKunde = new System.Windows.Forms.Button();
            this.btnCreateKunder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteKunde
            // 
            this.btnDeleteKunde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteKunde.AutoSize = true;
            this.btnDeleteKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleteKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteKunde.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKunde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteKunde.Location = new System.Drawing.Point(596, 174);
            this.btnDeleteKunde.Name = "btnDeleteKunde";
            this.btnDeleteKunde.Size = new System.Drawing.Size(173, 70);
            this.btnDeleteKunde.TabIndex = 7;
            this.btnDeleteKunde.Text = "Slet Kunde";
            this.btnDeleteKunde.UseVisualStyleBackColor = false;
            // 
            // btnUpdateKunde
            // 
            this.btnUpdateKunde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateKunde.AutoSize = true;
            this.btnUpdateKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnUpdateKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateKunde.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKunde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateKunde.Location = new System.Drawing.Point(408, 174);
            this.btnUpdateKunde.Name = "btnUpdateKunde";
            this.btnUpdateKunde.Size = new System.Drawing.Size(182, 70);
            this.btnUpdateKunde.TabIndex = 6;
            this.btnUpdateKunde.Text = "Opdater Kunde";
            this.btnUpdateKunde.UseVisualStyleBackColor = false;
            // 
            // btnReadKunde
            // 
            this.btnReadKunde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadKunde.AutoSize = true;
            this.btnReadKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReadKunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadKunde.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadKunde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReadKunde.Location = new System.Drawing.Point(227, 174);
            this.btnReadKunde.Name = "btnReadKunde";
            this.btnReadKunde.Size = new System.Drawing.Size(175, 70);
            this.btnReadKunde.TabIndex = 5;
            this.btnReadKunde.Text = "Indlæs Kunder";
            this.btnReadKunde.UseVisualStyleBackColor = false;
            // 
            // btnCreateKunder
            // 
            this.btnCreateKunder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateKunder.AutoSize = true;
            this.btnCreateKunder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCreateKunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKunder.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKunder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateKunder.Location = new System.Drawing.Point(33, 174);
            this.btnCreateKunder.Name = "btnCreateKunder";
            this.btnCreateKunder.Size = new System.Drawing.Size(188, 70);
            this.btnCreateKunder.TabIndex = 4;
            this.btnCreateKunder.Text = "Opret Ny Kunde";
            this.btnCreateKunder.UseVisualStyleBackColor = false;
            // 
            // AdminKunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteKunde);
            this.Controls.Add(this.btnUpdateKunde);
            this.Controls.Add(this.btnReadKunde);
            this.Controls.Add(this.btnCreateKunder);
            this.Name = "AdminKunder";
            this.Text = "AdminKunder";
            this.Load += new System.EventHandler(this.AdminKunder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteKunde;
        private System.Windows.Forms.Button btnUpdateKunde;
        private System.Windows.Forms.Button btnReadKunde;
        private System.Windows.Forms.Button btnCreateKunder;
    }
}