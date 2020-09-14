using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pessoa
{
	//Atributos
    protected int codigoPessoa;
    protected string nome;
    protected string dataNascimento;
    protected int cep;
    protected int numeroCasa;
    protected string complemento;
    protected int telContato;


    //propriedades
    public int CodigoPessoa
    {
        get
        {
            return codigoPessoa;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um codigo valido!");
            }
            codigoPessoa = value;
        }

    }

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um nome valido!");
            }
            nome = value;
        }
    }

    public string DataNascimento
    {
        get
        {
            return dataNascimento;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite uma data valida!");
            }
            dataNascimento = value;
        }
    }

    public int Cep
    {
        get
        {
            return cep;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um CEP valido!");
            }
            cep = value;
        }
    }

    public int NumeroCasa
    {
        get
        {
            return numeroCasa;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um numero valido!");
            }
            numeroCasa = value;
        }
    }

    public string Complemento
    {
        get
        {
            return complemento;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um complemento valida!");
            }
            complemento = value;
        }
    }

    public int TelContato
    {
        get
        {
            return telContato;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um telefone de contato valido!");
            }
            telContato = value;
        }
    }

    //construtor
    public Pessoa()
    {
    }

    public Pessoa(int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato)
    {
        this.codigoPessoa = codigoPessoa;
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.cep = cep;
        this.numeroCasa = numeroCasa;
        this.complemento = complemento;
        this.telContato = telContato;
        
    }

    //métodos
    public void imprimirPessoa()
	{
        Console.WriteLine("-------------------DADOS PESSOA--------------------- ");
        Console.WriteLine("Codigo: " + CodigoPessoa);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Data de Nascimento: " + DataNascimento);
        Console.WriteLine("CEP: " + Cep);
        Console.WriteLine("Numero da casa: " + NumeroCasa);
        Console.WriteLine("Complemento: " + Complemento);
        Console.WriteLine("Telefone de contato: " + TelContato);

    }

}
