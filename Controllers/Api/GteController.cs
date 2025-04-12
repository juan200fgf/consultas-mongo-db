using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet ("listar-metros-terreno") ]
public IActionResult ListarMetrosTerreno(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.MetrosTerreno, 518);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-costo") ]
public IActionResult ListarCosto(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.Costo, 40000);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-baños") ]
public IActionResult ListarBaños(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.Baños, 1);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}