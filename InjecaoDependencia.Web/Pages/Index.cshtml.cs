using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InjecaoDependencia.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; private set; }

        public void OnGet()
        {
            Mensagem = "Exemplo de Injeção de Dependência";
        }

        public void OnExecutar()
        {
            Mensagem = "Mudou";
        }
    }
}
