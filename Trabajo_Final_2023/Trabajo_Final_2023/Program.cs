/*
 * Created by SharpDevelop.
 * User: Den
 * Date: 27/11/2023
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
	class Program
	{
		public static void Main(string[] args)
		{
			Club nuevoClub=new Club("Boca Juniors");
			menu();
			int opc=int.Parse(Console.ReadLine());
			Console.Clear();
			do{
				switch(opc){
					case 1:
						darDeAlta_Entrenador(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 2:
						darDeBaja_Entrenador(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 3:
						darDeAlta_Niño(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 4:
						darDeBaja_Niño(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 5:
						pagarCuota(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 6:
						subMenu();
						int resp=int.Parse(Console.ReadLine());
						switch(resp){
								case 1: ListadoPorDeporte(nuevoClub);
								Console.Write("Press any key to continue . . . ");
								Console.ReadKey(true);
								Console.Clear();
								break;
								case 2: ListadoPorDeporteYcat(nuevoClub);
								Console.Write("Press any key to continue . . . ");
								Console.ReadKey(true);
								Console.Clear();
								break;
								case 3: ListadoTotal(nuevoClub);
								Console.Write("Press any key to continue . . . ");
								Console.ReadKey(true);
								Console.Clear();
								break;
						}
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 7:
						agregarDeporte(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
					case 8:
						borrarDeporte(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
						
					case 9:
						imprimirDeudores(nuevoClub);
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						Console.Clear();
						break;
						
				
						
				}
				menu();
				opc=int.Parse(Console.ReadLine());
				Console.Clear();
			}while(opc!=0);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void menu()
		{
			Console.WriteLine("                         -Bienvenidos al Club Atletico Boca Juniors-                  ");
			Console.WriteLine("______________________________________________________________________________" +
			                  "");
			Console.WriteLine("Seleccione una opcion para comenzar:\n" +
			                  "1-Dar de alta a un entrenador:\n" +
			                  "2-Dar de baja a un entrenador:\n" +
			                  "3-Dar de alta a un niño en un deporte:\n" +
			                  "4-Dar de baja a un niño en un deporte:\n" +
			                  "5-Realizar el pago de la cuota de un deporte:\n" +
			                  "6-Listado de inscriptos:\n" +
			                  "7-Agregar un deporte:\n" +
			                  "8-Eliminar un deporte:\n"+
			                  "9-Mostrar deudores: \n"+
			                  "0-Salir del sistema: ");
			
		}
		public static void subMenu()
		{
			Console.WriteLine("Elija por el tipo:\n" +
			                  "1-Listado por deporte:\n" +
			                  "2-Listado por deporte y categoria:\n" +
			                  "3-Listado total");
		}
		
		//funcion para dar alta entrenador
		public static void darDeAlta_Entrenador(Club boca)
		{
			Console.WriteLine("Ingrese su nombre y apellido: ");
				string nombre=Console.ReadLine();
				Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
				int dni=int.Parse(Console.ReadLine());
			try{	bool existeEntrenador = boca.verificarEntrenador(nombre, dni);
				
					if (existeEntrenador == false){
						Console.WriteLine("Ingrese el deporte a dirigir: ");
						string deporteDirige=Console.ReadLine();
						Entrenador nuevoEntrenador = new Entrenador(nombre,dni);
						boca.alta_Entrenador(nuevoEntrenador);
						Console.WriteLine("alta entrenador exitosa");
					}
					
					
					else
						throw new ExisteEntrenadorException();
				
    			}catch(ExisteEntrenadorException){
				Console.WriteLine("El entrenador ya existe en el sistema");
				
				}
				
			
		}
			
		public static void darDeBaja_Entrenador(Club boca)
		{
			
			Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
			int dniEliminar=int.Parse(Console.ReadLine());
			foreach (Entrenador e in boca.retornaListaEntrenadores()) {
				if (e.Dni== dniEliminar)
					boca.baja_Entrenador(e);
			}
			
			
			
		}
		
		public static void darDeAlta_Niño(Club boca)
		{
			try{
				
				Console.WriteLine("Ingrese su nombre y apellido: ");
				string nombre=Console.ReadLine();
				Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
				int dni=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese su edad: ");
				int edad=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese codigo numerico del deporte al que se quiere inscribir: ");
				int codDeporte=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el nombre del deporte: ");
				string depor=(Console.ReadLine());
				
				string cate=verCategoria(edad);
				Console.WriteLine("La categoria que le corresponde es: " + cate);
				Console.WriteLine("Ingrese su codigo de socio, o 0 si no lo es: ");
				int codigoS=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el mes actual si fue pagado, o 0 en caso de no registrar pago: ");
				int mespago=int.Parse(Console.ReadLine());
				if(codigoS!=0){ Socio Nuevosocio=new Socio(dni,codigoS);}
				Niño nuevo=new Niño(nombre,dni,edad,depor,cate, codigoS, mespago);
				
				try { if (boca.buscarDeporte(codDeporte)== null)
						throw new elDeporteNoExisteException();
					else{
						//uso funcion que devuelve el deporte x categoria al que voy a agregar
						boca.buscarDeporte(codDeporte).alta_Niño(nuevo);
						Console.WriteLine("Alta exitosa");				
					}
					}catch(elDeporteNoExisteException){
				Console.WriteLine("el deporte al que desea inscribir no existe, intente añadir primero un deporte");
			
			}
									
			}catch(Validar_CupoExeption){
				Console.WriteLine("Ya no queda cupo Disponible");
				
			}
			
		}
		
		public static void darDeBaja_Niño(Club boca)
		{
			Console.WriteLine("Ingrese el codigo del deporte: ");
			int cod_Depo=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
			int dni=int.Parse(Console.ReadLine());
			//falta tener al niño
			Niño auxiliar = new Niño ();
			auxiliar = boca.buscarDeporte(cod_Depo).buscarNiño(dni);
			boca.buscarDeporte(cod_Depo).baja_Niño( auxiliar );
			
		}
		
		
		public static void pagarCuota(Club boca)
		{
			Console.WriteLine("Ingrese codigo del deporte a pagar: ");
			int codDeportePago=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
			int dniPaga=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el mes que paga en numeros de 1-12: ");
			int mesPaga=int.Parse(Console.ReadLine());
			//funcion que pague;
			boca.buscarDeporte(codDeportePago).pagarCuota(dniPaga, mesPaga);
			
			
		}
		
		
		public static void ListadoPorDeporte(Club boca)
		{
			Console.WriteLine("ingrese el deporte que quiera ver");
			string verDep = Console.ReadLine();
			boca.mostrarInscriptosxDeporte(verDep);
		}
		
		
		public static void ListadoPorDeporteYcat(Club boca)
		{
			Console.WriteLine("ingrese el deporte que quiera ver");
			string verDep = Console.ReadLine();
			Console.WriteLine("ingrese la categoria que quiera ver");
			string verCat = Console.ReadLine();
			boca.mostrarInscriptosxDeporteyCat(verDep, verCat);
		}
		public static void ListadoTotal(Club boca){
			foreach (Cat_y_Depo deporte in boca.retornaListaCat_yDep()) {
				deporte.imprimirListaNiños();
			}
		}
		
		public static void agregarDeporte(Club boca)
		{
			Console.WriteLine("Ingrese el codigo numerico del nuevo deporte ");
			int cod=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre del deporte:");
			string nom_deporte=Console.ReadLine();
			Console.WriteLine("Ingrese la categoria (benjamin, alevin, cadete o juvenil) : ");
			string nom_cat=Console.ReadLine();
			Console.WriteLine("ingrese el costo que tendra : ");
			double costo=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese dia y horario de entrenamiento: ");
			string dia=Console.ReadLine();
			Cat_y_Depo nuevoDep = new Cat_y_Depo(cod, nom_deporte, nom_cat, costo, dia );
			boca.agregarDeportexCat(nuevoDep);
			Console.WriteLine("alta exitosa ");
		}
		
		public static void borrarDeporte(Club boca)
		{
			Console.WriteLine("Ingrese el codigo numerico del deporte que desea eliminar: ");
			int bajaCod=int.Parse(Console.ReadLine());
			
			
			//funcion que me devuelva el objeto
			
			boca.eliminar_Deporte(boca.buscarDeporte( bajaCod ));
			
			
		}
		//funcion que evalua la edad y devuelve que categoria corresponde
		public static string verCategoria(int edadEvaluar){
		       
			if (edadEvaluar< 10 )
				return "benjamin";
			if ((edadEvaluar>= 10) && (edadEvaluar<=12))
				return "alevin";
			if ((edadEvaluar>=13)&&(edadEvaluar<16))
				return"cadete";
			else
				return"juvenil";
		}
		
		//funcion que muestra los deudores mostrarDeudores
		public static void imprimirDeudores(Club esteClub){
			Console.WriteLine("ingrese el mes actual en numero");
			int esteMes=int.Parse(Console.ReadLine());		
			foreach (Cat_y_Depo  dep in esteClub.retornaListaCat_yDep()) {
				dep.mostrarDeudores(esteMes);
					
				}
			
			
		}
	}
}

