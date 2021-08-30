using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class PortaQuarto : Porta
    {

        public Quarto quarto;

        public PortaQuarto(string cor, float largura, float altura, double peso, PortaQuarto q, bool b, float m) : base(cor, largura, altura, peso)
        {
            quarto = new Quarto(q,b,m);
        }


    }
}
