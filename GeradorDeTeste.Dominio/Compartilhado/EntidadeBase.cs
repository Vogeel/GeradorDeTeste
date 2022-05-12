using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public abstract void Atualizar(T registros);
    }
}
