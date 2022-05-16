using GeradorDeTeste.Dominio.ModuloQuestao;
using GeradorDeTeste.WinApp.Compartilhado;
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
    public partial class ListagemQuestaoControl : UserControl
    {
        public ListagemQuestaoControl()
        {
            InitializeComponent();
            gridQuestao.ConfigurarGridZebrado();
            gridQuestao.ConfigurarGridSomenteLeitura();
            gridQuestao.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Matéria"}
            };

            return colunas;
        }

        public int ObtemNumeroMateriaSelecionada()
        {
            return gridQuestao.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao questao in questoes)
            {
                gridQuestao.Rows.Add(questao.Numero, questao.Enunciado, questao.Disciplina, questao.Materia);
            }

        }
    }
}
