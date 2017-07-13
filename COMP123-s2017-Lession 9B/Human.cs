using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 11, 2017
 * Description: This is the abstract human class
 * Version:0.1 - Created the Abstract Human class
 */
namespace COMP123_s2017_Lession_9B
{
    /// <summary>
    /// this is the Abstract Human Class
    /// </summary>
    public abstract class Human 
    {
        //Private instant variables
        private string _name;

        //Public properties
        public string Name 
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //Constructors
        /// <summary>
        /// This is the main constructor for the Human class.
        /// It takes one parameter -name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        //Private methods

        //Public methods
    }
}