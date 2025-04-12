using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet ("listar-metros-terreno") ]
public IActionResult ListarMetrosTerreno(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.MetrosTerreno, 600);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-costo") ]
public IActionResult ListarCosto(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.Costo, 50000);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet ("listar-metros-construccion") ]
public IActionResult ListarMetrosConstruccion(){
MongoClient client = new MongoClient (CadenasConexion .MONGO_DB);
var db = client.GetDatabase ("Inmuebles") ;
var collection = db.GetCollection<Inmuebles> ("RentasVentas");
var filtro = Builders<Inmuebles>.Filter.Gt(x => x.MetrosConstruccion, 100);
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}
}