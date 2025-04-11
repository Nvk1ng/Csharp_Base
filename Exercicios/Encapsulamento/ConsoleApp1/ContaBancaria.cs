namespace ConsoleApp1{
    class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string  titular){
            Numero = numero;
            Titular = titular;
        }
    }
}