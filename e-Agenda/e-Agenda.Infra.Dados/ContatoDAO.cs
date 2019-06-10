using Sartor.Pizzaria.Infra.Dados.Comum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Infra.Dados
{
    public class ContatoDAO
    {
        #region
        public const string _sqlAdicionar =
           @"INSERT INTO Contato
                   ([nome]
                   ,[telefone]
                   ,[cargo]
                   ,[email]
                   ,[departamento])
               VALUES
                   ({0}nome
                   ,{0}telefone
                   ,{0}cargo
                   ,{0}email
                   ,{0}departamento)";
        private const string _sqlBuscaTodos =
            @"SELECT [id]
                  ,[nome]
                  ,[telefone]
                  ,[cargo]
                  ,[email]
                  ,[departamento]
              FROM [dbo].[Contato]";

        private const string _sqlEditar =
           @"UPDATE [dbo].[Contato]
               SET [Nome] = {0}nome
                  ,[telefone] = {0}telefone
                  ,[cargo] = {0}cargo
                  ,[email] = {0}email
                  ,[departamento] = {0}departamento

             WHERE [Id] = {0}id";
        private const string _sqlDeletar =
            @"DELETE FROM [dbo].[Contato] WHERE [id] = {0}id";
        private const string _sqlBuscaPorId =
            @"SELECT [id]
                  ,[nome]
                  ,[telefone]
                  ,[cargo]
                  ,[email]
                  ,[departamento]
              FROM [dbo].[Contato]
              WHERE [id] = {0}id";
        #endregion

        public int Adicionar(Contato novoContato)
        {
            return Db.Insert(_sqlAdicionar, BuscarParametros(novoContato));
        }

        public IList<Contato> BuscarTodos()
        {
            return Db.GetAll(_sqlBuscaTodos, ConverterContato);
        }
        public Contato BuscarPorId(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            return Db.Get(_sqlBuscaPorId, ConverterContato, parms);
        }
        public void Editar(Contato contato)
        {
            Db.Update(_sqlEditar, BuscarParametros(contato));
        }

        public void Deletar(int id)
        {
            var parms = new Dictionary<string, object> { { "Id", id } };

            Db.Delete(_sqlDeletar, parms);
        }

        private Contato ConverterContato(IDataReader reader)
        {
            Contato contato = new Contato
            {
                id = Convert.ToInt32(reader["id"]),
                Nome = Convert.ToString(reader["nome"]),
                Telefone = Convert.ToString(reader["telefone"]),
                Cargo = Convert.ToString(reader["cargo"]),
                Email = Convert.ToString(reader["email"]),
                Departamento = Convert.ToString(reader["departamento"])
            };

            return contato;
        }

        private Dictionary<string, object> BuscarParametros(Contato contato)
        {
            return new Dictionary<string, object>
            {
                {"id",contato.id},
                { "nome",contato.Nome},
                {"telefone",contato.Telefone},
                {"cargo",contato.Telefone},
                {"email",contato.Email},
                {"departamento",contato.Departamento}

            };
        }
    }
}
