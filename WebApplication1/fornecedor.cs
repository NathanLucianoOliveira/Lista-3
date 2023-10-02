public class Fornecedor
{
    public int Codigo { get; set; }
    public string RazaoSocial { get; set; }
    public string CNPJ { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }
    public string EmailContato { get; set; }
}