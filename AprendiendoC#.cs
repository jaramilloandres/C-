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

Condiciones: son utilizadas para declarar valores que deben cumplirse en la sentencia
	
		Tipos:	if: se utiliza en el bloque de un codigo para indicar si el resultado es verdadero
				if (condition)
				{
					//Ejecute el codigo cuando la condicion sea verdaderao
				
				}
				//la condicion puede devolver una expresion verdadera o falsa
				static void Main(string[] args)
				{
					int x = 8;
					int y = 3;
					
					if (x>y) 
					{
					Console.WriteLine("x es mayor que y");
					}
				}
			Relationals Operators: sirven para evaluar las condiciones
			
				>= Mayor o igual
				<= Menor o igual
				== Igual que
				!= No igual que
				
				if (z==x) 
				{
					Console.WriteLine("Igual");
				}
				// Podemos ver que el valor de z es igual al de x
			else: se utiliza en un bloque del condigo cuando queremos indicar un caso contrario
			
				int mark= 90;
				if (mark <50)
				{ 
					Console.WriteLine("fallaste");
				}
				else
				{ 
					Console.WriteLine("ganaste");
				}
			En C# tambien se pueden incluir la condicion if dentro de otro if, puedes incluir los if que desees
			
				int mark = 50;

				if (mark >=25)
				{ Console.WriteLine ("pasaste");
				 if (mark ==50)
				 {Console.WriteLine ("Perfecto");
				 }
				}
				else 
				{
					Console.WriteLine ("fallaste");						
				}
				
			if-else if : Es utilizado para decidir entre 3 o mas acciones
				int z = 66;

				if (z==7)
				{
					Console.WriteLine("El valor de z es 7");						
				}
				else if (z==36)
				{
					Console.WriteLine("El valor de z es 36");
				}
				else if (z==66)
				{
					Console.WriteLine("El valor de z es 66");
				}
				else
				{
					Console.WriteLine("No cumple");
				}
			switch : proporciona una forma más elegante de probar una variable para la igualdad contra una lista de valores
				
				int num = 4;

				switch(num) 
				{
					case 1: Console.WriteLine("one");
					break;
					case 2: Console.WriteLine("two");
					break;
					case 3: Console.WriteLine("three");
					break;
					case 4: Console.WriteLine("four");
					break;	
				}
				
			En la funcionalidad switch existe el caso predeterminado "opcional" se ejecuta cuando ninguno de los casos anteriores coincide
				
				int age = 90;

				switch (age)
				{
					case 15: Console.WriteLine("Muy joven");
					break;
					case 40: Console.WriteLine("Adulto");
					break;
					case 60: Console.WriteLine("Anciano");
					break;
					default: Console.WriteLine("Ninguno es");
					break;
				}
				
			la funcionalidad break es utilizado para dar un espacio entre las lineas del bloque
				
			while: un ciclo while se ejecuta repetidamente en el bloque de un codigo siempre que una condición dada sea verdadera	
				
				int num = 10;

				while(num<20)
				{
					Console.WriteLine(num);
					num++;
				}
				
				/*output
				10
				11
				12
				13
				14
				15
				16
				17
				18
				19
				*/
			Se puede utilizar while en operaciones aritmeticas compuestas para promover el control de timpos en un ciclo
				
				int num = 10;

				while(num<20)
				{
					Console.WriteLine(num);
					num+=4;
				}
				
				/*
				10
				14
				18
				*/
			Dependiendo de donde se ubique el simbolo + podemos mostrar los numeros que hay entre el rango 10-20 o desde el 10 hasta el 20 	
				
				int num = 10;

				while(++num<15)
				{
					Console.WriteLine(num);
				}

				/* Output
				11
				12
				13
				14
				*/
				int num = 10;

				while(num++<15)
				{
					Console.WriteLine(num);
				}
				/*Output
				11
				12
				13
				14
				15
				*/
			foor: un bucle for ejecuta un conjunto de instrucciones un número específico de veces
				
				for ( int;condicion;incremental)
				{
					declaracione(s);
				}
				
				for ( int x = 12; x < 16; x++)
				{
					Console.WriteLine("El valor de x es :{0}", x);
				}

				/*Output
				El valor de x es :12
				El valor de x es :13
				El valor de x es :14
				El valor de x es :15
				*/

				las instrucciones init e increment pueden omitirse, si no es necesario, pero recuerden que los puntos y comas son obligatorios
				
			do-while: el bucle do-while se garantiza que se ejecutará al menos una vez
				
				int a = 0;
				do
				{
					Console.WriteLine(a);
					a++;
				}
				while(a<3);
				/*
				0
				1
				3
				*/
			
