namespace Projeto_P1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Atendimento = new System.Windows.Forms.Button();
            this.btn_AtendimentoClinica = new System.Windows.Forms.Button();
            this.btnAtendimentoDomiciliar = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnResponsavel = new System.Windows.Forms.Button();
            this.btnFisioterapeuta = new System.Windows.Forms.Button();
            this.btnFisioterapeutaResponsavel = new System.Windows.Forms.Button();
            this.btnFisioterapeutaColaboradora = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.btnProcedimento = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.Location = new System.Drawing.Point(65, 40);
            this.btn_Atendimento.Name = "btn_Atendimento";
            this.btn_Atendimento.Size = new System.Drawing.Size(81, 44);
            this.btn_Atendimento.TabIndex = 0;
            this.btn_Atendimento.Text = "Atendimento";
            this.btn_Atendimento.UseVisualStyleBackColor = true;
            this.btn_Atendimento.Click += new System.EventHandler(this.Btn_Atendimento_Click);
            // 
            // btn_AtendimentoClinica
            // 
            this.btn_AtendimentoClinica.Location = new System.Drawing.Point(172, 40);
            this.btn_AtendimentoClinica.Name = "btn_AtendimentoClinica";
            this.btn_AtendimentoClinica.Size = new System.Drawing.Size(87, 44);
            this.btn_AtendimentoClinica.TabIndex = 1;
            this.btn_AtendimentoClinica.Text = "Atendimento Clínica";
            this.btn_AtendimentoClinica.UseVisualStyleBackColor = true;
            this.btn_AtendimentoClinica.Click += new System.EventHandler(this.Btn_AtendimentoClinica_Click);
            // 
            // btnAtendimentoDomiciliar
            // 
            this.btnAtendimentoDomiciliar.Location = new System.Drawing.Point(286, 40);
            this.btnAtendimentoDomiciliar.Name = "btnAtendimentoDomiciliar";
            this.btnAtendimentoDomiciliar.Size = new System.Drawing.Size(88, 44);
            this.btnAtendimentoDomiciliar.TabIndex = 2;
            this.btnAtendimentoDomiciliar.Text = "Atendimento Domiciliar";
            this.btnAtendimentoDomiciliar.UseVisualStyleBackColor = true;
            this.btnAtendimentoDomiciliar.Click += new System.EventHandler(this.BtnAtendimentoDomiciliar_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(403, 40);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(84, 44);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // btnResponsavel
            // 
            this.btnResponsavel.Location = new System.Drawing.Point(520, 40);
            this.btnResponsavel.Name = "btnResponsavel";
            this.btnResponsavel.Size = new System.Drawing.Size(84, 44);
            this.btnResponsavel.TabIndex = 4;
            this.btnResponsavel.Text = "Responsável";
            this.btnResponsavel.UseVisualStyleBackColor = true;
            this.btnResponsavel.Click += new System.EventHandler(this.BtnResponsavel_Click);
            // 
            // btnFisioterapeuta
            // 
            this.btnFisioterapeuta.Location = new System.Drawing.Point(65, 132);
            this.btnFisioterapeuta.Name = "btnFisioterapeuta";
            this.btnFisioterapeuta.Size = new System.Drawing.Size(81, 44);
            this.btnFisioterapeuta.TabIndex = 5;
            this.btnFisioterapeuta.Text = "Fisioterapeuta";
            this.btnFisioterapeuta.UseVisualStyleBackColor = true;
            this.btnFisioterapeuta.Click += new System.EventHandler(this.BtnFisioterapeuta_Click);
            // 
            // btnFisioterapeutaResponsavel
            // 
            this.btnFisioterapeutaResponsavel.Location = new System.Drawing.Point(172, 132);
            this.btnFisioterapeutaResponsavel.Name = "btnFisioterapeutaResponsavel";
            this.btnFisioterapeutaResponsavel.Size = new System.Drawing.Size(87, 44);
            this.btnFisioterapeutaResponsavel.TabIndex = 6;
            this.btnFisioterapeutaResponsavel.Text = "Fisioterapeuta Responsável";
            this.btnFisioterapeutaResponsavel.UseVisualStyleBackColor = true;
            this.btnFisioterapeutaResponsavel.Click += new System.EventHandler(this.BtnFisioterapeutaResponsavel_Click);
            // 
            // btnFisioterapeutaColaboradora
            // 
            this.btnFisioterapeutaColaboradora.Location = new System.Drawing.Point(286, 132);
            this.btnFisioterapeutaColaboradora.Name = "btnFisioterapeutaColaboradora";
            this.btnFisioterapeutaColaboradora.Size = new System.Drawing.Size(88, 44);
            this.btnFisioterapeutaColaboradora.TabIndex = 7;
            this.btnFisioterapeutaColaboradora.Text = "Fisioterapeuta Colaboradora";
            this.btnFisioterapeutaColaboradora.UseVisualStyleBackColor = true;
            this.btnFisioterapeutaColaboradora.Click += new System.EventHandler(this.BtnFisioterapeutaColaboradora_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(403, 131);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(84, 45);
            this.btnPessoa.TabIndex = 8;
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.BtnPessoa_Click);
            // 
            // btnProcedimento
            // 
            this.btnProcedimento.Location = new System.Drawing.Point(520, 132);
            this.btnProcedimento.Name = "btnProcedimento";
            this.btnProcedimento.Size = new System.Drawing.Size(84, 44);
            this.btnProcedimento.TabIndex = 9;
            this.btnProcedimento.Text = "Procedimento";
            this.btnProcedimento.UseVisualStyleBackColor = true;
            this.btnProcedimento.Click += new System.EventHandler(this.BtnProcedimento_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Location = new System.Drawing.Point(632, 40);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(95, 45);
            this.btnFinanceiro.TabIndex = 10;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 219);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnPessoa);
            this.Controls.Add(this.btnFisioterapeutaColaboradora);
            this.Controls.Add(this.btnFisioterapeutaResponsavel);
            this.Controls.Add(this.btnFisioterapeuta);
            this.Controls.Add(this.btnResponsavel);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAtendimentoDomiciliar);
            this.Controls.Add(this.btn_AtendimentoClinica);
            this.Controls.Add(this.btn_Atendimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projeto POO - P1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Atendimento;
        private System.Windows.Forms.Button btn_AtendimentoClinica;
        private System.Windows.Forms.Button btnAtendimentoDomiciliar;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnResponsavel;
        private System.Windows.Forms.Button btnFisioterapeuta;
        private System.Windows.Forms.Button btnFisioterapeutaResponsavel;
        private System.Windows.Forms.Button btnFisioterapeutaColaboradora;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Button btnProcedimento;
        private System.Windows.Forms.Button btnFinanceiro;
    }
}

