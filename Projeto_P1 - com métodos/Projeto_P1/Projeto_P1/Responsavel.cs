using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Responsavel : Pessoa
{
    //atributo
	private string email;
	private int celular;
	private string tutorado; 

    //propriedades

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um e-mail valido!");
            }
            email = value;
        }
    }

    public int Celular
    {
        get
        {
            return celular;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um celular de contato valido!");
            }
            celular = value;
        }
    }

    public string Tutorado
    {
        get
        {
            return tutorado;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um tutorado!");
            }
            tutorado = value;
        }
    }

    //construtores
    public Responsavel()
    {
    }

    public Responsavel(int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato, string email, int celular, string tutorado)
    {
        base.codigoPessoa = codigoPessoa;
        base.nome = nome;
        base.dataNascimento = dataNascimento;
        base.cep = cep;
        base.numeroCasa = numeroCasa;
        base.complemento = complemento;
        base.telContato = telContato;
        this.email = email;
        this.celular = celular;
        this.tutorado = tutorado;
    }

    //métodos
    public void imprimirResponsavel()
	{
        Console.WriteLine("-------------------DADOS DO RESPONSAVEL--------------------- ");
        base.imprimirPessoa();
        Console.WriteLine("Numero da casa: " + Email);
		Console.WriteLine("Complemento: " + Celular);
        Console.WriteLine("Tutorado: " + Tutorado);

	}

}

