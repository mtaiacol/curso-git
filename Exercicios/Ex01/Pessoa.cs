using System;

namespace Ex01
{
    class Pessoa
    {
        public String Nome;
        public int Idade;

        public string MaiorIdade(int Idade1, string Nome1, int Idade2, string Nome2)
        {
            string Resp;
            if (Idade1 > Idade2) Resp = Nome1;
            else Resp = Nome2;

            return Resp;
        }
    }
}