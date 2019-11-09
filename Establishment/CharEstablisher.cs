using System;
using System.Collections.Generic;
using System.Text;

namespace Establishment
{
    
    public static class CharEstablisher
    {

        public static EstablisherBase<char> IsDigit(this EstablisherBase<char> establisher)
        {
            if (!char.IsDigit(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a digit.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotDigit(this EstablisherBase<char> establisher)
        {
            if (char.IsDigit(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be a digit.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsLetter(this EstablisherBase<char> establisher)
        {
            if (!char.IsLetter(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a letter.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotLetter(this EstablisherBase<char> establisher)
        {
            if (char.IsLetter(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be a letter.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsLetterOrDigit(this EstablisherBase<char> establisher)
        {
            if (!char.IsLetterOrDigit(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a letter or a digit.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotLetterOrDigit(this EstablisherBase<char> establisher)
        {
            if (char.IsLetterOrDigit(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be a letter or a digit.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsLower(this EstablisherBase<char> establisher)
        {
            if (!char.IsLower(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be lowercase.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotLower(this EstablisherBase<char> establisher)
        {
            if (char.IsLower(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be lowercase.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsPunctuation(this EstablisherBase<char> establisher)
        {
            if (!char.IsPunctuation(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be punctuation.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotPunctuation(this EstablisherBase<char> establisher)
        {
            if (char.IsPunctuation(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be punctuation.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsSymbol(this EstablisherBase<char> establisher)
        {
            if (!char.IsSymbol(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be a symbol.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotSymbol(this EstablisherBase<char> establisher)
        {
            if (char.IsSymbol(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be a symbol.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsUpper(this EstablisherBase<char> establisher)
        {
            if (!char.IsUpper(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be uppercase.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotUpper(this EstablisherBase<char> establisher)
        {
            if (char.IsUpper(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be uppercase.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsWhiteSpace(this EstablisherBase<char> establisher)
        {
            if (!char.IsWhiteSpace(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be whitespace.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotWhiteSpace(this EstablisherBase<char> establisher)
        {
            if (char.IsWhiteSpace(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be whitespace.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsGreaterThan(this EstablisherBase<char> establisher, char threshold)
        {
            if (establisher.Value <= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsGreaterThanOrEqualTo(this EstablisherBase<char> establisher, char threshold)
        {
            if (establisher.Value < threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be greater than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsLessThan(this EstablisherBase<char> establisher, char threshold)
        {
            if (establisher.Value >= threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsLessThanOrEqualTo(this EstablisherBase<char> establisher, char threshold)
        {
            if (establisher.Value > threshold)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be less than or equal to {threshold}.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsZero(this EstablisherBase<char> establisher)
        {
            if (establisher.Value != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotZero(this EstablisherBase<char> establisher)
        {
            if (establisher.Value == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal zero.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsMinValue(this EstablisherBase<char> establisher)
        {
            if (establisher.Value != char.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal char.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotMinValue(this EstablisherBase<char> establisher)
        {
            if (establisher.Value == char.MinValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal char.MinValue.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsMaxValue(this EstablisherBase<char> establisher)
        {
            if (establisher.Value != char.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must equal char.MaxValue.");
            }

            return establisher;
        }

        public static EstablisherBase<char> IsNotMaxValue(this EstablisherBase<char> establisher)
        {
            if (establisher.Value == char.MaxValue)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not equal char.MaxValue.");
            }

            return establisher;
        }

    }

}
