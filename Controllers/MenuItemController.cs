using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuItemController : ControllerBase
    {
        // GET: api/<MenuItemController>
        private List<MenuItem> lst= new List<MenuItem>()
        {
            new MenuItem()
            {
                Id = 11,
                Name = "Burger",
                freeDelivery = false,
                Price = 55,
                dateOfLaunch = new DateTime(2015, 12, 31),
                Active = true

            },
            new MenuItem()
            {
                Id = 15,
                Name = "Pizza",
                freeDelivery = false,
                Price = 71,
                dateOfLaunch = new DateTime(2011, 02, 14),
                Active = true

            }
        };

    [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            
            return lst;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            MenuItem obj= lst.Find(item => item.Id == id);
            if(obj!=null)
            {
                return obj.Name;
            }
            else
            {
                return "Item Not Found";
            }

        }
    }
}
