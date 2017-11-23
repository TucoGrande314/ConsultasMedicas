using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Consulta
/// </summary>
public class Consulta
{
    private int id;
    private Paciente paciente;
    private Medico medico;
    private DateTime dataConsulta;
    private DateTime inicioConsulta;
    private int duracao;
    private string stat;

    public string hora;

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

    public Paciente Paciente
    {
        get
        {
            return paciente;
        }

        set
        {
            paciente = value;
        }
    }

    public Medico Medico
    {
        get
        {
            return medico;
        }

        set
        {
            medico = value;
        }
    }

    public DateTime DataConsulta
    {
        get
        {
            return dataConsulta;
        }

        set
        {
            dataConsulta = value;
        }
    }

    public DateTime InicioConsulta
    {
        get
        {
            return inicioConsulta;
        }

        set
        {
            inicioConsulta = value;
        }
    }

    public int Duracao
    {
        get
        {
            return duracao;
        }

        set
        {
            duracao = value;
        }
    }

    public string Stat
    {
        get
        {
            return stat;
        }

        set
        {
            stat = value;
        }
    }

    public Consulta()
    {
        
    }

    public Consulta(int id, Paciente paciente, Medico medico, DateTime dataConsulta, DateTime inicioConsulta, int duracao, string stat)
    {
        this.id = id;
        this.paciente = paciente;
        this.medico = medico;
        this.dataConsulta = dataConsulta;
        this.inicioConsulta = inicioConsulta;
        this.duracao = duracao;
        this.stat = stat;
    }
}