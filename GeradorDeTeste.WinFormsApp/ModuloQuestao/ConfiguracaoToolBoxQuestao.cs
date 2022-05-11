using GeradorDeTeste.WinFormsApp.Compartilhado;

namespace GeradorDeTeste.WinFormsApp
{
    public class ConfiguracaoToolBoxQuestao : ConfiguracaoToolBoxBase
    {
        public override string ToolTipInserir { get { return "Inserir uma nova Questão "; } }
        public override string ToolTipEditar { get { return "Editar uma  Questão existente "; } }
        public override string ToolTipExcluir { get { return "Excluir uma  Questão existente "; } }
    }
}