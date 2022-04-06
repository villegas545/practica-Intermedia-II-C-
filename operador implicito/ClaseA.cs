namespace operador_implicito
{
    public class ClaseA
    {
        public string Nombre { get; set; }

        public static implicit operator ClaseA(ClaseB b)
        {
            return new ClaseA() { Nombre = b.Nombre };
        }
    }
}