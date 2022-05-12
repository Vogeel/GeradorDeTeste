using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorioBase<Materia>
    {
        List<Disciplina> ObterDisciplinas();
    }
}
