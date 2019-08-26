using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalaoMVC.Models.ViewsModel
{
    public class LoginViewModel
    {
       
            public string usuario { get; set; }
            public string senha { get; set; }
            public IEnumerable<SelectListItem> ActionsList { get; set; }
    
            public string tipoUsuario { get; set; }

        
    }
}
