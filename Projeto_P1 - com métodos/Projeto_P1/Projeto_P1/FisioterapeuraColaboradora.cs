using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FisioterapeutaColaboradora : Fisioterapeuta
{
    //atributo
    private int cpf;

    //propriedade
    public int Cpf
    {
        get
        {
            return cpf;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um CPF valido!");
            }
            cpf = value;
        }
    }

    //construtores
    public FisioterapeutaColaboradora()
    {

    }

    public FisioterapeutaColaboradora(int codigoPessoa, string nome, string dataNascimento, int cep, int numeroCasa, string complemento, int telContato, string crefito, string email, int cpf)
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

        this.cpf = cpf;
    }

    //métodos
    public void imprimirFColaboradora()
	{
        Console.WriteLine("-----------------DADOS FISIOTERAPEUTA COLABORADORA------------------ ");
        base.imprimirFisioterapeuta();
        Console.WriteLine("CPF da Fisioterapeuta Colaboradora: " + Cpf);
        
    }

}