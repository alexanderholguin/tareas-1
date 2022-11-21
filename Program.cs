
class Program
{
    public static void Main(string[] args)
    {
        Empleados empleados = new Empleados("Bar de comida", 2022, "jonathan", "holguin", 1, "Soltero");
        empleados.imprimir();
        Estudiantes estudiante = new Estudiantes("A340", "sebastian", "Gonzales", 2, "Soltero");
        estudiante.imprimir();
        Personal personal = new Personal("Secretaria", "Diana", "Tigua", 4, "Casada");
        personal.imprimir();
        Profesores profesores = new Profesores("ingeniero", "Joaquin", "baque ", 5, "viudo");
        profesores.imprimir();
    }
}
