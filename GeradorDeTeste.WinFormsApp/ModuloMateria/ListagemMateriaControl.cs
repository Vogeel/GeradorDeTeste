using GeradorDeTeste.Dominio.ModuloMateria;
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


namespace GeradorDeTeste.WinFormsApp.ModuloMateria
{
    public partial class ListagemMateriaControl : UserControl
    {
        public ListagemMateriaControl()
        {
            InitializeComponent();

            GridMateria.ConfigurarGridZebrado();
            GridMateria.ConfigurarGridSomenteLeitura();
            GridMateria.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            GridMateria.Rows!.Clear();

            foreach (Materia disciplina in materias)
            {
                GridMateria.Rows.Add(disciplina.Nome);
            }

             
        }
        public int ObtemNumeroMateriaSelecionadas()
        {
            return GridMateria.SelecionarNumero<int>();
        }
    }
}
