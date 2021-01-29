using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("products/mobile-accessories")]
    public class MobileAccessoryController : Controller
    {
        private readonly Models.AppContext _context;

        public MobileAccessoryController(Models.AppContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public List<MobileAccessory> Index()
        {
            return _context.MobileAccessories.Include(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<MobileAccessory> Get(int id)
        {
            var model = _context.MobileAccessories.Include(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("mobilecover")]
        public List<MobileCover> Cover()
        {
            return _context.MobileCovers.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("mobilecover/{id:int}")]
        public ActionResult<MobileCover> GetCover(int id)
        {
            var model = _context.MobileCovers.Include(x => x.IdNavigation).ThenInclude(x => x.IdNavigation)
                .ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("powerbank")]
        public List<Powerbank> PowerBank()
        {
            return _context.Powerbanks.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("powerbank/{id:int}")]
        public ActionResult<Powerbank> GetPowerBank(int id)
        {
            var model = _context.Powerbanks.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpGet("mobileholder")]
        public List<MobileHolder> Holder()
        {
            return _context.MobileHolders.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).ToList();
        }

        [HttpGet("mobileholder/{id:int}")]
        public ActionResult<MobileHolder> GetHolder(int id)
        {
            var model = _context.MobileHolders.Include(x => x.IdNavigation)
                .ThenInclude(x => x.IdNavigation).ThenInclude(x => x.Reviews).Where(x => x.Id == id).FirstOrDefault();

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }
    }
}
