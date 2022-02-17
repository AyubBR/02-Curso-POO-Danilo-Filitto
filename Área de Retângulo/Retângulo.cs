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
            float Baseretangulo = 0;
            float Alturaretangulo = 0;
        }

        public Retangulo(float baseretangulo, float alturaretangulo)
        {
            float Baseretangulo = baseretangulo;
            float Alturaretangulo = alturaretangulo;
        }

        //Propriedades
        private float baseretangulo;

        public float Baseretangulo
        {
            get { return baseretangulo; }
            set { baseretangulo = value; }
        }

        private float alturaretangulo;

        public float Alturaretangulo
        {
            get { return alturaretangulo; }
            set { alturaretangulo = value; }
        }

        private float area;

        public float Area
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
