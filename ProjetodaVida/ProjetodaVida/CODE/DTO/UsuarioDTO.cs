using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetodaVida.CODE.DTO
{
    class UsuarioDTO
    {
        private string nome;
        private string telefone;
        private string email;
        private string senha;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
