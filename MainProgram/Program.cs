using System;
using System.IO;
using NameSorterNS;
namespace MainProgram {
    class Program {

        /// <summary>
        /// This function will create a txt file with ordered names
        /// if the file is already exsist, it will overwrite the function
        /// </summary>
        /// <param name="orderedNames">An array of the names an each contains at least 1 given up to 3 and 1 last name</param>
        private static void writeNewOrderedNameFile(string[] orderedNames) {
            
            // create txt file if it does not exist, otherwise overwrite the file
            // with ordered names
            using (StreamWriter sw = File.CreateText("sorted-names-list.txt")) {
                foreach (string name in orderedNames) {
                    sw.WriteLine(name);
                }
            }
            Console.WriteLine("Name Sorting Completed.");
        }




        /// <summary>
        /// This function will check whether the file exist for the given file path
        /// otherwise file not found exception is thrown 
        /// </summary>
        /// <param name="filePath"> The file path that contains a list of unsorted name</param>
        /// <returns> strings of unsorted names in array format</returns>
        public static string[] readFiles(string filePath) {

            if (File.Exists(filePath)) {
                return File.ReadAllLines(filePath);
            } else {
                throw new FileNotFoundException("This file doesn't exists");
            }
        }

        /// <summary>
        /// This function will check whether the given argument satisify
        /// This function only allows 1 argument, if there are more or less than 1 argument
        /// The function will not operate and shows an error message.
        /// 
        /// if the argument is ok, this function will sort the unsroted names and create/overwrite 
        /// a new txt file with sorted names
        /// </summary>
        /// <param name="args">argument input from users</param>
        private static void sortNameFile(string[] args) {
            // this process can make it so iterate throught the arguments. 
            // but for now we only allow one input argument
            if (args.Length != 1) {
                Console.WriteLine("Require Only 1 File Path");
            } else {
                NameSorter nameSorter = new NameSorter();
                string[] names = readFiles(args[0]);
                string[] orderedNames = nameSorter.sortByLastNameGivenName(names);
                writeNewOrderedNameFile(orderedNames);
                //nameSorter.writeNewOrderedNameFile(args[0]);
            }
        }
        static void Main(string[] args) {
            
            try {
                // sort the file 
                sortNameFile(args);

            // file may not exist
            }catch (FileNotFoundException e) {
                Console.WriteLine("File Does Not Exist.");
                
            // file may not have the permission to read and write
            }catch (UnauthorizedAccessException e) {
                Console.WriteLine("File or File destination does not have the required permission of read and write");
            // any internal error
            }catch (Exception e) {
                Console.WriteLine("Error: " + e);
            }
            
        }
    }
}
