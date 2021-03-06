using FluentValidation.Results;
using GeradorDeTeste.Dominio.ModuloDisciplina;
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
    public partial class TelaCadastroDisciplinaForm : Form
    {
        private Disciplina disciplina;
        public TelaCadastroDisciplinaForm()
        {
            InitializeComponent();
        }

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get
            {
                return disciplina;
            }
            set
            {
                disciplina = value;          
                NomeDisciplinatextBox.Text = disciplina.Nome;
            }
        }

       

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            disciplina.Nome = NomeDisciplinatextBox.Text;


            var resultadoValidacao = GravarRegistro(disciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarMsgRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
