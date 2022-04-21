namespace Compilador.API.Controllers
{
    public class Compilador
    {
        public string mensagem = "Token: ";

        public void compilar(string mensagemObjeto)
        {
            this.mensagem = this.mensagem + mensagemObjeto + "abcde";
        }
    }
}
