using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_Assignment_2.Controllers
{
    public class J3Controller : Controller
    {
        /// <summary>
        /// Calculate the minimal time needed to type a message on a cell phone,
        /// assuming that 1 second per press and 2 seconds per pause.
        /// Original Source : ​https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
        /// </summary>
        /// <param name="strMessage">the input string</param>
        /// <return>Returns the minimal number of seconds needed to type in the word</return>
        /// <example>
        /// GET /api/J3/CellPhoneMessage/a -> "The minimal number of seconds needed to type in 'a' is 1s."
        /// GET /api/J3/CellPhoneMessage/dada -> "The minimal number of seconds needed to type in 'dada' is 4s."
        /// GET /api/J3/CellPhoneMessage/bob -> "The minimal number of seconds needed to type in 'bob' is 7s."
        /// GET /api/J3/CellPhoneMessage/abba -> "The minimal number of seconds needed to type in 'abba' is 12s."
        /// </example>
        [Route("api/J3/CellPhoneMessage/{strMessage}")]
        [HttpGet("{strMessage}")]
        public string CellPhoneMessage(string strMessage)
        {
            int time = 0;
            int intMessage = 0;
            int lastKey = 0;
            int[] keyboard = { 3, 3, 3, 3, 3, 4, 3, 4 };

            for (int i = 0; i < strMessage.Length; i ++)
            {
                intMessage = char.ToUpper(strMessage[i]) - 64;
                for (int j = 0; j < keyboard.Count(); j++)
                {
                    if (intMessage <= keyboard[j])
                    {
                        time += intMessage;
                        if (i > 0 && lastKey == j)
                            time += 2;
                        lastKey = j;
                        break;
                    }
                    else
                        intMessage -= keyboard[j];
                }
            }

            return "The minimal number of seconds needed to type in " + strMessage + " is " + time + "s.";
        }
    }
}