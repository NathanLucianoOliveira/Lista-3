public interface ICategoriaRepository
{
    Categoria GetCategoriaById(int codigo);
    IEnumerable<Categoria> GetAllCategorias();
    Categoria CreateCategoria(Categoria categoria);
    Categoria UpdateCategoria(int codigo, Categoria categoria);
    void DeleteCategoria(int codigo);
}