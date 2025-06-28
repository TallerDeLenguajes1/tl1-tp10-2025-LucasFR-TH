namespace EspacioTarea;

// Defina una clase en C# llamada Tarea que represente la estructura de los objetos
// devueltos por la API.

public class Tarea { // IMPLICITAMENTE HAY UN COSNTRUTOR VACIO
    public int userId { get; set;} // asi ta bien
    public int id { get; set; }
    public string title { get; set;}
    public bool completed { get; set; }
}

