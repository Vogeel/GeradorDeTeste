using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloMateria
{
    public class ValidarMateria : AbstractValidator<Materia>
    {
        public ValidarMateria()
        {
            RuleFor(x => x.Serie)
                .NotNull().NotEmpty().InclusiveBetween(1, 2)
                .WithMessage("Serie da Materia é obrigatorio, 1 ou 2");
        }
    }
}
