using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.Models
{
    public class Aviso : BaseModel
    {
        [Required(ErrorMessage ="Campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo tipo aviso é obrigatório")]
        public string TipoAviso { get; set; } // este campo deverá ser futuramente um Enum
    }
}
