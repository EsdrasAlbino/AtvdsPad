using System;
using System.Collections.Generic;
using System.Text;

namespace AtvdGersonDiagram
{
    public class Cozinha
    {
        private PortaCozinha porta;
        private bool americana;
        private float metragemQuadrada;

        public Cozinha()
        {
        }

        public Cozinha(PortaCozinha porta, bool americana, float metragemQuadrada)
        {
            this.porta = porta;
            this.americana = americana;
            this.metragemQuadrada = metragemQuadrada;
        }

        public PortaCozinha Porta { get => Porta; set => Porta = value; }
        public bool Americana { get => Americana; set => Americana = value; }
        public float MetragemQuadrada { get => metragemQuadrada; set => metragemQuadrada = value; }
    }
}
