using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string questao;
        public Dictionary<string, bool> alternativas = new();
        public Materia materia;
        public int bimestre;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(questao);

            foreach (var item in alternativas)
            {
                sb.AppendLine(item.Key);
            }

            return sb.ToString();
        }

        public override void Atualizar(Questao registros)
        {
            throw new NotImplementedException();
        }
    }
}
