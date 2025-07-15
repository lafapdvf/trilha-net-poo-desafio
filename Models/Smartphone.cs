namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementado as propriedades do modelo, IMEI e memória. Por convenção, campos privados antes das demais propriedades e também do construtor
        private string Modelo;
        private string Imei;
        private int Memoria;
        public string Numero { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Numero {Numero}, Modelo {Modelo}, IMEI {Imei} e Memória {Memoria} Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}