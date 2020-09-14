using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fisioterapeuta : Pessoa
{
	//atributo
    protected string crefito;
	protected string email;

    //propriedade
    public string Crefito
    {
        get
        {
            return crefito;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um CREFITO valido!");
            }
            crefito = value;
        }
    }

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

    //construtores
    public Fisioterapeuta()
    {

    }

    public Fisioterapeuta (int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato, string crefito, string email)
    {
        base.codigoPessoa = codigoPessoa;
        base.nome = nome;
        base.dataNascimento = dataNascimento;
        base.cep = cep;
        base.numeroCasa = numeroCasa;
        base.complemento = complemento;
        base.telContato = telContato;
        this.crefito = crefito;
        this.email = email;
    }

    //métodos
    public void imprimirFisioterapeuta()
	{
        Console.WriteLine("-------------------DADOS FISIOTERAPEUTA--------------------- ");
        base.imprimirPessoa();
        Console.WriteLine("CREFITO: " + Crefito);
        Console.WriteLine("Email: " + Email);
    }

}