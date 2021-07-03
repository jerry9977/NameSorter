using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NameSorterNS.Tests {
    [TestClass()]
    public class NameOrderTests {

        // test if sortbyname function can successfully sort names by last name
        // if the they have the same last name, then will orderby its given name

        [TestMethod()]
        public void OrderName00() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01 };
            string[] expectedOrderedNames = { TestData.person01, TestData.person00 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names)); 
        }

        [TestMethod()]
        public void OrderName01() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person01, TestData.person00 };
            string[] expectedOrderedNames = { TestData.person01, TestData.person00 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        [TestMethod()]
        public void OrderName02() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02 };
            string[] expectedOrderedNames = { TestData.person02, TestData.person01, TestData.person00 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        [TestMethod()]
        public void OrderName03() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03 };
            string[] expectedOrderedNames = { TestData.person02, TestData.person01, TestData.person00, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        [TestMethod()]
        public void OrderName04() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03, TestData.person04 };
            string[] expectedOrderedNames = { TestData.person04, TestData.person02, TestData.person01, TestData.person00, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        [TestMethod()]
        public void OrderName05() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03, TestData.person04, TestData.person05, TestData.person06, TestData.person07, TestData.person08, TestData.person09, TestData.person10 };
            string[] expectedOrderedNames = { TestData.person04, TestData.person02, TestData.person06, TestData.person08, TestData.person07, TestData.person01, TestData.person05, TestData.person09, TestData.person00, TestData.person10, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }
        [TestMethod()]
        public void OrderName06() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03, TestData.person04, TestData.person05, TestData.person06, TestData.person07, TestData.person08, TestData.person09, TestData.person10, TestData.person11 };
            string[] expectedOrderedNames = { TestData.person04, TestData.person02, TestData.person06, TestData.person08, TestData.person07, TestData.person01, TestData.person05, TestData.person09, TestData.person11, TestData.person00, TestData.person10, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        [TestMethod()]
        public void OrderName07() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03, TestData.person04, TestData.person05, TestData.person06, TestData.person07, TestData.person08, TestData.person09, TestData.person10, TestData.person11, TestData.person12 };
            string[] expectedOrderedNames = { TestData.person04, TestData.person02, TestData.person06, TestData.person08, TestData.person07, TestData.person01, TestData.person05, TestData.person09, TestData.person11, TestData.person12, TestData.person00, TestData.person10, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }

        public void OrderName08() {
            NameSorter nameSorter = new NameSorter();
            string[] names = { TestData.person00, TestData.person01, TestData.person02, TestData.person03, TestData.person04, TestData.person05, TestData.person06, TestData.person07, TestData.person08, TestData.person09, TestData.person10, TestData.person11, TestData.person12, TestData.person12 };
            string[] expectedOrderedNames = { TestData.person04, TestData.person02, TestData.person06, TestData.person08, TestData.person07, TestData.person01, TestData.person05, TestData.person09, TestData.person11, TestData.person12, TestData.person12, TestData.person00, TestData.person10, TestData.person03 };
            CollectionAssert.AreEqual(expectedOrderedNames, nameSorter.sortByLastNameGivenName(names));
        }
    }
}
