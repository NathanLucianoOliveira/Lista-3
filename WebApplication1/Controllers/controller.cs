using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/categorias")]
public class CategoriaController : ControllerBase
{
    private readonly CategoriaService _categoriaService;

    public CategoriaController(CategoriaService categoriaService)
    {
        _categoriaService = categoriaService;
    }

    [HttpGet("{codigo}")]
    public IActionResult GetCategoria(int codigo)
    {
        var categoria = _categoriaService.GetCategoriaById(codigo);
        if (categoria == null)
        {
            return NotFound();
        }
        return Ok(categoria);
    }

    [HttpGet]
    public IActionResult GetCategorias()
    {
        var categorias = _categoriaService.GetAllCategorias();
        return Ok(categorias);
    }

    [HttpPost]
    public IActionResult CreateCategoria(Categoria categoria)
    {
        var newCategoria = _categoriaService.CreateCategoria(categoria);
        return CreatedAtAction(nameof(GetCategoria), new { codigo = newCategoria.Codigo }, newCategoria);
    }

    [HttpPut("{codigo}")]
    public IActionResult UpdateCategoria(int codigo, Categoria categoria)
    {
        var updatedCategoria = _categoriaService.UpdateCategoria(codigo, categoria);
        if (updatedCategoria == null)
        {
            return NotFound();
        }
        return Ok(updatedCategoria);
    }

    [HttpDelete("{codigo}")]
    public IActionResult DeleteCategoria(int codigo)
    {
        _categoriaService.DeleteCategoria(codigo);
        return NoContent();
    }
}

[ApiController]
[Route("api/fornecedores")]
public class FornecedorController : ControllerBase
{
    private readonly FornecedorService _fornecedorService;

    public FornecedorController(FornecedorService fornecedorService)
    {
        _fornecedorService = fornecedorService;
    }

    [HttpGet("{codigo}")]
    public IActionResult GetFornecedor(int codigo)
    {
        var fornecedor = _fornecedorService.GetFornecedorById(codigo);
        if (fornecedor == null)
        {
            return NotFound();
        }
        return Ok(fornecedor);
    }

    [HttpGet]
    public IActionResult GetFornecedores()
    {
        var fornecedores = _fornecedorService.GetAllFornecedores();
        return Ok(fornecedores);
    }

    [HttpPost]
    public IActionResult CreateFornecedor(Fornecedor fornecedor)
    {
        var newFornecedor = _fornecedorService.CreateFornecedor(fornecedor);
        return CreatedAtAction(nameof(GetFornecedor), new { codigo = newFornecedor.Codigo }, newFornecedor);
    }

    [HttpPut("{codigo}")]
    public IActionResult UpdateFornecedor(int codigo, Fornecedor fornecedor)
    {
        var updatedFornecedor = _fornecedorService.UpdateFornecedor(codigo, fornecedor);
        if (updatedFornecedor == null)
        {
            return NotFound();
        }
        return Ok(updatedFornecedor);
    }

    [HttpDelete("{codigo}")]
    public IActionResult DeleteFornecedor(int codigo)
    {
        _fornecedorService.DeleteFornecedor(codigo);
        return NoContent();
    }
}
