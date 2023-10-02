public class CategoriaRepository : ICategoriaRepository
{
    private List<Categoria> categorias = new List<Categoria>();

    public Categoria GetCategoriaById(int codigo)
    {
        return categorias.FirstOrDefault(c => c.Codigo == codigo);
    }

    public IEnumerable<Categoria> GetAllCategorias()
    {
        return categorias;
    }

    public Categoria CreateCategoria(Categoria categoria)
    {
        categoria.Codigo = categorias.Count + 1;
        categorias.Add(categoria);
        return categoria;
    }

    public Categoria UpdateCategoria(int codigo, Categoria categoria)
    {
        var existingCategoria = GetCategoriaById(codigo);
        if (existingCategoria != null)
        {
            existingCategoria.Descricao = categoria.Descricao;
        }
        return existingCategoria;
    }

    public void DeleteCategoria(int codigo)
    {
        var categoriaToRemove = GetCategoriaById(codigo);
        if (categoriaToRemove != null)
        {
            categorias.Remove(categoriaToRemove);
        }
    }
}

public class FornecedorRepository : IFornecedorRepository
{
    private List<Fornecedor> fornecedores = new List<Fornecedor>();

    public Fornecedor GetFornecedorById(int codigo)
    {
        return fornecedores.FirstOrDefault(f => f.Codigo == codigo);
    }

    public IEnumerable<Fornecedor> GetAllFornecedores()
    {
        return fornecedores;
    }

    public Fornecedor CreateFornecedor(Fornecedor fornecedor)
    {
        fornecedor.Codigo = fornecedores.Count + 1;
        fornecedores.Add(fornecedor);
        return fornecedor;
    }

    public Fornecedor UpdateFornecedor(int codigo, Fornecedor fornecedor)
    {
        var existingFornecedor = GetFornecedorById(codigo);
        if (existingFornecedor != null)
        {
            existingFornecedor.RazaoSocial = fornecedor.RazaoSocial;
            existingFornecedor.CNPJ = fornecedor.CNPJ;
            existingFornecedor.Ativo = fornecedor.Ativo;
            existingFornecedor.DataCadastro = fornecedor.DataCadastro;
            existingFornecedor.EmailContato = fornecedor.EmailContato;
        }
        return existingFornecedor;
    }

    public void DeleteFornecedor(int codigo)
    {
        var fornecedorToRemove = GetFornecedorById(codigo);
        if (fornecedorToRemove != null)
        {
            fornecedores.Remove(fornecedorToRemove);
        }
    }
}