using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ourakoz.StellaApi.Logging;
using ourakoz.StellaApi.Models;
using ourakoz.StellaApi.Models.Models.CardItem;

namespace ourakoz.StellaApi.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly CardContext _context;
        private static readonly Logger Logger = new Logger();
        private static readonly string Category = typeof(CardController).FullName;

        public CardController(CardContext context)
        {
            _context = context;
            if (_context.CardItems.Any()) return;
            var card = new CardItem(Guid.NewGuid(), "Card1");
            _context.CardItems.Add(card);
            Logger.Info(Category, $"Created card {{ Id = { card.Id }, Name = { card.Name } }}");
            _context.SaveChanges();
        }

        [HttpGet]
        public IEnumerable<ICardItem> GetAll()
        {
            Logger.Info(Category, "Retrieved all cards");
            return _context.CardItems.ToList();
        }

        [HttpGet("{id}", Name = "GetCard")]
        public IActionResult GetById(Guid id)
        {
            var item = _context.CardItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                Logger.Warn(Category, $"Did not find card {{ Id = { id } }}");
                return NotFound();
            }
            Logger.Info(Category, $"Retrieved card {{ Id = { item.Id }, Name = { item.Name } }}");
            return new ObjectResult(item);
        }

        //[HttpPost]
        //public IActionResult Create([FromBody] ICardItem item)
        //{
        //    if (item == null)
        //    {
        //        return BadRequest();
        //    }

        //    _context.CardItems.Add(item);
        //    _context.SaveChanges();

        //    return CreatedAtRoute("GetCard", new { id = item.Id }, item);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(Guid id, [FromBody] ICardItem item)
        //{
        //    if (item == null || item.Id != id)
        //    {
        //        return BadRequest();
        //    }

        //    var card = _context.CardItems.FirstOrDefault(t => t.Id == id);
        //    if (card == null)
        //    {
        //        return NotFound();
        //    }

        //    card.Name = item.Name;

        //    _context.CardItems.Update(card);
        //    _context.SaveChanges();
        //    return new NoContentResult();
        //}

    //    [HttpDelete("{id}")]
    //    public IActionResult Delete(Guid id)
    //    {
    //        var card = _context.CardItems.FirstOrDefault(t => t.Id == id);
    //        if (card == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.CardItems.Remove(card);
    //        _context.SaveChanges();
    //        return new NoContentResult();
    //    }
    }
}