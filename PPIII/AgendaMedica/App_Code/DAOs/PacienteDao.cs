using System;
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

        SqlDataReader drDados;

        string comando = "SELECT * FROM Paciente WHERE id_usuario = @idUsuario";
        SqlCommand comSql = new SqlCommand(comando, Dao.Conexao);
        comSql.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);

        drDados = comSql.ExecuteReader();

        Paciente retorno;

        if (drDados.Read())
        {
            retorno = new Paciente();

            retorno.IdUsuario = usuario.IdUsuario;
            retorno.Email = usuario.Email;
            retorno.Senha = usuario.Senha;
            retorno.Tipo = TipoUsuario.PACIENTE;
            retorno.Nome = drDados["nome"].ToString();
            retorno.Celular = drDados["celular"].ToString();
            retorno.Endereco = drDados["endereco"].ToString();
          //  retorno.Foto = (Image)drDados["foto"];
            retorno.DataNascimento = (DateTime)drDados["data_nascimento"];
            drDados.Close();
            return retorno;
        }

        drDados.Close();
        return null;
    }
}