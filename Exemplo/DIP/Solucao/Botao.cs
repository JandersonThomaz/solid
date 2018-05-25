
namespace Exemplo.DIP.Solucao
{
    public class Botao
    {
        private readonly IDispositivo dispositivo;

        public Botao(IDispositivo dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        public void Acionar()
        {
            dispositivo.Ligar();
        }
    }
}
