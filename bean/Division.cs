using System;


namespace Proyecto.bean
{
    public class Division
    {
        double numeroUno;
        double numeroDos;

        public Division() 
        {

        }

        public Division(double numeroUno, double numeroDos)
        {
            this.numeroUno = numeroUno;
            this.numeroDos = numeroDos;
        }

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

        public double metodoDividir(double numeroUno, double numeroDos) 
        {
            double division = numeroUno / numeroDos;
            return division;
        }

    }
}
