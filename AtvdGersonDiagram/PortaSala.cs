using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class PortaDaSala : Porta
    {

        public Sala salaA;

        public PortaDaSala(string cor, float largura, float altura, double peso, PortaDaSala s, float m, Porta p) : base(cor, largura, altura, peso)
        {
            salaA = new Sala(s,m,p);
        }

    }
}
