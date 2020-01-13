using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Sqlite.Models
{
    public class Usuario
    {
        public long? UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
