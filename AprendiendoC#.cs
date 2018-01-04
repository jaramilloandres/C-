------------------------------
-  // APRENDIENDO C# \\	     -
-    Andres Jaramillo	     -
-    Estudiante Ingeneria    -
-	03/01/2018  	     -
------------------------------

Variables:	Es informacion que el programa puede leer mientras se esta ejecutando, sus nombres empiezan por letras y pueden contener _ y estos deben de ser descriptivos
			FirsName, LastName //no se deben de poner nombres como: abc o xyz, estas variables se deben de definir al inicio del codigo para que este sea mas organizado.

		Tipos: 	int /*(integer/numero entero)*/
				int myAge =18;
				ó
				int myAge;
				myAge =18;

				float /*(numero con , )*/

				double /*(numero con , con doble precision)*/
				double pi = 3,14;

				char /*(un solo caracter/letra)*/
				y='Z';

				bool /*(Solo muestra dos valores true or false/falso o verdadero)*/
				isOnline = true;

				string /*(secuencia de caracteres/letras)*/
				string firstName = "Andres";

		//NOTA: Los valores asignados en char utilizan comillas simples ' ' / los valores asignados en string utilizan comillas dobles " ".

Funciones:

		Tipos: Salida de Texto:Con la siguiente funcion podemos mostrar texto, resultados de operaciones, numeros. Se debe de tener en cuenta el formato como se debe de escribir los argumentos dentro de la funcion, para el ejemplo se puede ver que "Hola Mundo!" es una string.

				Console.WriteLine("Hola Mundo!");

				//Tambien se puede observar los valores de las variables declaradas al inicio del codigo
				int x=14;
				Console.WriteLine(x);

				//Si queremos mostrar una variable string formateada se utiliza
				
				int x=14;
				double y=20;
				Console.WriteLine("x={0}; y={1}",x,y);

		//NOTA: Basicamente lo que se realizó fue traer el resultado de las variables, se debe de tener en cuenta que para mostrar varias variables se inicia con {0}, {1},....

				Ingreso de Texto: Con esta funcion se permite interactuar con el usuario, este debe de ingresar una cadena texto para luego obtener el resultado.

				string yourName;
				Console.WriteLine("Hola como te llamas?");

				yourName = Console.ReadLine();

				Console.WriteLine("Tu nombre es {0}", yourName);
				Console.WriteLine(string.Format("Tu nombre es {0}", yourName));

				//La función Console.ReadLine() devuelve un valor string, si se desea un valor int o double, a esta se le debe de adicionar la funcion Convert.toXXX, la cual me sirve para convertir el tipo de valor en una cadena texto string.

				int edad=
				Convert.toInt32(Console.ReadLine());
				Console.WriteLine("tu tienes {0} años", edad);

		//NOTA: Para la conversion a entero se utilizan las alternativas disponibles basadas en 16, 32, 64 bits, la arquitectura por defecto de C# es 32bits.

Constantes:	Contienen valores que no pueden ser cambiones despues de la declaracion inicial ni durante la ejecucion del programa.

				const double PI = 3.14

Operaciones Aritmeticas: Son las operaciones matematicas basicas como suma, resta, multiplicación y división

		Tipos: 	Addition +

				Substration -

				Multiplication *

				Division /  //Se debe de ingresar los numeros enteros, siendo el numero del lado derecho el divisor.

				int x = 10/2;
				Console.WriteLine(x);

				Modulus %

				Operator Proccedence: //se encarga de realizar varias operaciones matematicas al mismo tiemp
				init x = 4+3*2;
				Console.WriteLine(x);

				init x = (5+2)*2;
				Console.WriteLine(x);
				
				Assignment Operator: // se utilizan para incrementar valores en una operacion
				++x; //prefix, siempre realiza el aumento
				int x = 3;
				int y = ++x;
				// x es 4, y es 4
				
				x++; //postfix, primero aumenta y luego deja el valor original
				int x = 3;
				int y = x++;
				// x es 4, y es 3
				
				
				
