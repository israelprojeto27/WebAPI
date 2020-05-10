using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.Models
{
    public class Produto : BaseModel
    {
        [Required(ErrorMessage ="Campo nome é obrigatório")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo preço é obrigatório")]        
        public decimal? Preco { get; set; }
    }
}
