using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Establishment;
using System.Text.RegularExpressions;

namespace Establishment.Examples {

    [TestClass]
    public class UnitTest1 {
    
        [TestMethod]
        public void TestMethod1() {
            
        }

        public void DoSomething(string parameter, int index) {
            Establish.ForObject(parameter).IsNotNullOrEmpty();
            Establish.ForStruct(index).IsPositive();
        }

        public void ChainingExample(string phoneNumber) {
            Regex _phoneRegex = new Regex("");
            Establish.ForObject(phoneNumber).IsNotNullOrEmpty().HasMaximumLength(14).MatchesPattern(_phoneRegex);
        }

        public void Reflection(Type type) {
            Establish.ForObject(type)
                .IsPublic()
                .IsNotAbstract()
                .Satisfies(x => x.GetInterface("IExample") != null);

            Establish.ThrowExceptionOnFailure = false;
        }
        
    }

}
