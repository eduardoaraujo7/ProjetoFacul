using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DTO
{
    public class Cadastro
    {
        public int Id_Nome { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
