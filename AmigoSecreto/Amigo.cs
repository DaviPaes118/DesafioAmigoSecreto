using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    public class Amigo
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            Amigo amigoObj = obj as Amigo;
            if (amigoObj == null) return false;
            return amigoObj.Email == Email;
        }
    }
}
