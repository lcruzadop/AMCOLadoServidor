using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmcoServerSide.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
  private readonly IJSRuntime js;

        public MostrarMensajes(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task MostrarMensajeError(string message)
        {
            await MostrarMensaje("Error", message, "error");
        }

        public async Task MostrarMensajeExitoso(string message)
        {
            await MostrarMensaje("Exitoso", message, "success");
        }

        private async ValueTask MostrarMensaje(string title, string message, string messageType)
        {
            await js.InvokeVoidAsync("Swal.fire", title, message, messageType);
        }

    }
}
