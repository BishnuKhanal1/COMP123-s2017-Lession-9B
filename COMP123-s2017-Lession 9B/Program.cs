﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bishnu Khanal
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version:0.4 - Added another Power to the SuperHuman object
 *              -Also displayed all the powers in the Power List 
 */
namespace COMP123_s2017_Lession_9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");

            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 45);
            superHuman.DisplayPowers();

        }
    }
}
