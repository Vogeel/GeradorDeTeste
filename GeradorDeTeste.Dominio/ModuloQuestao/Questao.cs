using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloDisciplina;
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
        public string Enunciado { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public List<Alternativas> Alternativas { get; set; }


        public Questao()
        {
            Alternativas = new();
        }

        public void AdicionarAlternativas(List<Alternativas> alts)
        {
            foreach (var item in alts)
                if (Alternativas.Exists(x => x.Equals(item)) == false)
                    this.Alternativas.Add(item);
        }

        public override void Atualizar(Questao registro)
        {
            this.Enunciado = registro.Enunciado;
            this.Disciplina = registro.Disciplina;
            this.Materia = registro.Materia;
            this.Alternativas = registro.Alternativas;
        }

        public Questao Clone()
        {
            return new Questao
            {
                Numero = this.Numero,
                Enunciado = this.Enunciado,
                Disciplina = this.Disciplina,
                Materia = this.Materia,
                Alternativas = this.Alternativas
            };
        }
    }
}
