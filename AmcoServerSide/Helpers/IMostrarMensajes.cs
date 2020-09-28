using System.Threading.Tasks;

namespace AmcoServerSide.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string message);
        Task MostrarMensajeExitoso(string message);
    }
}