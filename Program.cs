using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposicion
{
    class Program
    {
        public class CP
        {
            string cId;
            public decimal ene;
            public decimal feb;
            public decimal mar;
            public decimal abr;

            public CP(string cid)
            {
                string cId = cid;
                Random r = new Random();
                ene = r.Next(0, 1000);
                feb = r.Next(0, 1000);
                mar = r.Next(0, 1000);
                abr = r.Next(0, 1000);
            }
        }

        public abstract class AbstractUA
        {
            public AbstractUA() { }

            public abstract decimal ObtenerTotales();

            public virtual void AgregarUAHija(AbstractUA component)
            {
                throw new NotImplementedException();
            }

            public virtual void QuitarUAHija(AbstractUA component)
            {
                throw new NotImplementedException();
            }

            public virtual bool esComposicion()
            {
                return true;
            }
        }

        public class ClavePresupuestal : AbstractUA
        {
            CP cp;

            public ClavePresupuestal(CP _cp)
            {
                cp = _cp;
            }

            public override decimal ObtenerTotales()
            {
                return cp.ene + cp.feb +cp.mar + cp.mar;
            }

            public override bool esComposicion()
            {
                return false;
            }
        }

        public class UA : AbstractUA
        {
            public int id;
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
                int i = 0;
                decimal result = 0;

                foreach (AbstractUA ua in hijos)
                {
                    result += ua.ObtenerTotales();
                }

                return result;
            }
        }

        static void Main(string[] args)
        {
            CP cp1 = new CP("1.1.1");
            CP cp2 = new CP("1.1.2");


            ClavePresupuestal cp111 = new ClavePresupuestal(cp1);
            ClavePresupuestal cp112 = new ClavePresupuestal(cp1);
        }
    }
}
