using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ourakoz.GaiaAPI.Models;

namespace ourakoz.GaiaAPI.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;
            if (_context.CardItems.Any()) return;
            _context.CardItems.Add(new CardItem(Guid.NewGuid(), "Card1"));
            _context.SaveChanges();
        }

        [HttpGet]
        public IEnumerable<CardItem> GetAll()
        {
            return _context.CardItems.ToList();
        }

        [HttpGet("{id}", Name = "GetCard")]
        public IActionResult GetById(Guid id)
        {
            var item = _context.CardItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CardItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.CardItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetCard", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] CardItem item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var card = _context.CardItems.FirstOrDefault(t => t.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            card.Name = item.Name;

            _context.CardItems.Update(card);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var card = _context.CardItems.FirstOrDefault(t => t.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            _context.CardItems.Remove(card);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}