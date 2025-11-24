namespace TruequeTextil.Components.Pages.Usuario
{
    public interface IUsuarioRepository
    {
        Task<List<Models.Usuario>> ObtenerUsuarios();
    }
}
