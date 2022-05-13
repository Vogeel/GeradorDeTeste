using GeradorDeTeste.Dominio.ModuloDisciplina;
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

namespace GeradorDeTeste.WinFormsApp.ModuloDisciplina
{
    public partial class ListagemDisciplinaControl : UserControl
    {
        public ListagemDisciplinaControl()
        {
            InitializeComponent();
        }

        public object ObtemNumeroDisciplinaSelecionado()
        {
            return GridDisciplina.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            GridDisciplina.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                GridDisciplina.Rows.Add( disciplina.Nome);
            }
        }
    }
}
