using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmcoServerSide.Helpers
{
    public class GenerarArchivo : IGenerarArchivo
    {
        private readonly IJSRuntime js;

        public GenerarArchivo(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task GenerarPdf(string data)
        {
            await SalvarComo("AMCOQR.pdf", data);
        }
        private async ValueTask SalvarComo(string nombre, string data)
        {
            await js.InvokeVoidAsync("saveAsFile", nombre, data);
        }
    }
}
