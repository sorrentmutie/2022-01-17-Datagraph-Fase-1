using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MioPrimoSitoMVC.ViewComponents
{
    public class MyFirstViewComponent:  ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int parametro)
        {
            int id = await MioCodiceAsincrono(parametro);
            return View("Datagraph", id);
            //return Task.FromResult<IViewComponentResult>(View("Datagraph"));
        }

        private async Task<int> MioCodiceAsincrono(int parametro)
        {
            await Task.Run(() => { });
            return parametro * 2;
        }
    }
}
