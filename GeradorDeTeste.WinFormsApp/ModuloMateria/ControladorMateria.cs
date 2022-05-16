using FluentValidation.Results;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.Dominio.ModuloMateria;
using GeradorDeTeste.Infra.ModuloDisciplina;
using GeradorDeTeste.Infra.ModuloMateria;
using GeradorDeTeste.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioMateriaEmArquivo _repositorioMateria;
        private RepositorioDisciplinaEmArquivo _repositorioDisciplina;
        private ListagemMateriaControl listagemMateria;

        public ControladorMateria(RepositorioMateriaEmArquivo repositorioMateria, RepositorioDisciplinaEmArquivo repositorioDisciplina)
        {
            this._repositorioMateria = repositorioMateria;
            this._repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            TelaCadastroMateriaForm tela = new(disciplinas);

            tela.Materia = new();
            tela.GravarRegistro = _repositorioMateria.Inserir;

            DialogResult res = tela.ShowDialog(); 
            if (res == DialogResult.OK)
                CarregarMaterias();
        }

        public override void Editar()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.ObterRegistros();
            TelaCadastroMateriaForm tela = new(disciplinas);

            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarMsgRodape("Selecione uma matéria!");
                return;
            }
            tela.Materia = materiaSelecionada.Clone();

            tela.GravarRegistro = _repositorioMateria.Editar;

            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
                CarregarMaterias();
        }
        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm.Instancia!.AtualizarMsgRodape("Selecione uma matéria!");
                return;
            }

            DialogResult res = MessageBox.Show("Excluir matéria?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                ValidationResult deuCerto = _repositorioMateria.Excluir(materiaSelecionada);
                if (deuCerto.IsValid)
                    CarregarMaterias();
            }

        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxMateria();
        }

        public override UserControl ObtemListagem()
        {
            if (listagemMateria == null)
                listagemMateria = new ();

            CarregarMaterias();

            return listagemMateria;
        }

        private List<Disciplina> CarregarDisciplinas()
        {
            return _repositorioDisciplina.ObterRegistros();
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = _repositorioMateria.SelecionarTodos();
            listagemMateria!.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia!.AtualizarMsgRodape($"Visualizando {materias.Count} materia(s)");
        }

        private Materia ObtemMateriaSelecionada()
        {
            var numero = listagemMateria!.ObtemNumeroMateriaSelecionadas();
            return _repositorioMateria.SelecionarPorNumero(numero);
        }
    }
}
