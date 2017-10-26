using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Medico
/// </summary>
public class Medico : Usuario
{
    int idMedico;
    string nome;
    string endereco;
    string celular;
    Image foto;
    Especializacao especializacao;

    public int IdMedico
    {
        get
        {
            return idMedico;
        }

        set
        {
            idMedico = value;
        }
    }

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            nome = value;
        }
    }

    public string Endereco
    {
        get
        {
            return endereco;
        }

        set
        {
            endereco = value;
        }
    }

    public string Celular
    {
        get
        {
            return celular;
        }

        set
        {
            celular = value;
        }
    }

    public Image Foto
    {
        get
        {
            return foto;
        }

        set
        {
            foto = value;
        }
    }

    public Especializacao Especializacao
    {
        get
        {
            return especializacao;
        }

        set
        {
            especializacao = value;
        }
    }

    public Medico()
    {

    }

    public Medico(int idMedico, int idUsuario, string email, string senha, string nome, string endereco, string celular, Image foto, Especializacao especializacao): base(idUsuario, email, senha, TipoUsuario.MEDICO)
    {
        this.Nome = nome;
        this.Endereco = endereco;
        this.Celular = celular;
        this.Foto = foto;
        this.Especializacao = especializacao;
        this.IdMedico = idMedico;
    }
}