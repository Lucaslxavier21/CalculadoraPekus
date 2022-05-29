namespace Projeto_Calculadora
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorA = new System.Windows.Forms.NumericUpDown();
            this.valorB = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TELA 1";
            // 
            // adicao
            // 
            this.adicao.Location = new System.Drawing.Point(148, 12);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(94, 35);
            this.adicao.TabIndex = 4;
            this.adicao.Tag = "+";
            this.adicao.Text = "Adição";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(248, 12);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(94, 35);
            this.subtracao.TabIndex = 5;
            this.subtracao.Tag = "-";
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(148, 53);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(94, 35);
            this.multiplicacao.TabIndex = 6;
            this.multiplicacao.Tag = "*";
            this.multiplicacao.Text = "Multiplicação";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(248, 53);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(94, 35);
            this.divisao.TabIndex = 7;
            this.divisao.Tag = "/";
            this.divisao.Text = "Divisão ";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor B";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Projeto_Calculadora.Models.Product);
            // 
            // valorA
            // 
            this.valorA.Location = new System.Drawing.Point(12, 69);
            this.valorA.Name = "valorA";
            this.valorA.Size = new System.Drawing.Size(120, 23);
            this.valorA.TabIndex = 13;
            // 
            // valorB
            // 
            this.valorB.Location = new System.Drawing.Point(12, 129);
            this.valorB.Name = "valorB";
            this.valorB.Size = new System.Drawing.Size(120, 23);
            this.valorB.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Historico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valorB);
            this.Controls.Add(this.valorA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button adicao;
        private Button subtracao;
        private Button multiplicacao;
        private Button divisao;
        private Label label3;
        private Label label4;
        private BindingSource productBindingSource;
        private NumericUpDown valorA;
        private NumericUpDown valorB;
        private Button button1;
    }
}