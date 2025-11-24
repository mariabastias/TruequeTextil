
namespace TruequeTextil.Components.Pages.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repositorio;

        public UsuarioService(IUsuarioRepository repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<Models.Usuario>> ObtenerUsuarios()
        {
            return await _repositorio.ObtenerUsuarios();
        }
    }
}
