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

    public static bool horarioDisponivel(DateTime dataHora, int duracaoConsulta, int idMedico)
    {
        if (!Dao.EstaAberto())
            Dao.AbrirConexao();

        string comando = "exec sp_horario_disponivel @horarioConsulta, @duracaoConsulta, @idMedico, @dataConsulta";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@dataConsulta", dataHora);
        comSql.Parameters.AddWithValue("@idMedico", idMedico);
        comSql.Parameters.AddWithValue("@horarioConsulta", dataHora.ToString("HH:mm"));
        comSql.Parameters.AddWithValue("@duracaoConsulta", duracaoConsulta);


        SqlDataReader drDados = comSql.ExecuteReader();
        drDados.Read();
        if (Convert.ToInt32(drDados[0])!=0)
            return false;
        else
            return true;
    }

    public static bool inserirConsulta(Consulta novaCons)
    {
        if (novaCons == null)
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

        string comando = "INSERT INTO CONSULTA VALUES (@idPaciente, @idMedico, @dataConsulta, @inicioConsulta, @duracao, 'AGENDADA')";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idPaciente", novaCons.Paciente.IdPaciente);
        comSql.Parameters.AddWithValue("@idMedico", novaCons.Medico.IdMedico);
        comSql.Parameters.AddWithValue("@dataConsulta", novaCons.DataConsulta);
        comSql.Parameters.AddWithValue("@inicioConsulta", novaCons.hora);
        comSql.Parameters.AddWithValue("@duracao", novaCons.Duracao);

        try
        {
            comSql.ExecuteNonQuery();
            return true;
        }
        catch(SqlException sqlex)
        {
            return false;
        }
    }
}