using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The Id of the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The cellphone Number of the person
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
