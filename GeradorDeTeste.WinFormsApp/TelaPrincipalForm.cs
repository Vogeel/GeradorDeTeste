using GeradorDeTeste.Dominio.ModuloMateria;
using GeradorDeTeste.Infra.Compartilhado;
using GeradorDeTeste.Infra.ModuloDisciplina;
using GeradorDeTeste.Infra.ModuloMateria;
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
        private Dictionary<string, ControladorBase> controladores;
        string tipoCadastro = "";
        private ControladorBase controlador;
        private DataContext contextoDados;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            Instancia = this;
            labelRodape.Text = string.Empty;
            InicializarCOntroladores();

        }

        public static TelaPrincipalForm? Instancia
        {
            get;
            private set;
        }

        public void AtualizarMsgRodape(string mng)
        {
            labelRodape.Text = mng;
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            tipoCadastro = "Disciplina";
            

            ListagemDisciplinaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            tipoCadastro = "Materia";           

            ListagemMateriaControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void QuestaoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            tipoCadastro = "Questao";
           

            ListagemQuestaoControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void fazerOTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            ListagemTesteControl listagem = new();
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolBox()
        {
            ConfiguracaoToolBoxBase config = controlador!.ObtemConfiguracaoToolbox();
            if (config != null)
            {
                toolStripPrincipal.Enabled = true;
                COnfiguracaoToolTip(config);
                ConfiguravaoBotao(config);

            }
        }

        private void COnfiguracaoToolTip(ConfiguracaoToolBoxBase config)
        {
            btnInserir.ToolTipText = config.ToolTipInserir;
            btnEditar.ToolTipText = config.ToolTipEditar;
            btnExcluir.ToolTipText = config.ToolTipExcluir;
        }
        private void ConfiguravaoBotao(ConfiguracaoToolBoxBase config)
        {
            btnInserir.Enabled = config.StatusInserir;
            btnEditar.Enabled = config.StatusEditar;
            btnExcluir.Enabled = config.StatusExcluir;
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

        public void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            if (tipo != "Disciplina" && contextoDados.Disciplinas.Count == 0)
            {
                AtualizarMsgRodape("cadastre uma disciplina primeiro");
                return;
            }

            if (tipo == "Teste" && contextoDados.Materias.Count == 0)
            {
                AtualizarMsgRodape("cadastre uma Materia primeiro");
                return;
            }



            controlador = controladores![tipo];

            ConfigurarToolBox();

            ConfigurarListagem();
        }

        private void ConfigurarListagem()
        {
            throw new NotImplementedException();
        }

        private void InicializarCOntroladores()
        {

            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contextoDados);
            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("disciplina", new ControladorDisciplina(repositorioDisciplina, repositorioMateria));
            controladores.Add("mateiras", new ControladorMateria(repositorioMateria, repositorioDisciplina));
        }
    }
}
