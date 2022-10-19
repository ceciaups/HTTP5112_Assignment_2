using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_Assignment_2.Controllers
{
    public class J1Controller : Controller
    {
        /// <summary>
        /// Compute the total Calories of the meal.
        /// Original Source : ​https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2006/stage1/juniorEn.pdf
        /// </summary>
        /// <param name="burger">Digit choice of burger</param>
        /// <param name="drink">Digit choice of drink</param>
        /// <param name="side">Digit choice of side</param>
        /// <param name="dessert">Digit choice of desset</param>
        /// <return>Returns the total Calories of the meal</return>
        /// <example>
        /// GET api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet("{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories = 0;
            int[] arrBurger = { 461, 431, 420, 0 };
            int[] arrDrink = { 130, 160, 118, 0 };
            int[] arrSide = { 100, 57, 70, 0 };
            int[] arrDessert = { 167, 266, 75, 0 };

            calories = arrBurger[burger - 1] + arrDrink[drink - 1] + arrSide[side - 1] + arrDessert[dessert - 1];

            return "Your total calorie count is " + calories;
        }
    }
}