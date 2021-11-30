using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetodaVida.CODE.DTO
{
    class LoginDTO
    {
        private string cpf;
        private string email;
        private string senha;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
