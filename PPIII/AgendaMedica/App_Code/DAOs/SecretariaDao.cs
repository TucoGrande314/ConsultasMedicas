using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SecretariaDao
/// </summary>
public class SecretariaDao
{
    public SecretariaDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static Secretaria UsuarioToSecretaria(Usuario usuario)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }

        SqlDataReader drDados;

        string comando = "SELECT * FROM Secretaria WHERE id_usuario = @idUsuario";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

        drDados = comSql.ExecuteReader();

        Secretaria retorno;

        if (drDados.Read())
        {
            retorno = new Secretaria();

            retorno.IdUsuario = usuario.IdUsuario;
            retorno.Email = usuario.Email;
            retorno.Senha = usuario.Senha;
            retorno.Tipo = TipoUsuario.SECRETARIA;
            retorno.Nome = drDados["nome"].ToString();
            retorno.Celular = drDados["celular"].ToString();
            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }
}