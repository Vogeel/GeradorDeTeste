using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina _repositorioDisciplina;
        private ListagemDisciplinaControl listagemDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            _repositorioDisciplina = repositorioDisciplina;
        }
        public override Disciplina ObtemSelecionada()
        {
            var numero = listagemDisciplinas.ObtemNumeroDisciplinaSelecionado();

            return _repositorioDisciplina.SelecionarPorNumero(numero);
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObtemSelecionada();

            if(disciplinaSelecionada == null)
            {
                MessageBox.Show("Nenhuma disciplina selecionada",
                                "Editar de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDisciplinaForm tela = new();

            tela. = disciplinaSelecionada;
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObtemListagem()
        {
            throw new NotImplementedException();
        }
    }
}
