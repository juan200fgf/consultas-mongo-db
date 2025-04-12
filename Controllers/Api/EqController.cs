using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-agencias")]
    public IActionResult ListarAgencias(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmuebles>("RentasVentas");

        var filtro = Builders<Inmuebles>.Filter.Eq(x => x.Agencia, "Inmobiliaria Pérez");
        var lista = collection.Find(filtro).ToList();

        return Ok();
    }


    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmuebles>("RentasVentas");

        var filtro = Builders<Inmuebles>.Filter.Eq(x => x.Costo, 33421);
        var lista = collection.Find(filtro).ToList();

        return Ok();
    }

    [HttpGet("listar-tiene-patio")]
    public IActionResult ListarTienePatio(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmuebles>("RentasVentas");

        var filtro = Builders<Inmuebles>.Filter.Eq(x => x.TienePatio, false);
        var lista = collection.Find(filtro).ToList();

        return Ok();
    }
}