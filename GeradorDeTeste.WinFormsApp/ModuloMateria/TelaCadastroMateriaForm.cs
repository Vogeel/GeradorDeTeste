using FluentValidation.Results;
using GeradorDeTeste.Dominio.ModuloMateria;
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
    public partial class TelaCadastroMateriaForm : Form
    {
        public TelaCadastroMateriaForm(List<Dominio.ModuloDisciplina.Disciplina> disciplinas)
        {
            InitializeComponent();
        }

        public object Materia { get; internal set; }
        public Func<Materia, ValidationResult> GravarRegistro { get; internal set; }
    }
}
