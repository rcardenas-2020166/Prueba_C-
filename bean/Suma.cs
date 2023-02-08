using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.bean
{
    public class Suma
    {
        public double numeroUno;
        public double numeroDos;
        public Suma() 
        {
            
        }

        public Suma(double numeroUno, double numeroDos) 
        {
            this.numeroUno = numeroUno;
            this.numeroDos = numeroDos;
        }

        //GETTERS AND SETTERS//

        public double getNumeroUno() 
        {
            return numeroUno;
        }

        public void setNumeroUno(double numeroUno) 
        {
            this.numeroUno = numeroUno;
        }

        public double getNumeroDos() 
        {
            return numeroDos;
        }

        public void setNumeroDos(double numeroDos)
        {
            this.numeroDos = numeroDos;
        }

        public double metodoSumar(double numeroUno, double numeroDos) 
        {
            double multiplicar = numeroUno + numeroDos;
            return multiplicar;
        }
    }
}
