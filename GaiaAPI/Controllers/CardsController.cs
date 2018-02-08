using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GaiaAPI.Models;
using System.Linq;

namespace GaiaAPI.Controllers
{
    [Route("api/card")]
    public class CardController : Controller
    {
        private readonly CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;

            if (_context.CardItems.Count() == 0)
            {
                _context.CardItems.Add(new CardItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<CardItem> GetAll()
        {
            return _context.CardItems.ToList();
        }

        [HttpGet("{id}", Name = "GetCard")]
        public IActionResult GetById(long id)
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
        public IActionResult Update(long id, [FromBody] CardItem item)
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
        public IActionResult Delete(long id)
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