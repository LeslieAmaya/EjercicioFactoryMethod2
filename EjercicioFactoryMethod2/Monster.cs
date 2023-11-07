using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod2
{
    public class Monster : BebidaEnergizante
    {
        public override int Energia()
        {
            return 16;
        }
    }
}
