using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Establishment
{
    
    public static class StringEstablisher
    {

        public static EstablisherBase<string> IsNullOrEmpty(this EstablisherBase<string> establisher)
        {
            if (!string.IsNullOrEmpty(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be null or empty.");
            }

            return establisher;
        }

        public static EstablisherBase<string> IsNotNullOrEmpty(this EstablisherBase<string> establisher)
        {
            if (string.IsNullOrEmpty(establisher.Value))
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be null or empty.");
            }

            return establisher;
        }

        public static EstablisherBase<string> IsEmpty(this EstablisherBase<string> establisher)
        {
            if (establisher.Value.Length != 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be empty.");
            }

            return establisher;
        }

        public static EstablisherBase<string> IsNotEmpty(this EstablisherBase<string> establisher)
        {
            if (establisher.Value.Length == 0)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must not be empty.");
            }

            return establisher;
        }

        public static EstablisherBase<string> HasExactLength(this EstablisherBase<string> establisher, int length)
        {
            if (establisher.Value.Length != length)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must be exactly {length} characters.");
            }

            return establisher;
        }

        public static EstablisherBase<string> HasMinimumLength(this EstablisherBase<string> establisher, int minimumLength)
        {
            if (establisher.Value.Length < minimumLength)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must have at least {minimumLength} characters.");
            }

            return establisher;
        }

        public static EstablisherBase<string> HasMaximumLength(this EstablisherBase<string> establisher, int maximumLength)
        {
            if (establisher.Value.Length > maximumLength)
            {
                establisher.RaiseArgumentException($"{establisher.ParameterName} must have fewer than {maximumLength} characters.");
            }

            return establisher;
        }

        public static EstablisherBase<string> MatchesPattern(this EstablisherBase<string> establisher, string regexPattern)
        {
            var regex = new Regex(regexPattern);

            return MatchesPattern(establisher, regex);
        }

        public static EstablisherBase<string> MatchesPattern(this EstablisherBase<string> establisher, string regexPattern, RegexOptions options)
        {
            var regex = new Regex(regexPattern, options);

            return MatchesPattern(establisher, regex);
        }

        public static EstablisherBase<string> MatchesPattern(this EstablisherBase<string> establisher, Regex regex)
        {
            Establish.For(regex).IsNotNull();

            if (!regex.IsMatch(establisher.Value))
            {
                establisher.RaiseArgumentException("No regex matches were found in the current string.");
            }

            return establisher;
        }

        public static EstablisherBase<string> MatchesPattern(this EstablisherBase<string> establisher, Regex regex, int startAt)
        {
            Establish.For(regex).IsNotNull();

            if (!regex.IsMatch(establisher.Value, startAt))
            {
                establisher.RaiseArgumentException("No regex matches were found in the current string.");
            }

            return establisher;
        }

        public static EstablisherBase<string> DoesNotMatchPattern(this EstablisherBase<string> establisher, string regexPattern)
        {
            var regex = new Regex(regexPattern);

            return DoesNotMatchPattern(establisher, regex);
        }

        public static EstablisherBase<string> DoesNotMatchPattern(this EstablisherBase<string> establisher, string regexPattern, RegexOptions options)
        {
            var regex = new Regex(regexPattern, options);

            return DoesNotMatchPattern(establisher, regex);
        }

        public static EstablisherBase<string> DoesNotMatchPattern(this EstablisherBase<string> establisher, Regex regex)
        {
            Establish.For(regex).IsNotNull();

            if (regex.IsMatch(establisher.Value))
            {
                establisher.RaiseArgumentException("A regex match was found in the current string where none should exist.");
            }

            return establisher;
        }

        public static EstablisherBase<string> DoesNotMatchPattern(this EstablisherBase<string> establisher, Regex regex, int startAt)
        {
            Establish.For(regex).IsNotNull();

            if (regex.IsMatch(establisher.Value, startAt))
            {
                establisher.RaiseArgumentException("A regex match was found in the current string where none should exist.");
            }

            return establisher;
        }

    }

}
