/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 28/11/2023
 * Time: 22:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
    public class Socio:Persona
    {
        private int codigo;
        private double cuota=2000;
       // private int mesPago;
        
        //constructores
        public Socio(string nombre,int dni):base(nombre,dni){}
        
        public Socio(string nombre,int dni,int sn):base(nombre,dni)
        {
            codigo=sn;
        }
        public Socio(string nombre,int dni,int sn,double cuota):base(nombre,dni)
        {
            codigo=sn;
            this.cuota=cuota;
        }    
        public Socio(int sn,double cuota)
        {
            codigo=sn;
            this.cuota=cuota;
        }        
        //propiedades
        public int Codigo{
            set{
                if(codigo>0){
                    codigo=value;
                }
                else
                    Console.WriteLine("Error: Reingresar codigo ");
            }
            get{return codigo;}
        }
        public double CostoCuota{
            set{
                if(cuota>0){
                    cuota=value;
                }
                else
                    Console.WriteLine("Monto erroneo");
            }
            get{return cuota;}
        }
       
    }
}

