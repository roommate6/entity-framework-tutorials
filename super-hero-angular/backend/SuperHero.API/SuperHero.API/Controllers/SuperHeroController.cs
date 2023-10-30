using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHero.API.Data;

namespace SuperHero.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		private readonly SuperHeroContext _context;

		public SuperHeroController(SuperHeroContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
		{
			return Ok(await _context.SuperHeroes.ToListAsync());
		}

		[HttpPost]
		public async Task<ActionResult<List<SuperHero>>> CreateSuperHero(SuperHero superHero)
		{
			_context.SuperHeroes.Add(superHero);
			await _context.SaveChangesAsync();

			return Ok(await _context.SuperHeroes.ToListAsync());
		}

		[HttpPut]
		public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(SuperHero superHero)
		{
			var superHeroFromDatabse = await _context.SuperHeroes.FindAsync(superHero.Id);
			if (superHeroFromDatabse == null)
			{
				return BadRequest("The super hero that you try to modify is top secret and does not exist in our database.");
			}

			superHeroFromDatabse.Name = superHero.Name;
			superHeroFromDatabse.FirstName = superHero.FirstName;
			superHeroFromDatabse.LastName = superHero.LastName;
			superHeroFromDatabse.Place = superHero.Place;

			await _context.SaveChangesAsync();

			return Ok(await _context.SuperHeroes.ToListAsync());
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
		{
			var superHeroFromDatabse = await _context.SuperHeroes.FindAsync(id);
			if (superHeroFromDatabse == null)
			{
				return BadRequest("The super hero that you try to delete is top secret and does not exist in our database.");
			}

			_context.SuperHeroes.Remove(superHeroFromDatabse);
			await _context.SaveChangesAsync();

			return Ok(await _context.SuperHeroes.ToListAsync());
		}
	}
}
