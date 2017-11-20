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

    public static bool existeUsuario(String email)
    {
        if (!Dao.EstaAberto())
            Dao.AbrirConexao();

        SqlDataReader drDados;

        string comando = "SELECT * FROM Usuario WHERE Email = @Email";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@Email", email);

        drDados = comSql.ExecuteReader();

        if (drDados.Read())
        {
            drDados.Close();
            return true;
        }
        else
        {
            drDados.Close();
            return false;
        }
    }

    public static int getId(string email, string senha)
    {
        if (!Dao.EstaAberto())
            Dao.AbrirConexao();

        SqlDataReader drDados;

        string comando = "SELECT * FROM Usuario WHERE Email = @Email and Senha = @Senha";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@Email", email);
        comSql.Parameters.AddWithValue("@Senha", senha);

        drDados = comSql.ExecuteReader();

        int retorno = 0;
        if (drDados.Read())
        {
            retorno = Convert.ToInt32(drDados[0].ToString());
            drDados.Close();
        }
        else
        {
            drDados.Close();
            throw new UsuarioNotFoundException("Usuário não encontrado");
        }
        return retorno;
    }

    public static Usuario LoginValido(Usuario usuario)
    {


        SqlDataReader drDados;

        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }

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
        else
        {
            drDados.Close();
            throw new UsuarioNotFoundException("Usuario ou senha invalido(s).");
        }
    }

    public static void insereUsuario(Usuario novoUser)
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        string comando = "INSERT INTO USUARIO VALUES (@Email, @Senha, @Tipo)";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@Email", novoUser.Email);
        comSql.Parameters.AddWithValue("@Senha", novoUser.Senha);
        comSql.Parameters.AddWithValue("@Tipo", "" + (char)novoUser.Tipo);

        try
        {
            comSql.ExecuteNonQuery();
        }
        catch (SqlException sqlEx)
        {
            throw new InsertUsuarioException("Usuario não inserido com sucesso " + sqlEx);
        }

    }
}