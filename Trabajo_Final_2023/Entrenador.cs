/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 28/11/2023
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
    public class Entrenador:Persona
    {
        //variables
        private string deporteQueEnseña;
        
        //constructores
        public Entrenador(){}
        public Entrenador(string nombre,int dni):base(nombre,dni){}
        public Entrenador(string nombre,int dni,string depo):base(nombre,dni)
        {
            deporteQueEnseña=depo;
        }
       
        
        //propiedades
       
        public string DeporteQueEnseña {
            set{deporteQueEnseña=value;}
            get{return deporteQueEnseña;}
        }
   
    }
}

