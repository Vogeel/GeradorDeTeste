

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloTeste
{
    public class ValidarTeste : AbstractValidator<Teste>
    {
        public ValidarTeste()
        {
            RuleFor(x => x.Questoes.Count)
                .Equal(x => x.NumeroQuestoes)
                .WithMessage("não a questoes suficientes com esses criterios");
        }
    }
}
