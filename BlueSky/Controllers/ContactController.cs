using BlueSky.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlueSky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private List<Contact> contacts = new List<Contact>
        {
            new Contact
            {
                ID = 1,
                FirstName= "Nishant",
                LastName = "Kumbhar",
                Nickname = "Nana",
                Place = "Patan",
                DateCreated = DateTime.Now,
                IsDeleted= false,
            },
            new Contact
            {
                ID = 2,
                FirstName= "Shubham",
                LastName = "Khutale",
                Nickname = "Shubhya",
                Place = "Patan",
                DateCreated = DateTime.Now,
                IsDeleted= true,
            },
            new Contact
            {
                ID = 3,
                FirstName= "Viraj",
                LastName = "Patil",
                Nickname = "Chendu",
                Place = "Hadapsar",
                DateCreated = DateTime.Now,
                IsDeleted= false,
            },
            new Contact
            {
                ID = 4,
                FirstName= "Sarang",
                LastName = "Thorat",
                Nickname = "Sabhang",
                Place = "Patan",
                DateCreated = DateTime.Now,
                IsDeleted= false,
            }
        };

        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            //return new string[] { "value1", "value2" };
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.ID == id);

            if(contact == null)
            {
                return NotFound(new { Message = "Contact has been not found."});
            }
            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact newContact)
        {
            contacts.Add(newContact);
            return contacts;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put(int id, Contact updatedContact)
        {
            Contact contact = contacts.FirstOrDefault(c => c.ID == id);

            if (contact == null)
            {
                return NotFound(new { Message = "Contact not found for updating." });
            }

            contact.FirstName = updatedContact.FirstName;
            contact.LastName = updatedContact.LastName;
            contact.Nickname = updatedContact.Nickname;
            contact.Place = updatedContact.Place;
            contact.IsDeleted = updatedContact.IsDeleted;

            return contacts;

        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.ID == id);

            if (contact == null)
            {
                return NotFound(new { Message = "Contact not found for updating." });
            }

            contacts.Remove(contact);
            return contacts;
        }
    }
}
