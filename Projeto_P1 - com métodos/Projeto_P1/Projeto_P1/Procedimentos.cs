using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Procedimentos
{
    //atributos
    private int codigo;
    private string descricao;
    private int numSeries;
    private int numRepeticoes;

    //propriedades
    public string Descricao
    {
        get
        {
            return descricao;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite uma descricao valida!");
            }
            descricao = value;
        }
    }

    public int Codigo
    {
        get
        {
            return codigo;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um codigo valido!");
            }
            codigo = value;
        }
    }

    public int NumSerie
    {
        get
        {
            return numSeries;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite o numero de series!");
            }
            numSeries = value;
        }
    }

    public int NumRepeticoes
    {
        get
        {
            return numRepeticoes;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite o numero de repeticoes!");
            }
            numRepeticoes = value;
        }
    }

    //construtores
    public Procedimentos()
    {
    }

    public Procedimentos(int codigo, string descricao, int numSeries, int numRepeticoes)
    {
        this.codigo=codigo;
        this.descricao = descricao;
        this.numSeries=numSeries;
        this.numRepeticoes=numRepeticoes;
    }

    //métodos
    public void imprimirProcedimento()
	{
        Console.WriteLine("-------------------PROCEDIMENTOS--------------------- ");
        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Descricao: " + Descricao);
        Console.WriteLine("Numero de Series: " + NumSerie);
        Console.WriteLine("Num de Repetiçoes: " + NumRepeticoes);
    }

}
