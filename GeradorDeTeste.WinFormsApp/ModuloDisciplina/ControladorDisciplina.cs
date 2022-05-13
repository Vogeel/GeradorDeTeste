using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private ListagemDisciplinaControl listagemDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override Disciplina ObtemSelecionada()
        {
            var numero = listagemDisciplinas.ObtemNumeroDisciplinaSelecionado();

            return repositorioDisciplina.SelecionarPorNumero(numero);
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObtemSelecionada();

            if(disciplinaSelecionada == null)
            {
                MessageBox.Show("Nenhuma disciplina selecionada",
                                "Editar Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDisciplinaForm tela = new();

            tela.Disciplina = (Disciplina)disciplinaSelecionada.Clone();

            tela.GravarRegistro = repositorioDisciplina.Editar;



            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }
       

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObtemSelecionada();

            if(disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
               "Excluir Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a disciplina?",
              "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                ValidationResult validation = repositorioDisciplina.Excluir(disciplinaSelecionada);

                if (validation.Errors.Count > 0)
                    MessageBox.Show(validation.Errors[0].ToString());
                CarregarDisciplinas();
            }
        }

        public override void Inserir()
        {
            TelaCadastroDisciplinaForm tela = new TelaCadastroDisciplinaForm();
            tela.Disciplina = new Disciplina();

            tela.GravarRegistro = repositorioDisciplina.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            throw new NotImplementedException();
        }

        public override void AtualizarQuestoes()
        {
            Disciplina disciplinaSelecionada = ObtemSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Questoes de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaPrincipalForm.Instancia.disciplinaSelecionada = disciplinaSelecionada;
            TelaPrincipalForm.Instancia.disciplinaSelecionada.questoes = repositorioDisciplina.SelecionarQuestoes().Where(x => x.materia.Disciplina == TelaPrincipalForm.Instancia.disciplinaSelecionada).ToList();
            TelaPrincipalForm.Instancia.ConfigurarTelaPrincipal();
        }
    
        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();



            listagemDisciplinas.AtualizarRegistros(disciplinas);
            TelaPrincipalForm.Instancia.AtualizarMsgRodape($"Visualizando {disciplinas.Count} disciplina(s)");
        }
    }
}
