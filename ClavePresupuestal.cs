namespace EjemploComposicion
{
    partial class Program
    {
        public class ClavePresupuestal : AbstractUA
        {
            CP cp;

            public ClavePresupuestal(CP _cp)
            {
                cp = _cp;
            }

            public override decimal ObtenerTotales()
            {
                return cp.ene + cp.feb +cp.mar + cp.abr;
            }

            public override bool esComposicion()
            {
                return false;
            }
        }
    }
}
