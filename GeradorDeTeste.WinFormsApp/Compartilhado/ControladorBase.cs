using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.WinFormsApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Excluir();
        public abstract void Inserir();
        public abstract void Editar();
    }
}
