using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorioBase<Disciplina>
    {
        List<Questao> SelecionarQuestoes();
        Disciplina SelecionarPorNumero(object numero);
    }
}
