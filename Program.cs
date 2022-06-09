// See https://aka.ms/new-console-template for more information
// Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

//Se crean las variables a utilizar
float totalFacturado, comision, totalACobrar;

const float sueldoFijo= 15000;
const float comisionsobreFacturado=0.05F;


//Se solicita al empleado el total facturado.
Console.WriteLine("Ingrese su total facturado");
totalFacturado = float.Parse(Console.ReadLine());
comision = totalFacturado * comisionsobreFacturado;
totalACobrar = sueldoFijo + comision;

Console.WriteLine("el total a cobrar es " + totalACobrar);