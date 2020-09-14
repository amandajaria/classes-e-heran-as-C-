using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Financeiro
{
    //Atributos
    protected float custoAtendimento;
    protected float valorAtendimento;
    protected float lucroAtendimento;

    //propriedades
    public float CustoAtendimento
    {
        get
        {
            return custoAtendimento;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um valor valido!");
            }
            custoAtendimento = value;
        }
    }

    public float ValorAtendimento
    {
        get
        {
            return valorAtendimento;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um valor valido!");
            }
            valorAtendimento = value;
        }
    }

    public float LucroAtendimento
    {
        get
        {
            return lucroAtendimento;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um valor valido!");
            }
            lucroAtendimento = value;
        }
    }

    //construtor

    public Financeiro()
    {
    }

    public Financeiro (float custoAtendimento, float valorAtendimento)
    {
        this.custoAtendimento = custoAtendimento;
        this.valorAtendimento = valorAtendimento;
        this.lucroAtendimento = valorAtendimento - custoAtendimento;

    }

    //métodos

    public void imprimirFinanceiro()
    {
        Console.WriteLine("-------------------DADOS FINANCEIRO--------------------- ");
        Console.WriteLine("Custo do Atendimento: " + CustoAtendimento);
        Console.WriteLine("Valor do Atendimento: " + ValorAtendimento);
        Console.WriteLine("Lucro do Atendimento: " + LucroAtendimento);
    }

    public void aumentarValorAtendimento()
    {
        this.valorAtendimento = this.valorAtendimento + 10;
        this.lucroAtendimento = valorAtendimento - custoAtendimento;
    }

    public void diminuirValorAtendimento()
    {
        this.valorAtendimento = this.valorAtendimento - 10;
        this.lucroAtendimento = valorAtendimento - custoAtendimento;
    }

    public void aumentarCustoAtendimento()
    {
        this.custoAtendimento = this.custoAtendimento + 10;
        this.lucroAtendimento = valorAtendimento - custoAtendimento;
    }

    public void diminuirCustoAtendimento()
    {
        this.custoAtendimento = this.custoAtendimento - 10;
        this.lucroAtendimento = valorAtendimento - custoAtendimento;
    }
}