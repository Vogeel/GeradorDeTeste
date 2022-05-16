using FluentValidation.Results;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.Dominio.ModuloMateria;
using GeradorDeTeste.Dominio.ModuloQuestao;
using GeradorDeTeste.Infra.ModuloDisciplina;
using GeradorDeTeste.Infra.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.ModuloQuestao
{
    public partial class TelaCadastroQuestaoForm : Form
    {
        private Questao _questao;
        private RepositorioDisciplinaEmArquivo _repositorioDisciplina;
        private RepositorioMateriaEmArquivo _repositorioMateria;

        public Questao Questao
        {
            get
            {
                return _questao;
            }
            set
            {
                _questao = value;

                comboBoxDisciplinas.SelectedItem = _questao.Disciplina;
                comboBoxMaterias.SelectedItem = _questao.Materia;
                textBoxQuestao.Text = _questao.Enunciado;
                PovoarAlternativas();
            }
        }

        public TelaCadastroQuestaoForm(RepositorioDisciplinaEmArquivo rd, RepositorioMateriaEmArquivo rm)
        {
            InitializeComponent();
            this._repositorioDisciplina = rd;
            this._repositorioMateria = rm;
            PovoarDisciplinas();
            comboBoxDisciplinas.SelectedItem = 0;
        }


        public void PovoarDisciplinas()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.SelecionarTodos();
            foreach (var item in disciplinas)
                comboBoxDisciplinas.Items.Add(item);
        }

        public void PovoarMaterias(Disciplina disc)
        {
            List<Materia> materias = _repositorioMateria.SelecionarTodos();
            List<Materia> materiasEspecificas = new();

            foreach (var item in materias)
                if (item.Disciplina == disc)
                    materiasEspecificas.Add(item);

            foreach (var item in materiasEspecificas)
                comboBoxMaterias.Items.Add(item);
        }

        public void PovoarAlternativas()
        {
            int i = 0;
            foreach (var item in Questao.Alternativas)
            {
                AlternativascheckedListBox.Items.Add(item);
                if (item.EstaCerta)
                    AlternativascheckedListBox.SetItemChecked(i, true);

                i++;
            }
        }

        public Func<Questao, ValidationResult>? GravarRegistro { get; set; }

        public List<Alternativas> AlternativasAdicionadas
        {
            get
            {
                return AlternativascheckedListBox.Items.Cast<Alternativas>().ToList();
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Questao.Enunciado = textBoxQuestao.Text.ToString();
            Questao.Disciplina = (Disciplina)comboBoxDisciplinas.SelectedItem;
            Questao.Materia = (Materia)comboBoxMaterias.SelectedItem;

            List<Alternativas> alts = AlternativasAdicionadas;
            foreach (var item in alts)
                if (AlternativascheckedListBox.SelectedItem == item)
                    item.EstaCerta = true;

            Questao.AdicionarAlternativas(alts);

            var resultadoValidacao = GravarRegistro!(Questao);

            if (!resultadoValidacao.IsValid)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia!.AtualizarMsgRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (AlternativascheckedListBox.Text != string.Empty && AlternativascheckedListBox.Text != "")
            {
                if (AlternativascheckedListBox.Items.Count < 4)
                {
                    List<string> titulos = AlternativasAdicionadas.Select(x => x.Opcao).ToList();

                    if (titulos.Count == 0 || titulos.Contains(AlternativascheckedListBox.Text) == false)
                    {
                        Alternativas alt = new();

                        alt.Opcao = textBoxAlternativas.Text;

                        AlternativascheckedListBox.Items.Add(alt);
                        textBoxAlternativas.Clear();
                        textBoxAlternativas.Focus();
                    }
                }
            }
        }

        private void checkedListBoxAlternativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlternativascheckedListBox.CheckedItems.Count > 0)
            {
                foreach (int i in AlternativascheckedListBox.CheckedIndices)
                    AlternativascheckedListBox.SetItemCheckState(i, CheckState.Unchecked);

                List<Alternativas> alts = AlternativasAdicionadas;

                foreach (var item in alts)
                    if (AlternativascheckedListBox.SelectedItem != item)
                        item.EstaCerta = false;
            }
        }

        private void comboBoxDisciplinas_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxMaterias.Items.Clear();
            comboBoxMaterias.ResetText();
            PovoarMaterias((Disciplina)comboBoxDisciplinas.SelectedItem);
            comboBoxMaterias.Enabled = true;
        }
    }
}
