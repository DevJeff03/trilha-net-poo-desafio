using System.Dynamic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Dados do smartphone: \nNumero: {Numero},\nModelo: {Modelo}\n"
                    + $"Imei: {Imei} \nMemória RAM: {Memoria}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}