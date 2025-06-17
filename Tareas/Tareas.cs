using System;
using System.Text.Json;

// Defina una clase en C# llamada Tarea que represente la estructura de los objetos
// devueltos por la API.

public class Tarea { // IMPLICITAMENTE HAY UN COSNTRUTOR VACIO
    public int userId { get; set;} // asi ta bien
    public int id { get; set; }
    public string title { get; set;} // 1 cokmpletada y 0 no
    public bool completed { get; set; }
}

// Utilizando la clase HttpClient, realiza una petición GET asíncrona al siguiente
// endpoint: https://jsonplaceholder.typicode.com/todos/

HttpClient client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");

response.EnsureSuccessStatusCode();

// A la respuesta JSON de la API, deserialízala en una lista de objetos de tu clase
// Tarea (List<Tarea>)
string responseBody = await response.Content.ReadAsStringAsync();
List<Tarea> listTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);

// Recorra la lista de tareas y muestra en la consola el título y el estado
// (completada/pendiente) de cada una de forma clara y legible, Al mostrar los
// resultados en consola, filtra la lista para mostrar primero todas las tareas
// pendientes y luego las completadas.

foreach (var Tar in listTareas)
{
    if (Tar.completed) {
        Console.WriteLine("Tareas Completadas:")
        Console.WriteLine("ID Usuario: " + Tar.userId + " ID Tarea: " + Prov.id + " Tarea: " + Prov.title);    
    }
}

foreach (var Tar in listTareas)
{
    if (!Tar.completed) {
        Console.WriteLine("Tareas No Completadas:")
        Console.WriteLine("ID Usuario: " + Tar.userId + " ID Tarea: " + Prov.id + " Tarea: " + Prov.title);    
    }
}


