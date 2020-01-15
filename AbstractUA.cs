using System;

namespace EjemploComposicion
{

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
}
