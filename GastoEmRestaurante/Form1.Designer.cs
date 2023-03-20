
namespace GastoEmRestaurante
{
    partial class FormGastoEmRestaurante
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDespesas = new System.Windows.Forms.Label();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotalPorcentagemDoGarçom = new System.Windows.Forms.Label();
            this.txtTotalPorcentagemDoGarçom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(25, 28);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(57, 13);
            this.lblDespesas.TabIndex = 0;
            this.lblDespesas.Text = "Despesas:";
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(89, 28);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(100, 20);
            this.txtDespesas.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(205, 26);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotalPorcentagemDoGarçom
            // 
            this.lblTotalPorcentagemDoGarçom.AutoSize = true;
            this.lblTotalPorcentagemDoGarçom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPorcentagemDoGarçom.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPorcentagemDoGarçom.Location = new System.Drawing.Point(25, 61);
            this.lblTotalPorcentagemDoGarçom.Name = "lblTotalPorcentagemDoGarçom";
            this.lblTotalPorcentagemDoGarçom.Size = new System.Drawing.Size(94, 13);
            this.lblTotalPorcentagemDoGarçom.TabIndex = 3;
            this.lblTotalPorcentagemDoGarçom.Text = "Total com 10%:";
            // 
            // txtTotalPorcentagemDoGarçom
            // 
            this.txtTotalPorcentagemDoGarçom.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalPorcentagemDoGarçom.Enabled = false;
            this.txtTotalPorcentagemDoGarçom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPorcentagemDoGarçom.Location = new System.Drawing.Point(125, 54);
            this.txtTotalPorcentagemDoGarçom.Name = "txtTotalPorcentagemDoGarçom";
            this.txtTotalPorcentagemDoGarçom.Size = new System.Drawing.Size(169, 20);
            this.txtTotalPorcentagemDoGarçom.TabIndex = 4;
            // 
            // FormGastoEmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 95);
            this.Controls.Add(this.txtTotalPorcentagemDoGarçom);
            this.Controls.Add(this.lblTotalPorcentagemDoGarçom);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.lblDespesas);
            this.Name = "FormGastoEmRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gastos com porcentagem do Garçom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotalPorcentagemDoGarçom;
        private System.Windows.Forms.TextBox txtTotalPorcentagemDoGarçom;
    }
}

