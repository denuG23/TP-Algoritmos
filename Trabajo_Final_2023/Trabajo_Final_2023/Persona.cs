/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 28/11/2023
 * Time: 22:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
    abstract public class Persona
    {
        //variables
        protected string nombre;
        protected int dni;
        //constructor
        public Persona(){}
        public Persona(int dni)
        {
            this.dni=dni;
        }
        public Persona(string nom)
        {
            nombre=nom;
        }
        public Persona(string nom,int dni)
        {
            nombre=nom;
            this.dni=dni;
        }
        //propiedades
        public string Nombre{
            set{
                try{
                    if(nombre=="")
                        nombre=value;
                }catch(FormatException){
                    Console.WriteLine("Nombre incorrecto");
                }
            }
            get{return nombre;}
        }
        public int Dni{
            set{
                try{
                    if(dni>0)
                        dni=value;
                }catch(Exception){
                    Console.WriteLine("Vuelva a ingresar su numero de DNI");
                }
            }
            get{return dni;}
        }
        public void mostrar()
        {
            Console.WriteLine("Nombre: {0} - D.N.I Nº: {1}",nombre,dni);
        }
    }
}


