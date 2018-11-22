using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.CadastroPessoas.Repositorio;

namespace TreinaWeb.CadastroPessoas.Forms
{
    public partial class FrmPessoas : Form
    {
        private List<Pessoa> _listaPessoas = new List<Pessoa>();
        public FrmPessoas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbPesquisar.Text = string.Empty;
            PreencherDataGridViewAsync();
        }

       

        public async void  PreencherDataGridViewAsync()
        {
            await Task<int>.Run(() =>
            {                
                IRepositorio<Pessoa> repositorioPessoa = new PessoaRepositorio();

                _listaPessoas = new List<Pessoa>();
                List<Pessoa> listaTemp = repositorioPessoa.SelecionarTodos();

                Parallel.ForEach(listaTemp, (pessoa) =>
                {
                    pessoa.Nome = pessoa.Nome.ToUpper();
                    pessoa.Endereco = pessoa.Endereco.ToUpper();
                    _listaPessoas.Add(pessoa);
                });

                dgvPessoas.Invoke((MethodInvoker)delegate
                {
                    dgvPessoas.DataSource = _listaPessoas;
                    dgvPessoas.Refresh();
                });
                return _listaPessoas.Count();

            }).ContinueWith((task) => {

                return MessageBox.Show(Convert.ToString(task.Result));
            });

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarPessoa frmAdicionarPessoa = new FrmAdicionarPessoa();
            frmAdicionarPessoa.ShowDialog();
            PreencherDataGridViewAsync();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IRepositorio<Pessoa> repositorioPessoa = new PessoaRepositorio();
            dgvPessoas.DataSource = repositorioPessoa.Selecionar(pessoa => pessoa.Nome.Contains(txbPesquisar.Text.ToUpper()));
            dgvPessoas.Refresh();

        }
    }
}
