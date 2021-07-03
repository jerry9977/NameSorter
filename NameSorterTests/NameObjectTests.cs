using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace NameSorterNS.Tests {
    [TestClass()]
    public class NameObjectConstructorTests {

        
        // test if name object constructor can sucessfully determine which 
        // one is given name and last name. given input of up to 3 given name and at least 1 last name
        
        [TestMethod()]
        public void NameIntoNameObject00() {
            NameObject person = new NameObject(TestData.person00);
            Assert.AreEqual("Parsons", person.LastName);
        }

        
        [TestMethod()]
        public void NameIntoNameObject01() {


            NameObject person = new NameObject(TestData.person01);
            Assert.AreEqual("Vaughn", person.GivenName);
        }


        [TestMethod()]
        public void NameIntoNameObject02() {

            NameObject person = new NameObject(TestData.person02);
            Assert.AreEqual("Archer", person.LastName);
        }

        [TestMethod()]
        public void NameIntoNameObject03() {

            NameObject person = new NameObject(TestData.person03);
            Assert.AreEqual("shelby nathan", person.GivenName);
        }

        [TestMethod()]
        public void NameIntoNameObject04() {

            NameObject person = new NameObject(TestData.person08);
            Assert.AreEqual("Clarke", person.LastName);
        }

        [TestMethod()]
        public void NameIntoNameObject05() {

            NameObject person = new NameObject(TestData.person08);
            Assert.AreEqual("Hunter Uriah Mathew", person.GivenName);
        }



        [TestMethod()]
        public void NameIntoNameObject06() {

            NameObject person = new NameObject(TestData.person00);
            Assert.AreEqual(TestData.person00, person.FullName);
        }


        [TestMethod()]
        public void NameIntoNameObject07() {

            NameObject person = new NameObject(TestData.person02);
            Assert.AreEqual(TestData.person02, person.FullName);
        }

        [TestMethod()]
        public void NameIntoNameObject08() {

            NameObject person = new NameObject(TestData.person08);
            Assert.AreEqual(TestData.person08, person.FullName);
        }


    }
}