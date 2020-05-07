using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeController : ControllerBase
    {
        [Route("isPrime/{valueToCheck:int}")]
        //http://localhost:5000/api/prime/isPrime/1000
        public bool IsPrime(int valueToCheck)
        {
            return DeterminIfNumberIsPrime(valueToCheck);
        }

        [Route("findPrimeNumbersUpTo/{maxValueToCheck:int}")]
        //http://localhost:5000/api/prime/FindPrimeNumbersUpTo/1000
        public KeyValuePair<int, bool>[] FindPrimeNumbersUpToSequentially(int maxValueToCheck)
        {
            var valuesThatArePrimeNumbers = new Dictionary<int, bool>();

            for(int valToTest = 0; valToTest < maxValueToCheck; valToTest++)
            {
                bool isPrime = DeterminIfNumberIsPrime(valToTest);

                if (isPrime)
                    valuesThatArePrimeNumbers[valToTest] = isPrime;
            }

            return valuesThatArePrimeNumbers.ToArray();
        }

        [Route("findPrimeNumbersUpTo/{maxValueToCheck:int}/parallel")]
        //http://localhost:5000/api/prime/FindPrimeNumbersUpTo/1000/parallel
        public KeyValuePair<int, bool>[] FindPrimeNumbersUpToParallel(int maxValueToCheck)
        {
            var valuesThatArePrimeNumbers = new ConcurrentDictionary<int, bool>();

            Parallel.For(0, maxValueToCheck, valToTest =>
            {
                bool isPrime = DeterminIfNumberIsPrime(valToTest);

                if (isPrime)
                    valuesThatArePrimeNumbers[valToTest] = isPrime;
            });

            return valuesThatArePrimeNumbers.ToArray();
        }

        private static bool DeterminIfNumberIsPrime(int valueToCheck)
        {
            int n, i, m = 0;
            m = valueToCheck / 2;
            for (i = 2; i <= m; i++)
            {
                if (valueToCheck % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}