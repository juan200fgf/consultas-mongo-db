using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route ("api/lt")]
public class LtController: Controller {
[HttpGet ("listar-costo")]
public IActionResult ListarCosto(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Costo, 30000);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-pisos")]
public IActionResult ListarPisos(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Pisos, 2);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-costo2")]
public IActionResult ListarCosto2(){
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmuebles>("RentasVentas");
var filtro = Builders< Inmuebles>.Filter.Lt(x => x.Costo, 20000);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}