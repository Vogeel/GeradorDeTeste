
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloQuestao
{
    public class ValidarQuestao : AbstractValidator<Questao>
    {
        public ValidarQuestao()
        {
            RuleFor(x => x.questao)
                .NotNull().NotEmpty()
                .WithMessage("Nome da questao é obrigatorio");
        }
    
    }
}
