/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 28/11/2023
 * Time: 22:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
    public class Niño:Persona
    {
        //variables
        private int edad;
        private string deporte;
        private string categoria;
        private int cod_soc;
        private int ultimoMesPago;
        
        //constructores
        public Niño(){}
        
        public Niño(string nombre,int dni):base (nombre,dni) {}
        
        public Niño(string nombre,int dni,int ed,int mespago):base(nombre,dni)
        {
            edad=ed;
            ultimoMesPago = mespago;
        }
        public Niño(int soc,int dni,string nombre):base(nombre,dni)
        {
            cod_soc=soc;
        }
        
        public Niño(string nombre,int dni,int edad,string dep, string cat, int soc, int mes):base (nombre,dni)
        {
            this.edad=edad;
            deporte= dep;
            categoria = cat;
            cod_soc=soc;
            ultimoMesPago = mes;
        }
        
        //propiedades
        public int Edad{
            set{
                if(edad<0)
                    Console.WriteLine("edad erronea");
                else
                    edad=value;
            }
            get{return edad;}
        }
        public int Cod_socio{
            set{cod_soc=value;}
            get{return cod_soc;}
        }
        
        public string Categoria{
            set{categoria=value;}
            get{return categoria;}
        }
        
        public string Deporte{
            set{deporte=value;}
            get{return deporte;}
        }
        public int UltimoMesPago{
            set{ultimoMesPago=value;}
            get{return ultimoMesPago;}
        }
        
       
    }
}

