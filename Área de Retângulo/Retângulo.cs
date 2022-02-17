using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
        //Contrutores
        public Retangulo()
        {
            double Baseretangulo = 0;
            double Alturaretangulo = 0;
        }

        public Retangulo(double baseretangulo, double alturaretangulo)
        {
            double Baseretangulo = baseretangulo;
            double Alturaretangulo = alturaretangulo;
        }

        //Propriedades
        private double baseretangulo;

        public double Baseretangulo
        {
            get { return baseretangulo; }
            set { baseretangulo = value; }
        }

        private double alturaretangulo;

        public double Alturaretangulo
        {
            get { return alturaretangulo; }
            set { alturaretangulo = value; }
        }

        private double area;

        public double Area
        {
            get { return Baseretangulo*Alturaretangulo; }
            set { area = value; }
        }


        //Métodos
        public void ExibirDados ()
        {
            Console.WriteLine("Base: " + Baseretangulo);
            Console.WriteLine("Altura: " + Alturaretangulo);
            Console.WriteLine("Area: " + Area);
        }

    }
}
