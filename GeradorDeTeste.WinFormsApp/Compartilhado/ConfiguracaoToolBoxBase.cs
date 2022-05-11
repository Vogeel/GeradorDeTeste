using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.WinFormsApp.Compartilhado
{
    public abstract class ConfiguracaoToolBoxBase
    {
        public abstract string ToolTipInserir { get ; } 
        public abstract string ToolTipEditar { get ; } 
        public abstract string ToolTipExcluir { get ; } 
    }
}
