# ¿String es una tipo por valor o un tipo por referencia
En C#, String es un tipo por referencia. Esto significa que una variable de tipo String contiene una referencia a una instancia de la cadena en el heap, en lugar de contener directamente los datos de la cadena.
# ¿Qué secuencias de escape tiene el tipo string?
\'	Comilla simple	0x0027
\"	Comilla doble	0x0022
\	Barra diagonal inversa	0x005C
\0	Null	0x0000
\a	Alerta	0x0007
\b	Retroceso	0x0008
\f	Avance de página	0x000C
\n	Nueva línea	0x000A
\r	Retorno de carro	0x000D
\t	Tabulación horizontal	0x0009
\v	Tabulación vertical	0x000B

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter @ se usa para definir cadenas literales verbatim. En las cadenas verbatim, las secuencias de escape no son procesadas (excepto para las comillas dobles que se representan como ""). Esto es útil para rutas de archivos o cadenas que contienen muchas barras invertidas y saltos de línea.

string ruta = @"C:\Program Files\MiAplicacion\archivo.txt";
string multilinea = @"Esta es una cadena de texto
que abarca varias líneas
sin necesidad de usar \n";

El carácter $ se usa para definir cadenas interpoladas. En las cadenas interpoladas, las expresiones de C# pueden ser insertadas directamente dentro de la cadena usando llaves {}. Esto permite la construcción de cadenas dinámicas de manera más legible y concisa.

int edad = 30;
string nombre = "Juan";
string saludo = $"Hola, mi nombre es {nombre} y tengo {edad} años.";
// Salida: "Hola, mi nombre es Juan y tengo 30 años."

Cuando se usan juntos @$ o $@, se obtiene una cadena que es tanto verbatim como interpolada. Esto permite combinar las ventajas de ambas características: evitar la necesidad de secuencias de escape y permitir la interpolación de variables y expresiones.

string nombreArchivo = "archivo.txt";
string ruta = @$"C:\Users\{Environment.UserName}\Documents\{nombreArchivo}";
string multilineaInterpolada = @$"Hola, {nombre}.
//Este es un mensaje en múltiples líneas y la ruta del archivo es {ruta}.";