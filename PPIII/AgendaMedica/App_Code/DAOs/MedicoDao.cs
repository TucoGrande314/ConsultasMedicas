﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MedicoDao
/// </summary>
public class MedicoDao
{
    public MedicoDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static Medico UsuarioToMedico(Usuario usuario)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }

        SqlDataReader drDados;

        string comando = "SELECT * FROM Medico WHERE id_usuario = @idUsuario";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

        drDados = comSql.ExecuteReader();

        Medico retorno;

        if (drDados.Read())
        {
            retorno = new Medico();

            retorno.IdUsuario = usuario.IdUsuario;
            retorno.Email = usuario.Email;
            retorno.Senha = usuario.Senha;
            retorno.Tipo = TipoUsuario.MEDICO;
            retorno.Nome = drDados["nome"].ToString();
            retorno.Celular = drDados["celular"].ToString();
            retorno.Endereco = drDados["endereco"].ToString();
            retorno.Especializacao = EspecializacaoDao.getEspecializacao(Convert.ToInt32(drDados["idEspecializacao"]));
            retorno.Foto = (Image)drDados["foto"];

            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }
}