using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2.clases
{
     public class Nota

     {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set {
                if (value.Split(' ').Length < 3)
                {
                    throw new Exception("Nombre incompletos  ");
                }
                nombre = value; }
        }

        private float actividad1p;

        public float Actividad1p
        {
            get { return actividad1p; }
            set {
                if (value <0 && value >10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                actividad1p = value; }

        }
        private float practica1p;

        public float Practica1p
        {
            get { return practica1p; }
            set {
                if (value < 0 && value >10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                practica1p = value; }
        }

        private float tarea1p;

        public float Tarea1p
        {
            get { return tarea1p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                tarea1p = value; }
        }
        private float evaluacionfinal1p;

        public float EvaluacionFinald1p
        {
            get { return evaluacionfinal1p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                evaluacionfinal1p = value; }
        }
        

        public float PrimerParcial
        {
            get { return Actividad1p*0.25f +Practica1p*0.25f+Tarea1p*0.20f+evaluacionfinal1p*0.30f; }
            
        }
        private float actividad2p;

        public float Actividad2p
        {
            get { return actividad2p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                actividad2p = value; }

        }
        private float practica2p;

        public float Practica2p
        {
            get { return practica2p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                practica2p = value; }
        }

        private float tarea2p;

        public float Tarea2p
        {
            get { return tarea2p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                tarea2p = value; }
        }
        private float evaluacionfinal2p;

        public float EvaluacionFinald2p
        {
            get { return evaluacionfinal2p; }
            set {
                if (value < 0 && value > 10)
                {
                    throw new Exception("Ingrese un numero mayor o igual 1 o menor e igual 10  ");
                }
                evaluacionfinal2p = value; }
        }

        public float SegundoParcial
        {
            get { return Actividad2p*0.25f +Practica2p*0.25f+Tarea2p*0.20f+EvaluacionFinald2p*0.30f; }
            
        }
        public float Suma
        {
            get { return PrimerParcial+SegundoParcial; }
            
        }
        private float recuperacion;

        public float Recuperacion
        {
            get { return recuperacion; }
            set { recuperacion = value; }
        }
        public float Suma2
        {
            get { return Recuperacion+Suma; } 
        }


        public float Final
        {
            get { return Suma2/2; }
            
        }
      

        public String Estado
        {
            
            get
            {
                if (Suma >= 14 || Suma2 >= 14)
                {
                    return " Aprobado ";
                }
                else
                {
                    if (Suma < 14)
                    {
                        return " Recuperacion ";
                    }
                    else
                    {
                        return "Aprobado";
                    }
                }


               

                    

             

                
            }
        }









    }
}
