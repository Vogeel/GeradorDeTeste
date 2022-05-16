using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public int Serie { get; set; }
        public Disciplina Disciplina { get; set; }

        public Materia(int serie, Disciplina disciplina, string nome)
        {
            this.Serie = serie;
            this.Disciplina = disciplina;
            Nome = nome;
        }
        public Materia()
        {

        }
        public override string ToString()
        {
            return $"{Nome},{Serie}ª";
        }
        public override void Atualizar(Materia registros)
        {
            throw new NotImplementedException();
        }
        public Materia Clone()
        {
            return new Materia
            {
                Numero = this.Numero,
                Nome = this.Nome,
                Serie = this.Serie,
                Disciplina = this.Disciplina
            };
        }
    }
}
