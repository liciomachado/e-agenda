// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace e_Agenda.Infra.Dados.Testes
{
    [TestFixture]
    public class TestClass
    {
        private ContatoDAO _contatoDAO;

        public void inicializador()
        {
            _contatoDAO = new ContatoDAO();
        }
        [Test]
        public void Teste_Deve_Adicionar_Um_Contato_No_Banco()
        {
            inicializador();
            Contato contato = new Contato()
            {
                Nome = "José",
                Telefone = "32254661",
                Cargo = "Gerente",
                Departamento = "Financeiro",
                Email = "jose@financeiro.com"
            };

            //acao
            var resultado = _contatoDAO.Adicionar(contato);
            var idEsperado = 8;

            //verificacao
            Assert.True(resultado > 0);
            Assert.AreEqual(idEsperado,resultado);
        }
        [Test]
        public void Teste_Excluir_Contato()
        {
            //acao
            inicializador();
            _contatoDAO.Deletar(6);
            int quantidadeContatos = 2;

            var resultado = _contatoDAO.BuscarTodos();

            //verificacao
            Assert.True(quantidadeContatos == resultado.Count);
        }

        [Test]
        public void Editar_Nome_Do_Contato()
        {
            inicializador();
            Contato contato = new Contato()
            {
                id = 7,
                Nome = "Marcus",
                Telefone = "32254661",
                Cargo = "Gerente",
                Departamento = "Financeiro",
                Email = "jose@financeiro.com"
            };

            _contatoDAO.Editar(contato);
        }

        [Test]
        public void Busca_Todos_Os_Contatos()
        {
            //ACAO
            inicializador();
            var resultado = _contatoDAO.BuscarTodos();
            int esperado = 2;
            //VERIFICACAO
            Assert.True(resultado.Count == esperado);

        }
    }
}
