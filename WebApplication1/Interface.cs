public interface IFornecedorRepository
{
    Fornecedor GetFornecedorById(int codigo);
    IEnumerable<Fornecedor> GetAllFornecedores();
    Fornecedor CreateFornecedor(Fornecedor fornecedor);
    Fornecedor UpdateFornecedor(int codigo, Fornecedor fornecedor);
    void DeleteFornecedor(int codigo);
}