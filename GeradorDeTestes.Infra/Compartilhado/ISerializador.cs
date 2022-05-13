namespace GeradorDeTeste.Infra.Compartilhado
{
    public interface ISerializador
    {
        void GravarDadosEmArquivo(DataContext dataContext);
        DataContext CarregarDadosDoArquivo();
    }
}