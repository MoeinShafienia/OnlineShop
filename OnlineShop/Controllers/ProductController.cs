using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        private readonly Models.AppContext _context;

        public ProductController(Models.AppContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public List<Product> Index()
        {
            return _context.Products.Include(x => x.Reviews).ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Product> Get(int id)
        {
            var model = _context.Products.Include(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("mobile")]
        public List<Mobile> Mobile()
        {
            return _context.Mobiles.Include(x => x.IdNavigation).ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("mobile/{id:int}")]
        public ActionResult<Mobile> GetMobile(int id)
        {
            var mobile = _context.Mobiles.Include(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (mobile == null)
            {
                return NotFound();
            }

            return mobile;
        }

        [HttpGet("laptop")]
        public List<Laptop> Laptop()
        {
            return _context.Laptops.Include(x => x.IdNavigation).ToList();
        }

        [HttpGet("laptop/{id:int}")]
        public ActionResult<Laptop> GetLaptop(int id)
        {
            var laptop = _context.Laptops.Include(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (laptop == null)
            {
                return NotFound();
            }

            return laptop;
        }

        [HttpPost("{id:int}/review")]
        public ActionResult Review([FromBody]Review review)
        {
            var product = _context.Products.Where(x => x.Id == review.ProductId).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            var rev = new Review
            {
                ProductId = review.ProductId,
                Title = review.Title,
                Discription = review.Discription,
                Strengths = review.Strengths,
                Weaknesses = review.Weaknesses
            };

            _context.Reviews.Add(rev);
            _context.SaveChanges();

            return Ok();
        }

    }
}
