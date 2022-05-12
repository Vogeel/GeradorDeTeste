using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;

namespace GeradorDeTeste.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public List<Questao> questoes = new List<Questao>();

        public string Nome { get; set; }
        public Disciplina(string titulo)
        {
            this.Nome = titulo;
        }

        public Disciplina()
        {
        }

        public override string ToString()
        {
            return Nome;
        }

        public override void Atualizar(Disciplina registros)
        {
            throw new NotImplementedException();
        }
    }
}
