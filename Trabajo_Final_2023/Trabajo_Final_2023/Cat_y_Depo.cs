/*
 * Created by SharpDevelop.
 * User: den
 * Date: 27/11/2023
 * Time: 22:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Trabajo_Final_2023
{
    public class Cat_y_Depo
    {
        //variables
        private int codigo;
        private string  nombreDep;
        private string  categoria;
        private double  costo;
        private string diasYHs;
        private int cupo;
        private Entrenador entrenadorAsignado;
        private ArrayList listaNiños;
        
        
        
        
        //constructores
       
        
        public Cat_y_Depo(int cod, string nom, string cat, double  cos , string dyh)
        {
            codigo= cod;
            nombreDep = nom;
            categoria= cat;
            costo = cos;
            diasYHs = dyh;
            cupo= 15;
            listaNiños= new ArrayList();
            
        }
        
        public Cat_y_Depo(int cod, string nom, string cat, double  cos , string dyh,  Entrenador e)
        {
            codigo = cod;
            nombreDep = nom;
            categoria= cat;
            costo = cos;
            diasYHs = dyh;
            cupo= 15;
            entrenadorAsignado =e;
            listaNiños= new ArrayList();
            
        } 
        
        //propiedades
        
        public int Codigo{
            set {codigo=value;}
            get {return codigo;}
        }
        
        public string NombreDep{
            set {nombreDep=value;}
            get {return nombreDep;}
        }
        public string Categoria{
            set {categoria=value;}
            get {return categoria;}
        }
        public double Costo{
            set {costo=value;}
            get {return costo;}
        }
        
        public string DiasyHs{
            set {diasYHs=value;}
            get {return diasYHs;}
        }
        
        
        public int Cupo{
            set {cupo=value;}
            get {return cupo;}
        }
        
        
        
        
        //metodo para mostrar deudores
        
        public void mostrarDeudores(int mesActual){
            foreach (Niño n in listaNiños) {
                if (n.UltimoMesPago  < mesActual)
                {Console.WriteLine("nombre: " + n.Nombre + " dni: " + n.Dni);}
            }
        }
        //metodos dar alta y baja a niño
        public void alta_Niño(Niño Nuevon){
            if (Cupo > 0){
                listaNiños.Add(Nuevon);
                    Cupo= Cupo-1;}
        
            else
                throw new Validar_CupoExeption();            
            }
            
        
        
        public void baja_Niño(Niño n){            
            listaNiños.Remove(n);
            Console.WriteLine("Baja exitosa");
        }
        
        public Niño buscarNiño(int d){
            foreach (Niño n in listaNiños) {
                if (n.Dni == d)
                    return n;        }
            return null;
        }
        
        //metodo para imprimir listado de niños de la categoria
        public void imprimirListaNiños(){
            foreach (Niño n in listaNiños)
            	Console.WriteLine("nombre : {0} dni: {1}" ,   n.Nombre, n.Dni);
            
        }
        
        //metodo para pagar
        public void pagarCuota(int dniP, int mesP){
            foreach (Niño n in listaNiños){
                if (n.Dni == dniP){
                    if (n.Cod_socio>0){
                        double auxiliar = Costo - Costo* 0.30;
                        Console.WriteLine("se aplica descuento de socio, total :" + auxiliar);
                        n.UltimoMesPago = mesP;
                    }
                    else
                    {
                        Console.WriteLine("El saldo a pagar es de " + Costo);
                        n.UltimoMesPago = mesP;
                    }
                }    
            }        
        }
    
        
    
        
    }    
}

