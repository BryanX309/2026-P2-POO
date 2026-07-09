using Microsoft.AspNetCore.Mvc;
using Sales.API.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("api/categories")]

    public class CategoryController:ControllerBase
    {
        private readonly List<CategoryEntity> _categories;

        public CategoryController()
        {
            _categories = new List<CategoryEntity>();

            _categories.Add(new CategoryEntity{Id = "1", Name = "Lácteos", Description=""});
            _categories.Add(new CategoryEntity{Id = "2", Name = "Frutas", Description=""});
            _categories.Add(new CategoryEntity{Id = "3", Name = "Higiene", Description=""});
            _categories.Add(new CategoryEntity{Id = "4", Name = "Carnes", Description=""});
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        [HttpGet("{id}")] // GET: .../categories/{id}
        public IActionResult GetOne(string id)
        {
            return Ok(_categories.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]

        public IActionResult Post([FromBody] CategoryEntity category)
        {
            _categories.Add(category);

            Console.WriteLine($"Categoría Agregada: {category.Id}, {category.Name}, {category.Description}");

            return Ok("Categoría Creada");
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] CategoryEntity category)
        {
            category.Id = id; // en la Vida real no pasa
            var oldCategory = _categories.FirstOrDefault(c => c.Id == id);

            if (oldCategory != null)
            {
                _categories.Remove(oldCategory);
                _categories.Add(category);

                Console.WriteLine($"Categoría Actualizada: {category.Id}, {category.Name}, {category.Description}");
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);

            if (category != null)
            {
                _categories.Remove(category);

                Console.WriteLine($"Categoría Eliminada: {category.Id}, {category.Name}, {category.Description}");
            }

            return Ok();
        }
    }
}