using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AtendimentoClinica : Atendimento
{
	
    //atributos
    
    private string endereco;
	private string sala;

    //propriedades
    public string Endereco
    {
        get
        {
            return endereco;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um Endereco!");
            }
            endereco = value;
        }
    }

    public string Sala
    {
        get
        {
            return sala;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Digite um Endereco!");
            }
            sala = value;
        }
    }

    //construtores

    public AtendimentoClinica()
    {
    }

    public AtendimentoClinica(int codigoAtendimento, string dataAtendimento, string horaInicio, string horaFim, int tipoAtendimento, string procedimentosRealizados, int codigoPaciente, int codigoFisioterapeuta, string endereco, string sala)
    {
        base.codigoAtendimento = codigoAtendimento;
        base.dataAtendimento = dataAtendimento;
        base.horaInicio = horaInicio;
        base.horaFim = horaFim;
        base.tipoAtendimento = tipoAtendimento;
        base.procedimentosRealizados = procedimentosRealizados;
        base.codigoPaciente = codigoPaciente;
        base.codigoFisioterapeuta = codigoFisioterapeuta;
        this.endereco = endereco;
        this.sala = sala;
    }



    //métodos

    public void imprimirAClinica()
	{
        Console.WriteLine("--------------------DADOS ATENDIMENTO CLINICA-------------------------- ");
        base.imprimirAtendimento();
        Console.WriteLine("Endereco do atendimento: " + Endereco);
		Console.WriteLine("Sala do atendimento: " + Sala);

	}

}