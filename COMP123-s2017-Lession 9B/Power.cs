﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 11, 2017
 * Description: This is the Power class
 * Version:0.2 - Added a constructor
 */
namespace COMP123_s2017_Lession_9B
{
    /// <summary>
    /// This is the Power class which will be used as a Date type
    /// </summary>
    public class Power
    {
        //Public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //Public properties

        /// <summary>
        /// This is a main constructor for the Power class
        /// It takes two arguments - name(string) -rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}