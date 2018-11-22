﻿using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.CadastroPessoas.Repositorio;

namespace TreinaWeb.CadastroPessoas.Forms
{
    public partial class FrmAdicionarPessoa : Form
    {
        public FrmAdicionarPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = txbNome.Text.ToUpper(),
                Idade = Convert.ToInt32(txbIdade.Text),
                Endereco = txbEndereco.Text.ToUpper()
            };

            IRepositorio<Pessoa> repositorioPessoa = new PessoaRepositorio();
            repositorioPessoa.Adicionar(pessoa);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
