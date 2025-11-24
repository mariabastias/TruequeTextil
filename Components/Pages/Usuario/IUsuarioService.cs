namespace TruequeTextil.Components.Pages.Usuario
{
    public interface IUsuarioService
    {
        Task<List<Models.Usuario>> ObtenerUsuarios();
    }
}
