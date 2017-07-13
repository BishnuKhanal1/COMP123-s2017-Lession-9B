using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 11, 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * Version:0.2 - Added _initialized method
 */
namespace COMP123_s2017_Lession_9B
{
    /// <summary>
    /// This is the SuperHuman class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instant variables
        private List<Power> _powers;
        //Public properties
        public List <Power> Powers
        {
            get
            {
                return this._powers;
            }
        }
        //Constructor
        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            this._initialized();
        }
        //Private Methods
        /// <summary>
        /// This method initializes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialized()
        {
            this._powers = new List<Power>();//creates an empty list
        }
        //Public Methods
    }
}