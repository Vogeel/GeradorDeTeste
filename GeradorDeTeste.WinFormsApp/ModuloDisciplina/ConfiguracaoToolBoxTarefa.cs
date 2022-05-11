using GeradorDeTeste.WinFormsApp.Compartilhado;

namespace GeradorDeTeste.WinFormsApp
{
    public class ConfiguracaoToolBoxTarefa : ConfiguracaoToolBoxBase
    {
        public override string ToolTipInserir { get { return "Inserir uma nova disciplina "; } }
        public override string ToolTipEditar { get { return "Editar uma disciplina existente "; } }
        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente "; } }
        

    }
}