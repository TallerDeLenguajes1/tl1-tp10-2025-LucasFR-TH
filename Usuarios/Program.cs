using EspacioUsuario;
using System;
using System.Text.Json;

// Utilizando la clase HttpClient, realiza una petición GET asíncrona al siguiente
// endpoint: https://jsonplaceholder.typicode.com/users

HttpClient client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

response.EnsureSuccessStatusCode();

// A la respuesta JSON de la API, deserialízala en una lista de objetos de tu clase
// Usuarios (List<Usuario>)
string responseBody = await response.Content.ReadAsStringAsync();
List<Usuario> listUsu = JsonSerializer.Deserialize<List<Usuario>>(responseBody);

// Recorra la lista de usuarios y muestro datos

int contador = 0;
foreach (var Usu in listUsu)
{
    while (contador < 5) {
        Console.WriteLine("Nombre: " + Usu.name + " Correo electronico: " + Usu.email + " Domicilio: " + Usu.Address);
        contador ++;
        string jsonString = JsonSerializer.Serialize(Usu); 
    }
}
