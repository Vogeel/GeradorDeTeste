
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GeradorDeTeste.Dominio.ModuloDisciplina
{
    public class ValidarDisciplina : AbstractValidator<Disciplina>
    {
        public ValidarDisciplina()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty()
                .WithMessage("Nome da disciplina é obrigatorio");
        }
    }
}
