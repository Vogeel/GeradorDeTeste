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

        private Controlador controlador;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {

            ConfigurarToolBox(new ConfiguracaoToolBoxTarefa());

            ListagemDisciplinaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarToolBox(new ConfiguracaoToolBoxMateria());

            ListagemMateriaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void QuestaoMenuItem_Click(object sender, EventArgs e)
        {
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
            controlador.Inserir();
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
