using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("products/computer-accessories")]
    public class ComputerAccessoryController : Controller
    {
        private readonly Models.AppContext _context;

        public ComputerAccessoryController(Models.AppContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public List<ComputerAccessory> Index()
        {
            return _context.ComputerAccessories.Include(x => x.IdNavigation).ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<ComputerAccessory> Get(int id)
        {
            var model = _context.ComputerAccessories.Include(x => x.IdNavigation).ThenInclude(x => x.Reviews)
                .Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("monitor")]
        public List<Monitor> Monitor()
        {
            return _context.Monitors.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("monitor/{id:int}")]
        public ActionResult<Monitor> GetMonitor(int id)
        {
            var model = _context.Monitors.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("assembledcase")]
        public List<AssembledCase> Case()
        {
            return _context.AssembledCases.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("assembledcase/{id:int}")]
        public ActionResult<AssembledCase> GetCase(int id)
        {
            var model = _context.AssembledCases.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("keyboard")]
        public List<Keyboard> Keyboard()
        {
             return _context.Keyboards.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("keyboard/{id:int}")]
        public ActionResult<Keyboard> GetKeyboard(int id)
        {
            var model = _context.Keyboards.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("externalhard")]
        public List<ExternalHard> Hard()
        {
            return _context.ExternalHards.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("externalhard/{id:int}")]
        public ActionResult<ExternalHard> Gethard(int id)
        {
            var model = _context.ExternalHards.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }
    }
}
