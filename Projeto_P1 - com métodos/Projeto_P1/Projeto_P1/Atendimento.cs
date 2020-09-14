using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Atendimento
{
    //atributos
    protected int codigoAtendimento;
    protected string dataAtendimento;
    protected string horaInicio;
    protected string horaFim;
    protected int tipoAtendimento;
    protected string procedimentosRealizados;
    protected int codigoPaciente;
    protected int codigoFisioterapeuta;


    //propriedades
    public int CodigoAtendimento
    {
        get
        {
            return codigoAtendimento;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um codigo valido!");
            }
            codigoAtendimento = value;
        }
    }
    public string DataAtendimento
    {
        get
        {
            return dataAtendimento;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite uma data valida!");
            }
            dataAtendimento = value;
        }
    }

    public string HoraInicio
    {
        get
        {
            return horaInicio;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite uma hora de inicio valida!");
            }
            horaInicio = value;
        }
    }

    public string HoraFim
    {
        get
        {
            return horaFim;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite uma hora de finalizacao valida!");
            }
            horaFim = value;
        }
    }

    public int TipoAtendimento
    {
        get
        {
            return tipoAtendimento;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("escolha um tipo de atendimento valido!");
            }
            tipoAtendimento = value;
        }
    }

    public int CodigoPaciente
    {
        get
        {
            return codigoPaciente;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Digite um codigo valido!");
            }
            codigoPaciente = value;
        }
    }

    public int CodigoFisioterapeuta
    {
        get
        {
            return codigoFisioterapeuta;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("escolha um tipo de atendimento valido!");
            }
            codigoFisioterapeuta = value;
        }
    }

    public string ProcedimentosRealizados
    {
        get
        {            
            return procedimentosRealizados;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite procedimento válido!");
            }
            procedimentosRealizados = value;
        }
    }

    //construtores

    public Atendimento()
    {
    }

    public Atendimento(int codigoAtendimento, string dataAtendimento, string horaInicio, string horaFim, int tipoAtendimento, string procedimentosRealizados, int codigoPaciente, int codigoFisioterapeuta)
    {
        this.codigoAtendimento=codigoAtendimento;
        this.dataAtendimento=dataAtendimento;
        this.horaInicio=horaInicio;
        this.horaFim=horaFim;
        this.tipoAtendimento=tipoAtendimento;
        this.procedimentosRealizados=procedimentosRealizados;
        this.codigoPaciente=codigoPaciente;
        this.codigoFisioterapeuta=CodigoFisioterapeuta;
    }



    //métodos
    public void imprimirAtendimento()
	{
        Console.WriteLine("--------------------ATENDIMENTOS-------------------------- ");
        Console.WriteLine("Codigo: " + CodigoAtendimento);
        Console.WriteLine("Data do Atendimento: " + DataAtendimento);
        Console.WriteLine("Hora de Inicio: " + HoraInicio);
        Console.WriteLine("Hora de Termino: " + HoraFim);
        Console.WriteLine("Tipo de Atendimento: " + TipoAtendimento);
        Console.WriteLine("Procedimentos Realizados: " + ProcedimentosRealizados);
        Console.WriteLine("Codigo do Paciente: " + CodigoPaciente);

    }

}
