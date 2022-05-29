namespace Projeto_Calculadora
{
    partial class HistoricoForm
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
            this.HistoricoGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoricoGridView
            // 
            this.HistoricoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoricoGridView.Location = new System.Drawing.Point(8, 63);
            this.HistoricoGridView.Name = "HistoricoGridView";
            this.HistoricoGridView.RowTemplate.Height = 25;
            this.HistoricoGridView.Size = new System.Drawing.Size(641, 273);
            this.HistoricoGridView.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "TELA 2";
            // 
            // HistoricoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistoricoGridView);
            this.Name = "HistoricoForm";
            this.Text = "HistoricoForm";
            this.Load += new System.EventHandler(this.HistoricoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView HistoricoGridView;
        private Label label2;
    }
}