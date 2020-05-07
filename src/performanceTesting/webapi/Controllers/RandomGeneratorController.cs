using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Extensions;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomGeneratorController : ControllerBase
    {
        [HttpGet]
        [Route("numbers")]
        public IEnumerable<int> Numbers(int countToCreate = 1000)
        {
            var rng = new Random();
            List<int> res = new List<int>(countToCreate);

            for (int i = 0; i < countToCreate; i++)
            {
                res.Add(rng.Next());
            }

            return res;
        }

        [HttpGet]
        [Route("numbers/encrypted/{countToCreate:int}")]
        [Route("numbers/encrypted")]
        //http://localhost:5000/api/randomGenerator/numbers/encrypted/1000
        public IEnumerable<string> EncryptRandomNumbers(int countToCreate = 1000)
        {
            var rng = new Random();

            List<string> res = new List<string>(countToCreate);

            for (int i = 0; i < countToCreate; i++)
            {
                int num = rng.Next();
                string numAsString = num.ToString();
                string encryptedValue = numAsString.Encrypt("encryptionKey");
                res.Add(encryptedValue);
            }

            return res;

        }
    }
}