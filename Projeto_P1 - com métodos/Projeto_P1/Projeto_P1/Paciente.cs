using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pacientes : Pessoa
{
    //atributo
	private string diagnostico;
	private string informacaoExtra;
	private string responsavel;

    //propriedade
    public string Diagnostico
    {
        get
        {
            return diagnostico;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um diagnostico!");
            }
            diagnostico = value;
        }
    }
    public string InformacaoExtra
    {
        get
        {
            return informacaoExtra;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um complemento valida!");
            }
            informacaoExtra = value;
        }
    }

    public string Responsavel
    {
        get
        {
            return responsavel; 
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um responsavel!");
            }
            responsavel = value;
        }
    }

    //construtores
    public Pacientes()
    {
    }

    public Pacientes (int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato, string diagnostico, string informacaoExtra, string responsavel)
    {
        base.codigoPessoa = codigoPessoa;
        base.nome = nome;
        base.dataNascimento = dataNascimento;
        base.cep = cep;
        base.numeroCasa = numeroCasa;
        base.complemento = complemento;
        base.telContato = telContato;
        this.diagnostico = diagnostico;
        this.informacaoExtra = informacaoExtra;
        this.responsavel = responsavel;
    }

    //métodos
    public void imprimirPaciente()
	{
        Console.WriteLine("--------------------PACIENTES-------------------------- ");
        base.imprimirPessoa();
        Console.WriteLine("Diagnostico do paciente: " + Diagnostico);
        Console.WriteLine("Informaçoes extra do paciente: " + InformacaoExtra);
        Console.WriteLine("Responsável pelo paciente: " + Responsavel);
    }

}
