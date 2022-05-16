using GeradorDeTeste.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloQuestao
{
    public class Alternativas : EntidadeBase<Alternativas>
    {
        public string Opcao { get; set; }
        public bool EstaCerta { get; set; }

       

        public override void Atualizar(Alternativas registros)
        {
            this.Opcao = registros.Opcao;
            this.EstaCerta = registros.EstaCerta;
        }

        public override string ToString()
        {
            return Opcao;
        }
    }
}
