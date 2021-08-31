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

        public Sala Sala { get => sala; set => sala = value; }
        public string Cor { get => cor; set => cor = value; }
        public float Largura { get => largura; set => largura = value; }
        public float Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }

        public Porta(string cor, float largura, float altura, double peso)
        {
            this.Cor = cor;
            this.Largura = largura;
            this.Altura = altura;
            this.Peso = peso;
        }


        public void abrir()
        {

        }
        public void fechar()
        {

        }
    }
}
