using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFisioterapeuta_Click(object sender, EventArgs e)
        {
            try

            {
                Fisioterapeuta o_Maria = new Fisioterapeuta(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986, "123/MG", "mariaclara@gmail.com");
                o_Maria.imprimirPessoa();
            }

            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }

        }

        private void Btn_Atendimento_Click(object sender, EventArgs e)
        {
            try
            {
                Atendimento o_Atendimento = new Atendimento(10, "24/05/20", "13h00", "14h00", 2, "equilíbrio no balancim", 50, 02);
                o_Atendimento.imprimirAtendimento();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void Btn_AtendimentoClinica_Click(object sender, EventArgs e)
        {
            try
            {
                AtendimentoClinica o_AtendimentoClinica = new AtendimentoClinica(10, "24/05/20", "13h00", "14h00", 2, "equilíbrio balancim", 50, 02, "Rua Chile, 150", "sala 10");
                o_AtendimentoClinica.imprimirAClinica();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void BtnAtendimentoDomiciliar_Click(object sender, EventArgs e)
        {
            try
            {
                AtendimentoDomiciliar o_AtendimentoDomiciliar = new AtendimentoDomiciliar(10, "24/05/20", "13h00", "14h00", 2, "equilíbrio no balancim", 50, 02, "Rua Oliveira, 25, Ribeirão Preto");
                o_AtendimentoDomiciliar.imprimirADomiciliar();
            }

            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }

        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes o_Maria = new Pacientes(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986, "Atrofia Muscular", "Criança com hiperativismo", "Cassiana Maria A. Oliveira");
                o_Maria.imprimirPaciente();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }
       
        private void BtnResponsavel_Click(object sender, EventArgs e)
        {
            try
            {
                Responsavel o_Maria = new Responsavel(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986, "mariaclara@gmail.com", 988488986, "Pedro Almeida");
                o_Maria.imprimirResponsavel();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void BtnFisioterapeutaResponsavel_Click(object sender, EventArgs e)
        {
            try
            {
                FisioterapeutaResponsavel o_Maria = new FisioterapeutaResponsavel(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986, "123/MG", "mariaclara@gmail.com", 12345678);
                o_Maria.imprimirFResponsavel();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void BtnFisioterapeutaColaboradora_Click(object sender, EventArgs e)
        {
            try
            {
                FisioterapeutaColaboradora o_Maria = new FisioterapeutaColaboradora(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986, "123/MG", "mariaclara@gmail.com", 084440736);
                o_Maria.imprimirFColaboradora();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void BtnPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa o_Maria = new Pessoa(10, "Maria Clara Almeida", "12/12/1990", 14015020, 100, "apto 101", 988488986);
                o_Maria.imprimirPessoa();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void BtnProcedimento_Click(object sender, EventArgs e)
        {
            try
            {
                Procedimentos o_Procedimento = new Procedimentos(15, "equilíbrio no balancim", 4, 10);
                o_Procedimento.imprimirProcedimento();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            try
            {
                Financeiro o_Financeiro = new Financeiro(15, 100);
                o_Financeiro.imprimirFinanceiro();
                //teste do método
                //o_Financeiro.aumentarValorAtendimento();
                //o_Financeiro.imprimirFinanceiro();
            }
            catch (Exception ex) { MessageBox.Show("erro " + ex.Message); }

        }
    }
}
