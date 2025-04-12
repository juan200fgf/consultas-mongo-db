using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route ("api/ne")]
public class NeController: Controller {
[HttpGet ("listar-costo")]
public IActionResult ListarCosto(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Costo, 33421);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-tipo")]
public IActionResult ListarTipo(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Tipo, "Departamento");
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-agencia")]
public IActionResult ListarAgencia(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Agencia, "Inmobiliaria Pérez");
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}