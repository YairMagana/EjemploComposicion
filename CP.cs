namespace EjemploComposicion
{

    public class CP
    {
        string cId;
        public decimal ene;
        public decimal feb;
        public decimal mar;
        public decimal abr;

        public CP(string _cId, int _ene, int _feb, int _mar, int _abr)
        {
            cId = _cId;
            ene = _ene;
            feb = _feb;
            mar = _mar;
            abr = _abr;
        }
    }

}
