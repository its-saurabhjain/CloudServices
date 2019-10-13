using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return new Customer[] { new Customer("C101", "ABC"), new Customer("C102", "XYZ") };
        }

        // GET api/customer/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var cnumber = "c" + id;
            return new Customer(cnumber, cnumber + "_ABCXYZ");
        }

    }
    public class Customer {

        public Customer(string number, string name) {
            CustomerNumber = number;
            CustomerName = name;
        }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }

    }
}