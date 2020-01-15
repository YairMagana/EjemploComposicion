using static EjemploComposicion.Program;

namespace EjemploComposicion
{

    public class ClavePresupuestal : AbstractUA
    {
        public string cId;
        CP cp;

        public ClavePresupuestal(CP _cp, string _cId)
        {
            cp = _cp;
            cId = _cId;
        }

        public override decimal ObtenerTotales()
        {
            return cp.ene + cp.feb + cp.mar + cp.abr;
        }

        public override bool esComposicion()
        {
            return false;
        }
    }

}
