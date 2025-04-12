using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller {
    [HttpGet("listar-tipo")]
public IActionResult ListarTipo(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
List <string> tipo = new List <string> ();
tipo.Add ("Terreno");
tipo.Add ("Casa");
var filtro = Builders<Inmuebles>.Filter.In(x => x.Tipo, tipo);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet("listar-agencia")]
public IActionResult ListarAgencia(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
List <string> agencia = new List <string> ();
agencia.Add ("Inmobiliaria Pérez");
agencia.Add ("Agencia ABC");
var filtro = Builders<Inmuebles>.Filter.In(x => x.Agencia, agencia);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet("listar-nombre-agente")]
public IActionResult ListarNombreAgente(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
List <string> tipo = new List <string> ();
tipo.Add ("Ana Torres");
tipo.Add ("Carlos López");
var filtro = Builders<Inmuebles>.Filter.In(x => x.NombreAgente, tipo);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}