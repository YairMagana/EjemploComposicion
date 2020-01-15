using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposicion
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CP CP111 = new CP("1.1.1", 152, 40, 1506, 184);
            CP CP112 = new CP("1.1.2", 75, 147, 68, 1489);
            CP CP211 = new CP("2.1.1", 145, 105, 400, 5);
            CP CP31 = new CP("3.1", 1788, 910, 120, 153);
            CP CP4 = new CP("4", 12, 0, 15, 8000);

            ClavePresupuestal cp111 = new ClavePresupuestal(CP111);
            Console.WriteLine($"UA 1.1.1\ttotal:\t\t ${cp111.ObtenerTotales().ToString("0.00")}");
            ClavePresupuestal cp112 = new ClavePresupuestal(CP112);
            Console.WriteLine($"UA 1.1.2\ttotal:\t\t ${cp112.ObtenerTotales().ToString("0.00")}");

            UA ua11 = new UA();
            ua11.AgregarUAHija(cp111);
            ua11.AgregarUAHija(cp112);
            Console.WriteLine($"UA 1.1\t\ttotal:\t\t ${ua11.ObtenerTotales().ToString("0.00")}");

            UA ua1 = new UA();
            ua1.AgregarUAHija(ua11);
            Console.WriteLine($"UA 1\t\ttotal:\t\t ${ua1.ObtenerTotales().ToString("0.00")}\n");

            ClavePresupuestal cp211 = new ClavePresupuestal(CP211);
            Console.WriteLine($"UA 2.1.1\ttotal:\t\t ${cp211.ObtenerTotales().ToString("0.00")}");

            UA ua21 = new UA();
            ua21.AgregarUAHija(cp211);
            Console.WriteLine($"UA 2.1\t\ttotal:\t\t ${ua21.ObtenerTotales().ToString("0.00")}");

            UA ua2 = new UA();
            ua2.AgregarUAHija(ua21);
            Console.WriteLine($"UA 2\t\ttotal:\t\t ${ua2.ObtenerTotales().ToString("0.00")}\n");

            ClavePresupuestal cp31 = new ClavePresupuestal(CP31);
            Console.WriteLine($"UA 3.1\t\ttotal:\t\t ${cp31.ObtenerTotales().ToString("0.00")}");

            UA ua3 = new UA();
            ua3.AgregarUAHija(cp31);
            Console.WriteLine($"UA 3\t\ttotal:\t\t ${ua3.ObtenerTotales().ToString("0.00")}\n");

            ClavePresupuestal cp4 = new ClavePresupuestal(CP4);
            Console.WriteLine($"UA 4\t\ttotal:\t\t ${cp4.ObtenerTotales().ToString("0.00")}");

            Console.ReadKey();
        }
    }
}
