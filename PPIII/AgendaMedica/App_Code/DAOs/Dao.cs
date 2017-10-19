using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Dao
/// </summary>
public class Dao
{
    static SqlConnection connection;

    public static SqlConnection Conexao
    {
        get
        {
            return connection;
        }
    }

    static Dao()
    {
        connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BD16167ConnectionString"].ConnectionString);
        connection.Open();
    }

    public static void FecharConexao()
    {
        connection.Close();
    }
    public static void AbrirConexao()
    {
        connection.Open();
    }

    public static bool EstaAberto()
    {
        return connection.State == System.Data.ConnectionState.Open;
    }

}