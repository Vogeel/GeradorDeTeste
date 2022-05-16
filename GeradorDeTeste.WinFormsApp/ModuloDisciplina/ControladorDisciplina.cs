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
using GeradorDeTeste.Dominio.ModuloMateria;
using GeradorDeTeste.Infra.ModuloDisciplina;
using GeradorDeTeste.Infra.ModuloMateria;

namespace GeradorDeTeste.WinFormsApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private RepositorioDisciplinaEmArquivo repositorioDisciplina;
        private ListagemDisciplinaControl listagemDisciplinas;
        private RepositorioMateriaEmArquivo repositorioMateria;

        public ControladorDisciplina(RepositorioDisciplinaEmArquivo repositorioDisciplina, RepositorioMateriaEmArquivo repositorioMateria)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }

        public ControladorDisciplina(RepositorioDisciplinaEmArquivo repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override Disciplina ObtemSelecionada()
        {
            var numero = listagemDisciplinas.ObtemNumeroDisciplinaSelecionadas();

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
            List<Materia> materias = repositorioMateria.ObterRegistros();
            foreach (var item in materias)
            {
                if (item.Disciplina == disciplinaSelecionada)
                {
                    TelaPrincipalForm.Instancia!.AtualizarMsgRodape("Esta disciplina não pode ser excluída pois está atrelada a alguma matéria");
                    return;
                }
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
            return new ConfiguracaoToolBoxDisciplina();
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

        }
    
        public override UserControl ObtemListagem()
        {
            if (listagemDisciplinas == null)
                listagemDisciplinas = new ListagemDisciplinaControl();

            CarregarDisciplinas();

            return listagemDisciplinas;
        }
        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            listagemDisciplinas.AtualizarRegistros(disciplinas);
            TelaPrincipalForm.Instancia!.AtualizarMsgRodape($"Visualizando {disciplinas.Count} disciplina(s)");
        }
            
        private Disciplina ObtemDisciplinaSelecionada()
        {
            var numero = listagemDisciplinas!.ObtemNumeroDisciplinaSelecionadas();
            return repositorioDisciplina.SelecionarPorNumero(numero);
        }
    }
}
