using System;

namespace SuperTrunfoFutebol
{
    // Exceção personalizada: usada sempre que um dado da carta ou uma escolha
    // do jogador não é válida. Herda de Exception, a classe base de erros do C#.
    public class AtributoInvalidoException : Exception
    {
        public AtributoInvalidoException(string mensagem) : base(mensagem)
        {
        }
    }
}
