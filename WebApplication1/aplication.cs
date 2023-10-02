public class CategoriaService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaService(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public Categoria GetCategoriaById(int codigo)
    {
        return _categoriaRepository.GetCategoriaById(codigo);
    }

    public IEnumerable<Categoria> GetAllCategorias()
    {
        return _categoriaRepository.GetAllCategorias();
    }

    public Categoria CreateCategoria(Categoria categoria)
    {
        return _categoriaRepository.CreateCategoria(categoria);
    }

    public Categoria UpdateCategoria(int codigo, Categoria categoria)
    {
        return _categoriaRepository.UpdateCategoria(codigo, categoria);
    }

    public void DeleteCategoria(int codigo)
    {
        _categoriaRepository.DeleteCategoria(codigo);
    }
}

public class FornecedorService
{
    private readonly IFornecedorRepository _fornecedorRepository;

    public FornecedorService(IFornecedorRepository fornecedorRepository)
    {
        _fornecedorRepository = fornecedorRepository;
    }

    public Fornecedor GetFornecedorById(int codigo)
    {
        return _fornecedorRepository.GetFornecedorById(codigo);
    }

    public IEnumerable<Fornecedor> GetAllFornecedores()
    {
        return _fornecedorRepository.GetAllFornecedores();
    }

    public Fornecedor CreateFornecedor(Fornecedor fornecedor)
    {
        return _fornecedorRepository.CreateFornecedor(fornecedor);
    }

    public Fornecedor UpdateFornecedor(int codigo, Fornecedor fornecedor)
    {
        return _fornecedorRepository.UpdateFornecedor(codigo, fornecedor);
    }

    public void DeleteFornecedor(int codigo)
    {
        _fornecedorRepository.DeleteFornecedor(codigo);
    }
}