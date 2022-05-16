using FluentValidation.Results;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.Dominio.ModuloQuestao;
using GeradorDeTeste.Infra.ModuloDisciplina;
using GeradorDeTeste.Infra.ModuloMateria;
using GeradorDeTeste.Infra.Moduloquestao;
using GeradorDeTeste.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private RepositorioQuestaoEmArquivo _repositorioQuestao;
        private RepositorioMateriaEmArquivo _repositorioMateria;
        private RepositorioDisciplinaEmArquivo _repositorioDisciplina;

        private ListagemQuestaoControl _tabelaQuestao;

        public ControladorQuestao(RepositorioQuestaoEmArquivo repositorioQuestao, RepositorioMateriaEmArquivo repositorioMateria, RepositorioDisciplinaEmArquivo repositorioDisciplina)
        {
            this._repositorioQuestao = repositorioQuestao;
            this._repositorioMateria = repositorioMateria;
            this._repositorioDisciplina = repositorioDisciplina;
        }


        public override void Inserir()
        {
            TelaCadastroQuestaoForm tela = new(_repositorioDisciplina, _repositorioMateria);

            tela.Questao = new Questao();
            tela.GravarRegistro = _repositorioQuestao.Inserir;

            DialogResult res = tela.ShowDialog(); 

            if (res == DialogResult.OK)
                CarregarQuestoes();
        }

        public override void Editar()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            TelaCadastroQuestaoForm tela = new(_repositorioDisciplina, _repositorioMateria);

            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarMsgRodape("Selecione uma questão!");
                return;
            }
            tela.Questao = questaoSelecionada.Clone();

            tela.GravarRegistro = _repositorioQuestao.Editar;

            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
                CarregarQuestoes();
        }
        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarMsgRodape("Selecione uma questão!");
                return;
            }

            DialogResult res = MessageBox.Show("Excluir questão?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                ValidationResult deuCerto = _repositorioQuestao.Excluir(questaoSelecionada);
                if (deuCerto.IsValid)
                    CarregarQuestoes();
            }

        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox() 
        {
            return new ConfiguracaoToolBoxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            if (_tabelaQuestao == null)
                _tabelaQuestao = new ListagemQuestaoControl();

            CarregarQuestoes();

            return _tabelaQuestao;
        }

        private List<Disciplina> CarregarDisciplinas()
        {
            return _repositorioDisciplina.ObterRegistros();
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = _repositorioQuestao.SelecionarTodos();
            _tabelaQuestao!.AtualizarRegistros(questoes);

            TelaPrincipalForm.Instancia!.AtualizarMsgRodape($"Visualizando {questoes.Count} questão(ões)");
        }

        private Questao ObtemQuestaoSelecionada()
        {
            var numero = _tabelaQuestao!.ObtemNumeroMateriaSelecionada();
            return _repositorioQuestao.SelecionarPorNumero(numero);
        }
    }
}
