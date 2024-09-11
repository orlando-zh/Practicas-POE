using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Polimorfirmos.Modelo
{
    public class Computadora
    {
        public virtual void Encender()
        { 
            MessageBox.Show("Encendiendo computadora.");
        }
    }


    public class ComputadoraPortatil : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora portatil.");
        }
    }

    public class 
}
