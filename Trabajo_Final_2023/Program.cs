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
			Entrenador e1=new Entrenador("armando",94830218,"tenis");
			Entrenador e2=new Entrenador("agustin",45680978,"futbol");
			Entrenador e3=new Entrenador("denise",42458730,"voley");
			nuevoClub.alta_Entrenador(e1);
			nuevoClub.alta_Entrenador(e2);
			nuevoClub.alta_Entrenador(e3);
			Cat_y_Depo c1=new Cat_y_Depo(1,"tenis","benjamin",200,"lunes 08",e1);
			Cat_y_Depo c2=new Cat_y_Depo(2,"voley","benjamin",200,"martes 08",e3);
			Cat_y_Depo c3=new Cat_y_Depo(3,"futbol","benjamin",200,"miercoles 08",e2);
			nuevoClub.agregarDeportexCat(c1);
			nuevoClub.agregarDeportexCat(c2);
			nuevoClub.agregarDeportexCat(c3);
			Niño n1=new Niño("helena",55255255,8,"voley","benjamin",0,0);
			Niño n2=new Niño("emanuel",50255255,9,"futbol","benjamin",1,5);
			c1.alta_Niño(n1);
			c3.alta_Niño(n2);
			
			menu();
			try{
				int opc=int.Parse(Console.ReadLine());
				Console.Clear();
				do{
					switch(opc){
						case 1:
							darDeAlta_Entrenador(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 2:
							darDeBaja_Entrenador(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 3:
							darDeAlta_Niño(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 4:
							darDeBaja_Niño(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar!");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 5:
							pagarCuota(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 6:
							subMenu();
							int resp=int.Parse(Console.ReadLine());
							switch(resp){
									case 1: ListadoPorDeporte(nuevoClub);
									Console.Write("¡Toque cualquier tecla para continuar! ");
									Console.ReadKey(true);
									Console.Clear();
									break;
									case 2: ListadoPorDeporteYcat(nuevoClub);
									Console.Write("¡Toque cualquier tecla para continuar! ");
									Console.ReadKey(true);
									Console.Clear();
									break;
									case 3: ListadoTotal(nuevoClub);
									Console.Write("¡Toque cualquier tecla para continuar! ");
									Console.ReadKey(true);
									Console.Clear();
									break;
							}
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 7:
							agregarDeporte(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 8:
							borrarDeporte(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
							
						case 9:
							imprimirDeudores(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
						case 10:
							imprimirTodosEntrenadores(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
							
						case 11:
							imprimirTodosEntrenadores(nuevoClub);
							cambiarEntrenador(nuevoClub);
							Console.Write("¡Toque cualquier tecla para continuar! ");
							Console.ReadKey(true);
							Console.Clear();
							break;
							
							
							
					}
					menu();
					opc=int.Parse(Console.ReadLine());
					Console.Clear();
				}while(opc!=0);
			}catch(FormatException){
				Console.Write("¿Reintente?¡Toque cualquier tecla para continuar! ");
				Console.ReadKey(true);
			}}
		
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
			                  "10-Mostrar todos los entrenadores: \n"+
			                  "11-cambiar entrenadores: \n"+
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
					Console.WriteLine("El entrenador {0} se agrego exitosamente", nombre);
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
			
			foreach (Cat_y_Depo dep in boca.retornaListaCat_yDep()) {
				
				
				if( dep.EntrenadorAsignado.Dni == dniEliminar  ){
					Console.WriteLine("El entrenador dirige actualmente {0}  {1}, primero debe eliminar el deporte", dep.NombreDep, dep.Categoria);
					return;}
				else{
					
					
					Entrenador auxiliar = new Entrenador ();
					auxiliar = boca.buscarEntrenador(dniEliminar);
					boca.baja_Entrenador( auxiliar );
					Console.WriteLine("Se ha dado de baja al entrenador " + auxiliar.Nombre);
					return;

					
				}
				
			}
			
			
			foreach (Entrenador e in boca.retornaListaEntrenadores()) {
				if (e.Dni== dniEliminar){
					boca.baja_Entrenador(e);
				}
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
				if(codigoS!=0){ Socio Nuevosocio=new Socio(nombre,dni,codigoS,mespago);
					boca.retornaListaSocio().Add(Nuevosocio);}
				Niño nuevo=new Niño(nombre,dni,edad,depor,cate, codigoS, mespago);
				
				try { if (boca.buscarDeporte(codDeporte)== null)
						throw new elDeporteNoExisteException();
					else{
						//uso funcion que devuelve el deporte x categoria al que voy a agregar
						boca.buscarDeporte(codDeporte).alta_Niño(nuevo);
						Console.WriteLine( nuevo.Nombre + " ha sido agegado exitosamente a  " + boca.buscarDeporte(codDeporte).NombreDep +"  caegoria: " + cate );
					}
				}catch(elDeporteNoExisteException){
					Console.WriteLine("el deporte al que se desea inscribir no existe, intente añadir primero un deporte");
					
				}
				
			}catch(Validar_CupoExeption){
				Console.WriteLine("Lo sentimos, ya no queda cupo Disponible");
				
			}
			
		}

		public static void darDeBaja_Niño(Club boca)
		{
			try{	Console.WriteLine("Ingrese el codigo del deporte: ");
				int cod_Depo=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese su numero de DNI sin espacios ni puntos: ");
				int dni=int.Parse(Console.ReadLine());
				//falta tener al niño
				
				
				Niño auxiliar = new Niño ();
				auxiliar = boca.buscarDeporte(cod_Depo).buscarNiño(dni);
				boca.buscarDeporte(cod_Depo).baja_Niño( auxiliar );
			}catch(Exception){
				Console.WriteLine("El niño no esta cargado al sistema");
			}
			
		}


		public static void pagarCuota(Club boca)
		{
			try{ Console.WriteLine("Ingrese codigo del deporte a pagar:  ");
				foreach (Cat_y_Depo dep in boca.retornaListaCat_yDep()) {
					Console.WriteLine(dep.NombreDep + " codigo: " + dep.Codigo);
				}
				
				int codDeportePago=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese su numero de DNI del niño sin espacios ni puntos: ");
				int dniPaga=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el mes que paga en numeros de 1-12: ");
				int mesPaga=int.Parse(Console.ReadLine());
				
				
				foreach (Socio s in boca.retornaListaSocio()) {
					if(s.Dni== dniPaga){
						
						Console.WriteLine("El niño es socio" );
						if (s.MesPago== mesPaga)
							Console.WriteLine("cuota de socio al dia");
						else
							Console.WriteLine("debe abonar cuota de socio: " + s.Cuota + " y " );
						
					}
				}
				
				
				//funcion que pague;
				boca.buscarDeporte(codDeportePago).pagarCuota(dniPaga, mesPaga);
			}catch(Exception){
				Console.WriteLine("El niño no esta cargado al sistema");
			}
		}






		public static void ListadoPorDeporte(Club boca)
		{
			Console.WriteLine("ingrese el deporte que quiera ver");
			string verDep = Console.ReadLine();
			//	foreach (Cat_y_Depo dep in boca.retornaListaCat_yDep) {
			//		if(verDep== dep.NombreDep)
			boca.mostrarInscriptosxDeporte(verDep);
			//}
			
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
			Console.WriteLine("Ingrese el codigo numerico que tendra el nuevo deporte ");
			int cod=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nombre del deporte:");
			string nom_deporte=Console.ReadLine();
			Console.WriteLine("Ingrese la categoria (benjamin, alevin, cadete o juvenil) : ");
			string nom_cat=Console.ReadLine();
			Console.WriteLine("ingrese el costo que tendra : ");
			double costo=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese dia y horario de entrenamiento: ");
			string dia=Console.ReadLine();
			boca.imprimirEntrenadores();
			Console.WriteLine("Ingrese el dni del entrenador a cargo");
			
			int dniEntrenador= int.Parse(Console.ReadLine());
			if (boca.buscarEntrenador(dniEntrenador)== null){
				Console.WriteLine("El entrenador no esta cargado a sistema, por favor intente añadirlo antes de añadir el deporte que dirigira");
				return;
				
			}
			else{
				
				Cat_y_Depo nuevoDep = new Cat_y_Depo(cod, nom_deporte, nom_cat, costo, dia, boca.buscarEntrenador(dniEntrenador) );
				boca.agregarDeportexCat(nuevoDep);
				Console.WriteLine("Ha añadido exitosamente: "+ nom_deporte + " categoria: "+ nom_cat );
			}
		}

		public static void borrarDeporte(Club boca)
		{
			try{Console.WriteLine("Ingrese el codigo numerico del deporte que desea eliminar: ");
				foreach (Cat_y_Depo dep in boca.retornaListaCat_yDep()) {
					Console.WriteLine(dep.NombreDep + " codigo: " + dep.Codigo);
				}
				int bajaCod=int.Parse(Console.ReadLine());
				
				
				//funcion que me devuelva el objeto
				
				boca.eliminar_Deporte(boca.buscarDeporte( bajaCod ));
			}catch(Exception){
				Console.WriteLine("El deporte no esta cargado al sistema");
			}
			
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
		public static void imprimirTodosEntrenadores(Club boca){
			boca.imprimirEntrenadores();}

		public static void cambiarEntrenador(Club boca){
			Console.WriteLine("ingrese codigo del deporte al que quiere modificar entrenador");
			int esteDep= int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese dni del entrenador a modificar");
			int viejoEntre= int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese dni del nuevo entrenador");
			int nuevoEntre= int.Parse(Console.ReadLine());
			Entrenador auxiliar = boca.buscarEntrenador(nuevoEntre);
			boca.buscarDeporte(esteDep).EntrenadorAsignado=auxiliar;
		}
	}

}


