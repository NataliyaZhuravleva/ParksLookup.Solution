using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksLookupContext _db;

    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string parkName, string parkType, string parkAddress, bool? parkPetsAllowed, bool? parkStore, bool random)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }
      if (parkType != null)
      {
        query = query.Where(entry => entry.ParkType == parkType);
      }
      if (parkAddress != null)
      {
        query = query.Where(entry => entry.ParkAddress == parkAddress);
      }
      if (parkPetsAllowed.HasValue)
      {
        query = query.Where(entry => entry.ParkPetsAllowed == parkPetsAllowed);
      }
      if (parkStore.HasValue)
      {
        query = query.Where(entry => entry.ParkStore == parkStore);
      }

      if (random != false)
      {
        Random rnd = new Random();
        int toSkip=rnd.Next(0, _db.Parks.Count());
        var randomPark = _db.Parks.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();

        query = query.Where(entry => entry.ParkId == randomPark.ParkId);
      }
      return query.ToList();
    }

    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // GET api/parks/1
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    // PUT api/parks/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/parks/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}