using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_Assignment_2.Controllers
{
    public class J2Controller : Controller
    {
        /// <summary>
        /// There are two dice with m and n sides respectively.
        /// Determines how many ways the dices can be rolled the value of 10.
        /// Original Source : ​https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
        /// </summary>
        /// <param name="m">Number of sides of the first dice</param>
        /// <param name="n">Number of sides of the second dice</param>
        /// <return>Returns number of ways the dices can rolled the value of 10</return>
        /// <example>
        /// GET /api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10."
        /// GET /api/J2/DiceGame/12/4 -> "There are 4 total ways to get the sum 10."
        /// GET /api/J2/DiceGame/3/3 -> "There are 0 total ways to get the sum 10."
        /// GET /api/J2/Dicegame/5/5 -> "There is 1 total ways to get the sum 10."
        /// </example>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet("{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int numOfWays = 0;

            if (m + n < 10)
                numOfWays = 0;
            else if (m < 9 && n < 9)
                numOfWays = m + n - 9;
            else if (m >= 9 && n >= 9)
                numOfWays = 9;
            else
                numOfWays = (m < n) ? m : n;

            return "There are " + numOfWays + " total ways to get the sum 10.";
        }
    }
}