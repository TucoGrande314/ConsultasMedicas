using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Paciente
/// </summary>
public class Paciente : Usuario
{
    int idPaciente;
    string nome;
    DateTime dataNascimento;
    string endereco;
    string celular;
    Image foto;

    public Paciente() : base()
    {

    }

    public Paciente(int idUsuario, string email, string senha, int idPaciente, string nome, DateTime dataNascimento, string endereco, string celular, Image foto) : base(idUsuario, email, senha, TipoUsuario.PACIENTE)
    {
        this.IdPaciente = idPaciente;
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.Endereco = endereco;
        this.Celular = celular;
        this.Foto = foto;
        this.Tipo = TipoUsuario.PACIENTE;
    }


    public int IdPaciente
    {
        get
        {
            return idPaciente;
        }

        set
        {
            idPaciente = value;
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

    public DateTime DataNascimento
    {
        get
        {
            return dataNascimento;
        }

        set
        {
            dataNascimento = value;
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

}