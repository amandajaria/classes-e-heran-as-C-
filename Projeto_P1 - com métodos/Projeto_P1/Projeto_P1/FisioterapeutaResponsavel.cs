using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FisioterapeutaResponsavel : Fisioterapeuta
{
	//atributo
    private int cnpj;

    //propriedade
    public int Cnpj
    {
        get
        {
            return cnpj;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um CNPJ valido!");
            }
            cnpj = value;
        }
    }

    //construtores
    public FisioterapeutaResponsavel()
    {
    }

    public FisioterapeutaResponsavel(int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato, string crefito, string email, int cnpj)
    {
        base.codigoPessoa = codigoPessoa;
        base.nome = nome;
        base.dataNascimento = dataNascimento;
        base.cep = cep;
        base.numeroCasa = numeroCasa;
        base.complemento = complemento;
        base.telContato = telContato;

        base.crefito = crefito;
        base.email = email;

        this.cnpj = cnpj;
    }

    //métodos
    public void imprimirFResponsavel()
	{
        Console.WriteLine("-------------------FISIOTERAPEUTA RESPONSAVEL--------------------- ");
        base.imprimirFisioterapeuta();
        Console.WriteLine("CNPJ: " + Cnpj);
    }

}
