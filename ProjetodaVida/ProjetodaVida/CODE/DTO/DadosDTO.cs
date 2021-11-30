using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetodaVida.CODE.DTO
{
    class DadosDTO
    {
        private int id;
        private string eds;
        private string e06;
        private string s19;

        public int Id { get => id; set => id = value; }
        public string Eds { get => eds; set => eds = value; }
        public string E06 { get => e06; set => e06 = value; }
        public string S19 { get => s19; set => s19 = value; }
    }
}
