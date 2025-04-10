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

        var lista = collection.Find(FilterDefinition<Inmuebles>.Empty).ToList();

        return Ok();
    }
}