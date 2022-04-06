namespace operador_implicito
{
    public class ClaseB
    {
               public string Nombre { get; set; }
               public static implicit operator ClaseB(ClaseA a)
               {
                   return new ClaseB() { Nombre = a.Nombre };
               }
    }
}