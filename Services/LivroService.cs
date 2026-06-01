using Bibliotec_MVC.Models;
using Bibliotec_MVC.Interfaces;


namespace Bibliotec_MVC.Services
{
    public class LivroService : ILivroService
    {

        private readonly ILivroRepository _livroRepository;
        
        public LivroService(ILivroRepository livroRepository)

        {
            _livroRepository = livroRepository;
        }

        public async Task<IEnumerable<Livro>> BuscarLivrosComCatAsync()
        {
            return await _livroRepository.BuscarLivrosAsync();
        }

        public async Task CadastrarLivroAsync(Livro l, string? catSelecionadas, IFormFile arquivoImagem, string? ativo)
         {
            l.Status = ativo == "true" ? "D" : "I";

            if(arquivoImagem != null && arquivoImagem.Length > 0)
            {
                l.Imagem = await UploadImageAsync(arquivoImagem);
            }
            else
            {
                l.Imagem = "";
            }

            await _livroRepository.CadastrarLivro(l);

            if(!string.IsNullOrEmpty(catSelecionadas))
            {
                var categoriasIds = catSelecionadas.Split(',')
                    .Select(id => int.TryParse(id, out var convertido) ? convertido : 0)
                    .Where(id => id > 0).ToList();

                    foreach(var catId in categoriasIds)
                {
                    LivroCategoria lc = new  LivroCategoria
                    {
                        LivroId = l.Id,
                        CategoriaId = catId
                    };
                    await _livroRepository.CadastrarCatLivroAsync(lc);
                }
            }
         }

        public async Task<IEnumerable<Categoria>> ListarCategoriasAsync()
        {
            return await _livroRepository.ListarCategoriasAsync();
        }

        public async Task<bool> RemoverLivroAsync(int id)
        {
            Livro? l= await _livroRepository.BuscarLivrosIdAsync(id);
            if (l == null)
            {
                return false;
            }

            await _livroRepository.DeletarLivroAsync(l);
            await _livroRepository.DeletarCatLivroAsync(id);
            return true;
        }

        private async Task<string> UploadImageAsync(IFormFile arquivoImagem)
        {
            string caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "capaLivros");

            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }

            var nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(arquivoImagem.FileName);

            var caminhoArquivo = Path.Combine(caminhoPasta, nomeArquivo);

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                await arquivoImagem.CopyToAsync(stream);                
            }

            return $"~/img/capaLivros/{nomeArquivo}";
        }
    }

    
}