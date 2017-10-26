using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Especializacao
/// </summary>
public class Especializacao
{
    int idEspecializacao;
    string nomeEspecializacao;

    public Especializacao(int idEspecializacao, string nomeEspecializacao)
    {
        this.idEspecializacao = idEspecializacao;
        this.nomeEspecializacao = nomeEspecializacao;
    }

    public Especializacao()
    {

    }

    public int IdEspecializacao
    {
        get
        {
            return idEspecializacao;
        }

        set
        {
            idEspecializacao = value;
        }
    }

    public string NomeEspecializacao
    {
        get
        {
            return nomeEspecializacao;
        }

        set
        {
            nomeEspecializacao = value;
        }
    }
}