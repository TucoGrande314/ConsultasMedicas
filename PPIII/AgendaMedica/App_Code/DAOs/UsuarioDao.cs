using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for UsuarioDao
/// </summary>
public class UsuarioDao
{
    public UsuarioDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static Usuario LoginValido(Usuario usuario)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }

        SqlDataReader drDados;

        string comando = "SELECT * FROM Usuario WHERE Email = @Email and Senha = @Senha";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@Email", usuario.Email);
        comSql.Parameters.AddWithValue("@Senha", usuario.Senha);

        drDados = comSql.ExecuteReader();

        Usuario retorno;

        if (drDados.Read())
        {
            retorno = new Usuario();
            
            retorno.IdUsuario = Convert.ToInt32(drDados["id_usuario"]);
            retorno.Email = drDados["email"].ToString();
            retorno.Senha = drDados["senha"].ToString();
            retorno.Tipo = (TipoUsuario)Convert.ToChar(drDados["tipo_usuario"]);

            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }

    public static void insereUsuario(Usuario novoUser)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        string comando = "INSERT INTO USUARIO VALUES (@Email, @Senha)";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@Email", novoUser.Email);
        comSql.Parameters.AddWithValue("@Senha", novoUser.Senha);

        try
        {
            comSql.ExecuteNonQuery();
        }
        catch (SqlException sqlEx)
        {

        }

    }
}