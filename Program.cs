using bibliotec.Contexts;                  // Importa o DbContext do projeto (BbDbContext)
using bibliotec.Interfaces;
using bibliotec.Repostories;
using bibliotec.Services;
using Bibliotec_MVC.Interfaces;
using Bibliotec_MVC.Repostories;
using Microsoft.EntityFrameworkCore; // Importa os métodos do EF Core (UseSqlServer, etc.)

// Cria o builder da aplicação, que é responsável por configurar e montar o app
var builder = WebApplication.CreateBuilder(args);

// ===== REGISTRO DE SERVIÇOS (Injeção de Dependência) =====
// Tudo que for adicionado aqui fica disponível para ser injetado nos Controllers, etc.

// Registra suporte a Controllers MVC + renderização de Views (padrão MVC)
builder.Services.AddControllersWithViews();

// Registra o DbContext (conexão com o banco de dados)
// BbDbContext será injetável em qualquer lugar que precisar acessar o banco
builder.Services.AddDbContext<BbDbContext>(options =>
    options.UseSqlServer(                                          // Define SQL Server como banco de dados
        builder.Configuration.GetConnectionString("DefaultConnection")  // Lê a connection string do appsettings.json
        // ⚠️ "DefaultConection" está com erro de digitação — o convencional é "DefaultConnection" (dois n's)
        //    Certifique-se de que o nome aqui é IDÊNTICO ao que está no appsettings.json
    ));

// Registra o serviço de Sessão (usado para manter dados entre requisições, ex: usuário logado)
    builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromHours(2); // Sessão expira após 2 horas de inatividade
    options.Cookie.HttpOnly = true;              // Cookie não acessível via JavaScript (proteção contra XSS)
    options.Cookie.IsEssential = true;           // Cookie mantido mesmo se o usuário não aceitou cookies opcionais (LGPD/GDPR)
});

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>
();
builder.Services.AddScoped<IUsuarioService, UsuarioService>
();
builder.Services.AddScoped<ILivroService, LivroService>
();
builder.Services.AddScoped<ILivroRepository, LivroRepository>
();


// Constrói o app com todas as configurações e serviços registrados acima
var app = builder.Build();

// ===== PIPELINE DE MIDDLEWARES (ordem importa — cada request passa por eles em sequência) =====

// Em produção, ativa o HSTS: força o navegador a usar HTTPS por um período determinado
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection(); // Redireciona automaticamente requisições HTTP para HTTPS

app.UseRouting();          // Habilita o sistema de roteamento (identifica qual controller/action chamar)

app.UseSession();          // Habilita o uso de sessão nas requisições
                           // ⚠️ Deve vir ANTES de UseAuthorization para funcionar corretamente

app.UseAuthorization();    // Habilita verificação de permissões/autorização nas rotas protegidas

app.MapStaticAssets();     // Mapeia arquivos estáticos otimizados (CSS, JS, imagens) — versão moderna do UseStaticFiles()

// Define a rota padrão do MVC:
// Se a URL não especificar controller/action, cai em HomeController → método Index
// O {id?} indica que o parâmetro id é opcional
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets(); // Associa os assets estáticos otimizados às rotas mapeadas

// Inicia o servidor e fica ouvindo requisições
app.Run();