using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The Firs Name of the Person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Last Name of the Person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the Person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary Cell Phone Number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }

    }
}
