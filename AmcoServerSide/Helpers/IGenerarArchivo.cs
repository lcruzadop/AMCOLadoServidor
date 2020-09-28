using System;
using System.Threading.Tasks;

namespace AmcoServerSide.Helpers
{
    public interface IGenerarArchivo
    {
        Task GenerarPdf(string data);
    }
}