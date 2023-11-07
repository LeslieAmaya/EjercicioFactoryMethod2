using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod2
{
    public class Creador
    {
        public const int GATORADE = 1;
        public const int MONSTER = 2;

        public static BebidaEnergizante? CreadorBebida(int Tipo)
        {
            switch (Tipo)
            {
                case GATORADE:
                    return new Gatorade();
                case MONSTER:
                    return new Monster();
                default:
                    return null;
            }
        }
    }
}
