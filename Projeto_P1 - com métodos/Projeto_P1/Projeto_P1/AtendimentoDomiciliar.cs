using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AtendimentoDomiciliar : Atendimento
{
    //atributos
	private string localizacao;

    //propriedades

    public string Localizacao
    {
        get
        {
            return localizacao;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um complemento valida!");
            }
            localizacao = value;
        }
    }

    //construtores

    public AtendimentoDomiciliar()
    {
    }

    public AtendimentoDomiciliar(int codigoAtendimento, string dataAtendimento, string horaInicio, string horaFim, int tipoAtendimento, string procedimentosRealizados, int codigoPaciente, int codigoFisioterapeuta, string localizacao)
    {
        base.codigoAtendimento = codigoAtendimento;
        base.dataAtendimento = dataAtendimento;
        base.horaInicio = horaInicio;
        base.horaFim = horaFim;
        base.tipoAtendimento = tipoAtendimento;
        base.procedimentosRealizados = procedimentosRealizados;
        base.codigoPaciente = codigoPaciente;
        base.codigoFisioterapeuta = codigoFisioterapeuta;
        this.localizacao = localizacao;
    }

    //métodos

    public void imprimirADomiciliar()
	{
        Console.WriteLine("-------------------DADOS ATENDIMENTO DOMICILIAR--------------------- ");
        base.imprimirAtendimento();
        Console.WriteLine("Localizaçao: " + Localizacao);

    }

}