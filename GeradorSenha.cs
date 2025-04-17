using System;
using System.Text;

namespace GeradorDeSenhas
{
    public class GeradorSenha
    {
        private Random random = new Random();
        private char[] especiais = { '!', '@', '#', '$', '%', '&', '*', '?', '/' };

        public string GerarSenha(int tamanho)
        {
            if (tamanho < 4)
            {
                throw new ArgumentException("A senha precisa ter no mínimo 4 caracteres.");
            }

            StringBuilder senha = new StringBuilder();

            // Garante pelo menos um de cada tipo
            senha.Append((char)random.Next('A', 'Z' + 1));
            senha.Append((char)random.Next('a', 'z' + 1));
            senha.Append(especiais[random.Next(especiais.Length)]);
            senha.Append(random.Next(10));

            for (int i = 4; i < tamanho; i++)
            {
                switch (random.Next(0, 4))
                {
                    case 0:
                        senha.Append((char)random.Next('A', 'Z' + 1));
                        break;
                    case 1:
                        senha.Append((char)random.Next('a', 'z' + 1));
                        break;
                    case 2:
                        senha.Append(especiais[random.Next(especiais.Length)]);
                        break;
                    case 3:
                        senha.Append(random.Next(10));
                        break;
                }
            }
            return new string(senha.ToString().OrderBy(c => random.Next()).ToArray());
        }
    }
}
