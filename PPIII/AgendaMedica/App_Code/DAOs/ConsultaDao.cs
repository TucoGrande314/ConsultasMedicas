using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConsultaDao
/// </summary>
public class ConsultaDao
{
    public ConsultaDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool cadastrarConsulta(Consulta consulta)
    {
        if (consulta == null)
        {
            throw new Exception("consulta nula");
        }

        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        else
        {
            Dao.FecharConexao();
            Dao.AbrirConexao();
        }

        string comando = "UPDATE Consulta SET stat = @stat where id_consulta = @idConsulta";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@stat", consulta.Stat);
        comSql.Parameters.AddWithValue("@idConsulta", consulta.Id);

        try
        {
            comSql.ExecuteNonQuery();
            return true;
        }
        catch (SqlException sqlException)
        {
            return false;
        }
    }
}