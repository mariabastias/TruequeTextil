using Microsoft.Data.SqlClient;
namespace TruequeTextil.Components.Pages.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString;
        public UsuarioRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString(name: "DefaultConnection")!;
        }
        public async Task<List<Models.Usuario>> ObtenerUsuarios()
        {
            var lista = new List<Models.Usuario>();

            using var con = new SqlConnection(_connectionString);

            using var cmd = new SqlCommand(cmdText: "SELECT * FROM UsuarioDemo", con);

            await con.OpenAsync();

            var rd = await cmd.ExecuteReaderAsync();

            while (await rd.ReadAsync())
            {
                lista.Add(new Models.Usuario
                {
                 
                    Nombre = rd.GetString(i: 0),
                    Apellido = rd.GetString(i: 1),
                    NumeroTelefono = rd.GetString(i: 2),
                    CorreoElectronico = rd.GetString(i: 3)
                    
                });

               
            }

            return lista;
        }
    }
}
