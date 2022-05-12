using GeradorDeTeste.WinFormsApp.Compartilhado;
using GeradorDeTeste.WinFormsApp.ModuloDisciplina;
using GeradorDeTeste.WinFormsApp.ModuloMateria;
using GeradorDeTeste.WinFormsApp.ModuloQuestao;
using GeradorDeTeste.WinFormsApp.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        string tipoCadastro = "";
        private ControladorBase controlador;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            tipoCadastro = "Disciplina";
            ConfigurarToolBox(new ConfiguracaoToolBoxTarefa());

            ListagemDisciplinaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            tipoCadastro = "Materia";
            ConfigurarToolBox(new ConfiguracaoToolBoxMateria());

            ListagemMateriaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void QuestaoMenuItem_Click(object sender, EventArgs e)
        {
            tipoCadastro = "Questao";
            ConfigurarToolBox(new ConfiguracaoToolBoxQuestao());

            ListagemQuestaoControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void fazerOTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListagemTesteControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolBox(ConfiguracaoToolBoxBase config)
        {
            btnInserir.ToolTipText = config.ToolTipInserir;
            btnEditar.ToolTipText = config.ToolTipEditar;
            btnExcluir.ToolTipText = config.ToolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (tipoCadastro == "Disciplina")
            {
                TelaCadastroDisciplinaForm tela = new();
                
            }
            else if (tipoCadastro == "Materia")
            {
                TelaCadastroMateriaForm tela = new();
            }
            else if (tipoCadastro == "Questao")
            {
                TelaCadastroQuestaoForm tela = new();
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}
