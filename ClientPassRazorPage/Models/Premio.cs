using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.Models
{
    public class Premio : BaseModel
    {
        public string Descricao { get; set; }

        public int QuantidadePontos { get; set; }
    }
}
