#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {

        private readonly BibliotecaApiContext _context;
        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Consultalibros()
        {
            return Ok(await _context.Libro.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AgregarLibro(Libro Libro)
        {
            _context.Libro.Add(Libro);
            await _context.SaveChangesAsync();
            return Ok(Libro);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarLibro(Libro Libro)
        {
            _context.Update(Libro);
            await _context.SaveChangesAsync();
            return Ok(Libro);
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarLibro(Libro Libro)
        {
            _context.Remove(Libro);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ConsultaPelis()
        {
            return Ok(await _context.Pelicula.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AgregarPeli(Pelicula Pelicula)
        {
            _context.Libro.Add(Pelicula);
            await _context.SaveChangesAsync();
            return Ok(Pelicula);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarPelicula(Pelicula Pelicula)
        {
            _context.Update(Pelicula);
            await _context.SaveChangesAsync();
            return Ok(Pelicula);
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarPelicula(Pelicula Pelicula)
        {
            _context.Remove(Pelicula);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
