using e_Agenda.Infra.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaContato
{
    public partial class Form1 : Form
    {
        private ContatoDAO _contatoDAO;
        private IList<Contato> _listaContatos;
        private Contato _contatoEncontrado;

        public void limpaCampos()
        {
            pegaNome.Text = "";
            pegaTelefone.Text = "";
            pegaDepartamento.Text = "";
            pegaEmail.Text = "";
            pegaCargo.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            _contatoDAO = new ContatoDAO();
            dgvContatos.DataSource = _contatoDAO.BuscarTodos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato()
            {
                Nome = pegaNome.Text,
                Telefone = pegaTelefone.Text,
                Cargo = pegaCargo.Text,
                Departamento = pegaDepartamento.Text,
                Email = pegaEmail.Text
            };

            //acao
            try
            {
                _contatoDAO.Adicionar(contato);
                dgvContatos.DataSource = null;
                dgvContatos.DataSource = _contatoDAO.BuscarTodos();
                limpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dgvContatos.CurrentRow.Cells["id"].Value);

            try
            {
                _contatoDAO.Deletar(idSelecionado);
                dgvContatos.DataSource = null;
                dgvContatos.DataSource = _contatoDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idSelecionado = (int)(dgvContatos.CurrentRow.Cells["id"].Value);

            _contatoEncontrado = new Contato();
            _contatoEncontrado = _contatoDAO.BuscarPorId(idSelecionado);

            pegaNome.Text = _contatoEncontrado.Nome;
            pegaTelefone.Text = _contatoEncontrado.Telefone;
            pegaEmail.Text = _contatoEncontrado.Email;
            pegaDepartamento.Text = _contatoEncontrado.Departamento;
            pegaCargo.Text = _contatoEncontrado.Cargo;
            btnSalvar.Visible = false;
            btnAlteracao.Visible = true;
        }

        private void btnAlteracao_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato()
            {
                id = _contatoEncontrado.id,
                Nome = pegaNome.Text,
                Telefone = pegaTelefone.Text,
                Cargo = pegaCargo.Text,
                Departamento = pegaDepartamento.Text,
                Email = pegaEmail.Text
            };

            //acao
            try
            {
                _contatoDAO.Editar(contato);
                dgvContatos.DataSource = null;
                dgvContatos.DataSource = _contatoDAO.BuscarTodos();
                limpaCampos();
                btnAlteracao.Visible = false;
                btnSalvar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
