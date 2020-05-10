using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.Models
{
    public class BaseModel
    {

        public long Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }
    }
}
