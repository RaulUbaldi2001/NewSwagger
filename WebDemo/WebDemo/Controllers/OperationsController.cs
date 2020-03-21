using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDemo.Controllers
{
    [Route("api/[controller]/[action]/[action]/[action]/[action]")]
    public class OperationsController : Controller
    {
        RepositoryCovid repo;
        // GET: api/<controller>
        [HttpGet]
        public double GetSum(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        public double GetProduct(int a, int b)
        {
            return a * b;
        }
        [HttpGet]
        public double GetAverage(int a, int b)
        {
            return (a + b) / 2;
        }
        [HttpGet]
        public double GetSubtractions(int a, int b)
        {
            return a - b;
        }
        [HttpGet]
        public double GetFactorial(int a)
        {
            int b = a - 1;
            while (b > 0)
            {
                a = a * b;
                b--;
            }
            return a;
        }
        [HttpGet]
        public List<Codiv19_Data> GetListPositivi()
        {
            repo = new RepositoryCovid();
            List<Codiv19_Data> listaPositivi = repo.LoadCovidUmbria();
            return listaPositivi;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
