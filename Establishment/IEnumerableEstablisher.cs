using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Establishment {

    public class IEnumerableEstablisher<TSource> : BaseEstablisher<IEnumerable<TSource>>, IClassEstablisher<IEnumerableEstablisher<TSource>, IEnumerable<TSource>> {

        internal IEnumerableEstablisher(IEnumerable<TSource> value) : base(value) { }

        public IEnumerableEstablisher<TSource> HasElements() {
            if (!Value.Any()) {
                HandleException("IEnumerable value must contain at least one element");
            }

            return this;
        }

        public IEnumerableEstablisher<TSource> HasNoElements() {
            if (Value.Any()) {
                HandleException("IEnumerable value must not contain any elements");
            }

            return this;
        }

        public IEnumerableEstablisher<TSource> HasMinimumLength(int minimumElements) {
            if (Value.Count() < minimumElements) {
                HandleException(string.Concat("IEnumerable value must have at least ", minimumElements, " elements"));
            }

            return this;
        }

        public IEnumerableEstablisher<TSource> HasMaximumLength(int maximumElements) {
            if (Value.Count() > maximumElements) {
                HandleException(string.Concat("IEnumerable value must not have more than ", maximumElements, " elements"));
            }

            return this;
        }

        public IEnumerableEstablisher<TSource> HasExactLength(int totalElements) {
            if (Value.Count() != totalElements) {
                HandleException(string.Concat("IEnumerable value must contain exactly ", totalElements, " elements"));
            }

            return this;
        }

        public IEnumerableEstablisher<TSource> IsNull() {
            return base.IsDefault<IEnumerableEstablisher<TSource>>();
        }

        public IEnumerableEstablisher<TSource> IsNotNull() {
            return base.IsNotDefault<IEnumerableEstablisher<TSource>>();
        }

        public IEnumerableEstablisher<TSource> IsEqualTo(IEnumerable<TSource> constraint) {
            return base.IsEqualTo<IEnumerableEstablisher<TSource>>(constraint);
        }

        public IEnumerableEstablisher<TSource> IsNotEqualTo(IEnumerable<TSource> constraint) {
            return base.IsNotEqualTo<IEnumerableEstablisher<TSource>>(constraint);
        }

        public IEnumerableEstablisher<TSource> Satisfies(Action<IEnumerable<TSource>> action) {
            return base.Satisfies<IEnumerableEstablisher<TSource>>(action);
        }

        public IEnumerableEstablisher<TSource> Satisfies(Func<IEnumerable<TSource>, bool> predicate) {
            return base.Satisfies<IEnumerableEstablisher<TSource>>(predicate);
        }

    }

}
