using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {
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
List <string> tipo = new List <string> ();
tipo.Add ("Inmobiliaria Pérez");
tipo.Add ("Agencia XYZ");
var filtro = Builders<Inmuebles>.Filter.In(x => x.Agencia, tipo);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet("listar-pisos")]
public IActionResult ListarPisos(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
List <int> tipo = new List <int> ();
tipo.Add (0);
tipo.Add (1);
tipo.Add (2);
var filtro = Builders<Inmuebles>.Filter.In(x => x.Pisos, tipo);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}