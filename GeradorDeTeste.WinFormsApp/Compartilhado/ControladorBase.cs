using GeradorDeTeste.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTeste.WinFormsApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Excluir();
        public abstract void Inserir();
        public abstract void Editar();

        public virtual Disciplina ObtemSelecionada() { return new(); }
        public virtual void AtualizarQuestoes() { }

        public abstract UserControl ObtemListagem();

        public abstract ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox();
    }
}
