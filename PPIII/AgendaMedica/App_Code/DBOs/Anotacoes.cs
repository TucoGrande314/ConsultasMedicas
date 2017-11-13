using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Anotacoes
/// </summary>
public class Anotacoes
{
    private int id;
    private Consulta consulta;
    private string resultado;
    private string diagnostico;
    private string medicacao;

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public Consulta Consulta
    {
        get
        {
            return consulta;
        }

        set
        {
            consulta = value;
        }
    }

    public string Resultado
    {
        get
        {
            return resultado;
        }

        set
        {
            resultado = value;
        }
    }

    public string Diagnostico
    {
        get
        {
            return diagnostico;
        }

        set
        {
            diagnostico = value;
        }
    }

    public string Medicacao
    {
        get
        {
            return medicacao;
        }

        set
        {
            medicacao = value;
        }
    }

    public Anotacoes()
    {
    }

    public Anotacoes(int id, Consulta consulta, string resultado, string diagnostico, string medicacao)
    {
        this.id = id;
        this.consulta = consulta;
        this.resultado = resultado;
        this.diagnostico = diagnostico;
        this.medicacao = medicacao;
    }
}