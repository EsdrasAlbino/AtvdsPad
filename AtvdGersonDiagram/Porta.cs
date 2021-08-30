using System;

namespace AtvdGersonDiagram
{
    public class Porta
    {
        private Sala sala;
        private string cor;
        private float largura;
        private float altura;
        private double peso;

        public string Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }
        public Sala Sala { get; set; }

        public Porta(string cor, float largura, float altura, double peso)
        {
            this.cor = cor;
            this.largura = largura;
            this.altura = altura;
            this.peso = peso;
        }

        public void abrir()
        {

        }
        public void fechar()
        {

        }
    }
}
