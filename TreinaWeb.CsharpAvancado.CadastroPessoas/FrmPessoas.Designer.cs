namespace TreinaWeb.CsharpAvancado.CadastroPessoas
{
    partial class FrmPessoas
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
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.btnAdiciomar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(12, 12);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(776, 328);
            this.dgvPessoas.TabIndex = 0;
            // 
            // btnAdiciomar
            // 
            this.btnAdiciomar.Location = new System.Drawing.Point(12, 346);
            this.btnAdiciomar.Name = "btnAdiciomar";
            this.btnAdiciomar.Size = new System.Drawing.Size(121, 38);
            this.btnAdiciomar.TabIndex = 1;
            this.btnAdiciomar.Text = "Adicionar Pessoas";
            this.btnAdiciomar.UseVisualStyleBackColor = true;
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdiciomar);
            this.Controls.Add(this.dgvPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnAdiciomar;
    }
}