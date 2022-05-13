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

        public virtual bool StatusInserir {get {return true;}}
        public virtual bool StatusEditar { get { return true; } }
        public virtual bool StatusExcluir { get { return true; } }
        public virtual bool StatusPDF { get { return true; } }
    }
}
