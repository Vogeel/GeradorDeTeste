using GeradorDeTeste.Dominio.Compartilhado;
using GeradorDeTeste.Dominio.ModuloDisciplina;
using GeradorDeTeste.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorioBase<Teste>
    {
        List<Questao> SelecionarQuestoes();
        List<Disciplina> ObterDiscplinas();
    }
}
