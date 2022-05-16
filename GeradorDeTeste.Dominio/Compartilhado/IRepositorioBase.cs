using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T : EntidadeBase<T>
    {
        ValidationResult Inserir(T novoRegistro);

        ValidationResult Editar(T registro);

        ValidationResult Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorNumero(int numero);

    }
}
