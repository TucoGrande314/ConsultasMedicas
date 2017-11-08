using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Secretaria
/// </summary>
public class Secretaria :Usuario
{
    int idSecretaria;
    string nome;
    string celular;

    public int IdSecretaria
    {
        get
        {
            return idSecretaria;
        }

        set
        {
            idSecretaria = value;
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

    public Secretaria(int idSecretaria, int idUsuario, string email, string senha ,string nome, string celular) : base(idUsuario, email, senha, TipoUsuario.SECRETARIA) 
    {
        this.IdSecretaria = idSecretaria;
        this.Nome = nome;
        this.Celular = celular;
        this.Tipo = TipoUsuario.SECRETARIA;
    }
    public Secretaria()
    {

    }
}