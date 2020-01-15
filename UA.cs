using System.Collections.Generic;

namespace EjemploComposicion
{
    partial class Program
    {
        public class UA : AbstractUA
        {
            public int cId;
            private List<AbstractUA> hijos = new List<AbstractUA>();

            public override void AgregarUAHija(AbstractUA ua)
            {
                hijos.Add(ua);
            }

            public override void QuitarUAHija(AbstractUA ua)
            {
                hijos.Remove(ua);
            }

            public override decimal ObtenerTotales()
            {
                decimal resultado = 0;
                foreach (AbstractUA ua in hijos)
                {
                    resultado += ua.ObtenerTotales();
                }

                return resultado;
            }
        }
    }
}
