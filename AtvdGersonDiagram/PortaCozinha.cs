using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class PortaCozinha : Porta
    {
        public Cozinha cozinha = new Cozinha();

        public PortaCozinha(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }

    }
}
