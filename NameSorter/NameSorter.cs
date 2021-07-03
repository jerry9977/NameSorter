using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace NameSorterNS {

    // A name object seperate given and last name in constructor. But also stores its full name
    // this is useful later when using linq to do sorting problem
    public class NameObject {
        // read only data with get function
        public string GivenName { get; }
        public string LastName { get; }

        public string FullName { get; }
        /// <summary>
        /// A constructor for name obejct, which sepeate given and last name based on spaces in between
        /// name must contain at least 1 given name and 1 last name
        /// </summary>
        /// <param name="name"></param>
        public NameObject(string name) {

            // seperate given and last name by spaces in between
            int idx = name.LastIndexOf(' ');

            // given names are the substrings of the white spaces up to the last white space
            GivenName = name.Substring(0, idx);

            // last name is the string after last space
            LastName = name.Substring(idx + 1);

            // stores its original full name for convinent use later
            FullName = name;
        }
    }



    /// <summary>
    /// Name sorter contains a function that sort its name by last name then given name
    /// </summary>
    public class NameSorter {


        /// <summary>
        /// this function will sort names by its last name then given name
        /// </summary>
        /// <param name="names"> Strings array that contains up to 3 given and 1 last name</param>
        /// <returns> String array that is sorted by its last name then given name </returns>
        public string[] sortByLastNameGivenName(string[] names) {
            
            // construct each of the objects into name object.
            // it is use for Linq in the later code
            List<NameObject> nameObjectList = new List<NameObject>();
            foreach(string name in names) {
                nameObjectList.Add(new NameObject(name));
            }

            // use linq to order by its last name and given name.
            // after that we select its full name (string) in an array format
            return  (from nameObject in nameObjectList
                    orderby nameObject.LastName, nameObject.GivenName 
                     select nameObject.FullName).ToArray();
            
        }

        


    }
}
