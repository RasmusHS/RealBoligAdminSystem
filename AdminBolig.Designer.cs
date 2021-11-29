
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
            this.SuspendLayout();
            // 
            // btnCreateBolig
            // 
            this.btnCreateBolig.Location = new System.Drawing.Point(132, 180);
            this.btnCreateBolig.Name = "btnCreateBolig";
            this.btnCreateBolig.Size = new System.Drawing.Size(124, 56);
            this.btnCreateBolig.TabIndex = 0;
            this.btnCreateBolig.Text = "Opret Ny Bolig";
            this.btnCreateBolig.UseVisualStyleBackColor = true;
            this.btnCreateBolig.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnReadBolig
            // 
            this.btnReadBolig.Location = new System.Drawing.Point(262, 180);
            this.btnReadBolig.Name = "btnReadBolig";
            this.btnReadBolig.Size = new System.Drawing.Size(124, 56);
            this.btnReadBolig.TabIndex = 1;
            this.btnReadBolig.Text = "Indlæs Boliger";
            this.btnReadBolig.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBolig
            // 
            this.btnUpdateBolig.Location = new System.Drawing.Point(392, 180);
            this.btnUpdateBolig.Name = "btnUpdateBolig";
            this.btnUpdateBolig.Size = new System.Drawing.Size(124, 56);
            this.btnUpdateBolig.TabIndex = 2;
            this.btnUpdateBolig.Text = "Opdater Bolig";
            this.btnUpdateBolig.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBolig
            // 
            this.btnDeleteBolig.Location = new System.Drawing.Point(522, 180);
            this.btnDeleteBolig.Name = "btnDeleteBolig";
            this.btnDeleteBolig.Size = new System.Drawing.Size(124, 56);
            this.btnDeleteBolig.TabIndex = 3;
            this.btnDeleteBolig.Text = "Slet Bolig";
            this.btnDeleteBolig.UseVisualStyleBackColor = true;
            // 
            // AdminBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteBolig);
            this.Controls.Add(this.btnUpdateBolig);
            this.Controls.Add(this.btnReadBolig);
            this.Controls.Add(this.btnCreateBolig);
            this.Name = "AdminBolig";
            this.Text = "AdminBolig";
            this.Load += new System.EventHandler(this.AdminBolig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBolig;
        private System.Windows.Forms.Button btnReadBolig;
        private System.Windows.Forms.Button btnUpdateBolig;
        private System.Windows.Forms.Button btnDeleteBolig;
    }
}