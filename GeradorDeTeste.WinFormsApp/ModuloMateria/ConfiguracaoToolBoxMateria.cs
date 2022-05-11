using GeradorDeTeste.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.WinFormsApp.ModuloMateria
{
    public class ConfiguracaoToolBoxMateria : ConfiguracaoToolBoxBase
    {
        public override string ToolTipInserir { get { return "Inserir uma nova Materia "; } }
        public override string ToolTipEditar { get { return "Editar uma  Materia existente "; } }
        public override string ToolTipExcluir { get { return "Excluir uma  Materia existente "; } }

    }
}
