using EspacioTarea;
using System;
using System.Text.Json;

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

Console.WriteLine("Tareas Completadas:");
foreach (var Tar in listTareas)
{
    if (Tar.completed)
    {
        Console.WriteLine("ID Usuario: " + Tar.userId + " ID Tarea: " + Tar.id + " Tarea: " + Tar.title);
    }
}

Console.WriteLine("Tareas No Completadas:");
foreach (var Tar in listTareas)
{
    if (!Tar.completed)
    {
        Console.WriteLine("ID Usuario: " + Tar.userId + " ID Tarea: " + Tar.id + " Tarea: " + Tar.title);
    }
}


// A la lista completa de tareas y serialízala nuevamente a formato JSON y guarda el
// resultado en un archivo llamado tareas.json en el directorio de ejecución de la
// aplicación.
string jsonString = JsonSerializer.Serialize(listTareas);
Console.WriteLine(jsonString);

File.WriteAllText("reporte_archivos.json", jsonString);

