using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.Dominio.ModuloMateria;
using GeradorDeTeste.Dominio.ModuloQuestao;
using GeradorDeTeste.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Infra.Compartilhado
{
    [Serializable]
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Disciplinas = new List<Disciplina>();
            Materias = new List<Materia>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplina> Disciplinas { get; set; }

        public List<Materia> Materias { get; set; }

        //public List<Questao> Compromissos { get; set; }

        //public List<Teste> Despesas { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);

            //if (ctx.Questoes.Any())
            //    this.Questoes.AddRange(ctx.Questoes);

            //if (ctx.Testes.Any())
            //    this.Testes.AddRange(ctx.Testes);
        }
    }
    }
}
