using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class Establish
    {

        static Establish() 
        {
            ThrowExceptionOnFailure = true;
        }

        public static EstablisherBase<T> For<T>(T value)
        {
            return new EstablisherBase<T>(value)
            {
                ThrowExceptionOnFailure = ThrowExceptionOnFailure
            };
        }

        public static EstablisherBase<T> For<T>(T value, string paramName)
        {
            return new EstablisherBase<T>(value, paramName)
            {
                ThrowExceptionOnFailure = ThrowExceptionOnFailure
            };
        }

        public static bool ThrowExceptionOnFailure { get; set; }

    }

}
