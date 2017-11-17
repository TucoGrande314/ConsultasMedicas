using System;
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
            retorno.Especializacao = EspecializacaoDao.getEspecializacao(Convert.ToInt32(drDados["id_especializacao"]));
            //retorno.Foto = (Image)drDados["foto"];

            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }

    public static List<Medico> getMedicos()
    {
        if (!Dao.EstaAberto())
        {
            Dao.AbrirConexao();
        }
        SqlDataReader drDados;
        string comando = "SELECT * FROM Medico";

        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        drDados = comSql.ExecuteReader();

        List<Medico> retorno= new List<Medico>();
        while (drDados.Read())
        {
            Medico novoMedico = new Medico();

            novoMedico.IdMedico = (int)drDados["id_medico"];
            novoMedico.Nome =     drDados["nome"].ToString();
            novoMedico.Celular = drDados["celular"].ToString();
            novoMedico.Especializacao = EspecializacaoDao.getEspecializacao(Convert.ToInt32(drDados["id_especializacao"]));

            retorno.Add(novoMedico);
        }
        Dao.FecharConexao();
        return retorno;
    } 
}