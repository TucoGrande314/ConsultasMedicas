using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
/// 
public class Usuario
{
    int idUsuario;
    string email;
    string senha;
    TipoUsuario tipo;

    public int IdUsuario
    {
        get
        {
            return idUsuario;
        }

        set
        {
            idUsuario = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Senha
    {
        get
        {
            return senha;
        }

        set
        {
            senha = value;
        }
    }

    public TipoUsuario Tipo
    {
        get
        {
            return tipo;
        }
        set
        {
            tipo = value;
        }

    }

    public Usuario()
    {

    }

    public Usuario(int idUsuario, string email, string senha, TipoUsuario tipo)
    {
        this.IdUsuario = idUsuario;
        this.Email = email;
        this.Senha = senha;
        this.Tipo = tipo;
    }
}