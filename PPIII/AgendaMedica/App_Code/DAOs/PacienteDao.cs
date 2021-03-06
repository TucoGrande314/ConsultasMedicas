﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Drawing;

/// <summary>
/// Summary description for PacienteDao
/// </summary>
public class PacienteDao
{
    public PacienteDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static Paciente UsuarioToPaciente(Usuario usuario) {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        else
        {
            Dao.FecharConexao();
            Dao.AbrirConexao();
        }
        SqlDataReader drDados;

        string comando = "SELECT * FROM Paciente WHERE id_usuario = "+usuario.IdUsuario;
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
       // comSql.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

        drDados = comSql.ExecuteReader();

        Paciente retorno;

        if (drDados.Read())
        {
            retorno = new Paciente();

            retorno.IdUsuario = usuario.IdUsuario;
            retorno.IdPaciente = drDados.GetInt32(1);
  
            retorno.Email = usuario.Email;
            retorno.Senha = usuario.Senha;
            retorno.Tipo = TipoUsuario.PACIENTE;
            retorno.Nome = drDados.GetString(2).ToString();
            retorno.Celular = drDados.GetString(4).ToString();
            retorno.Endereco = drDados.GetString(5).ToString();
          //  retorno.Foto = (Image)drDados["foto"];
            retorno.DataNascimento = drDados.GetDateTime(3);
            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }
    public static void CadastrarPaciente(Paciente novoPac)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        UsuarioDao.insereUsuario(novoPac);

        novoPac.IdUsuario = UsuarioDao.getId(novoPac.Email, novoPac.Senha);

        string comando = "INSERT INTO PACIENTE VALUES (@idUsuario, @nome, @dataNasc, @endereco, @celular, null)";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);

        comSql.Parameters.AddWithValue("@idUsuario", novoPac.IdUsuario);
        comSql.Parameters.AddWithValue("@nome", novoPac.Nome);
        comSql.Parameters.AddWithValue("@dataNasc", novoPac.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        comSql.Parameters.AddWithValue("@endereco", novoPac.Endereco);
        comSql.Parameters.AddWithValue("@celular", novoPac.Celular);
        try
        {
            comSql.ExecuteNonQuery();
        }
        catch (SqlException sqlEx)
        {
            throw new InsertPacientException("Paciente não inserido "+ sqlEx);
        }
    }
}