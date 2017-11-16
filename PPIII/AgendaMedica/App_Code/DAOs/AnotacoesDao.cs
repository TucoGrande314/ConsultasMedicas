using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AnotacoesDao
/// </summary>
public class AnotacoesDao
{
    public AnotacoesDao()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static Anotacoes getAnotacao(Consulta consulta)
    {
        if (consulta == null)
            throw new Exception("consulta nula");

        if (consulta.Id < 0)
            throw new Exception("id inválido");

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

        string comando = "SELECT * FROM Anotacoes where id_consulta = @idConsulta";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idConsulta", consulta.Id);

        drDados = comSql.ExecuteReader();

        Anotacoes retorno = new Anotacoes();

        if (drDados.Read())
        {
            retorno.Id = drDados.GetInt32(0);
            retorno.Consulta = consulta;
            retorno.Resultado = drDados.GetString(2);
            retorno.Diagnostico = drDados.GetString(3);
            retorno.Medicacao = drDados.GetString(4);
        }
        else
        {
            return null;
        }

        return retorno;
    }

    public static bool cadastrarAnotacoes(Anotacoes anotacoes)
    {
        if (anotacoes == null)
        {
            throw new Exception("anotacao nula");
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

        string comando = "INSERT INTO ANOTACOES VALUES (@idConsulta, @resultado, @diagnostico, @medicacao)";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idConsulta", anotacoes.Consulta.Id);
        comSql.Parameters.AddWithValue("@resultado", anotacoes.Resultado);
        comSql.Parameters.AddWithValue("@diagnostico", anotacoes.Diagnostico);
        comSql.Parameters.AddWithValue("@medicacao", anotacoes.Medicacao);

        try
        {
            comSql.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool atualizarAnotacao(Anotacoes anotacoes)
    {
        if (anotacoes == null)
        {
            throw new Exception("anotacao nula");
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

        string comando = "UPDATE ANOTACOES SET resultado = @resultado, diagnostico = @diagnostico, medicacao =  @medicacao where id_anotacoes = @idAnotacoes";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idAnotacoes", anotacoes.Id);
        comSql.Parameters.AddWithValue("@resultado", anotacoes.Resultado);
        comSql.Parameters.AddWithValue("@diagnostico", anotacoes.Diagnostico);
        comSql.Parameters.AddWithValue("@medicacao", anotacoes.Medicacao);

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