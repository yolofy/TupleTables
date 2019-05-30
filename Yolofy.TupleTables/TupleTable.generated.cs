using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Yolofy
{
    public class TupleTable<TObject> : IEnumerable<TObject>
        where TObject : new()
    {
        protected readonly List<TObject> _internalList = new List<TObject>();
        public IEnumerator<TObject> GetEnumerator() => _internalList.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _internalList.GetEnumerator();

        public static IEnumerable<TObject> Create<T1, T2>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, params (T1, T2)[] records)
            => new TupleTable<TObject, T1, T2>(property1, property2, records);

        public static IEnumerable<TObject> Create<T1, T2, T3>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, params (T1, T2, T3)[] records)
            => new TupleTable<TObject, T1, T2, T3>(property1, property2, property3, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, params (T1, T2, T3, T4)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4>(property1, property2, property3, property4, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, params (T1, T2, T3, T4, T5)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5>(property1, property2, property3, property4, property5, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, params (T1, T2, T3, T4, T5, T6)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6>(property1, property2, property3, property4, property5, property6, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, params (T1, T2, T3, T4, T5, T6, T7)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7>(property1, property2, property3, property4, property5, property6, property7, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, params (T1, T2, T3, T4, T5, T6, T7, T8)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8>(property1, property2, property3, property4, property5, property6, property7, property8, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, params (T1, T2, T3, T4, T5, T6, T7, T8, T9)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9>(property1, property2, property3, property4, property5, property6, property7, property8, property9, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, Expression<Func<TObject, T16>> property16, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, property16, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, Expression<Func<TObject, T16>> property16, Expression<Func<TObject, T17>> property17, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, property16, property17, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, Expression<Func<TObject, T16>> property16, Expression<Func<TObject, T17>> property17, Expression<Func<TObject, T18>> property18, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, property16, property17, property18, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, Expression<Func<TObject, T16>> property16, Expression<Func<TObject, T17>> property17, Expression<Func<TObject, T18>> property18, Expression<Func<TObject, T19>> property19, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, property16, property17, property18, property19, records);

        public static IEnumerable<TObject> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Expression<Func<TObject, T1>> property1, Expression<Func<TObject, T2>> property2, Expression<Func<TObject, T3>> property3, Expression<Func<TObject, T4>> property4, Expression<Func<TObject, T5>> property5, Expression<Func<TObject, T6>> property6, Expression<Func<TObject, T7>> property7, Expression<Func<TObject, T8>> property8, Expression<Func<TObject, T9>> property9, Expression<Func<TObject, T10>> property10, Expression<Func<TObject, T11>> property11, Expression<Func<TObject, T12>> property12, Expression<Func<TObject, T13>> property13, Expression<Func<TObject, T14>> property14, Expression<Func<TObject, T15>> property15, Expression<Func<TObject, T16>> property16, Expression<Func<TObject, T17>> property17, Expression<Func<TObject, T18>> property18, Expression<Func<TObject, T19>> property19, Expression<Func<TObject, T20>> property20, params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)[] records)
            => new TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15, property16, property17, property18, property19, property20, records);

        protected static PropertyInfo GetPropertyInfo<T1>(Expression<Func<TObject, T1>> property)
        {
            var memberExpression = property.Body as MemberExpression;

            if (memberExpression == null)
            {
                throw new ArgumentException("Not a property, use obj => obj.Property", nameof(property));
            }

            var propertyInfo = memberExpression.Member as PropertyInfo;

            if (propertyInfo == null)
            {
                throw new ArgumentException("Not a property", nameof(property));
            }

            if (memberExpression.Expression.Type != typeof(TObject))
            {
                throw new ArgumentException($"Property {propertyInfo.Name} must be selected from type {typeof(TObject)}", nameof(property));
            }

            if (!propertyInfo.CanWrite)
            {
                throw new ArgumentException($"Property {propertyInfo.Name} has no setter", nameof(property));
            }

            return propertyInfo;
        }
    }

    public class TupleTable<TObject, T1, T2> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            params (T1, T2)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            params (T1, T2, T3)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            params (T1, T2, T3, T4)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            params (T1, T2, T3, T4, T5)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            params (T1, T2, T3, T4, T5, T6)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            params (T1, T2, T3, T4, T5, T6, T7)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            params (T1, T2, T3, T4, T5, T6, T7, T8)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            Expression<Func<TObject, T16>> property16,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);
            var propertyInfo16 = GetPropertyInfo(property16);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                propertyInfo16.SetValue(newObject, record.Item16);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            Expression<Func<TObject, T16>> property16,
            Expression<Func<TObject, T17>> property17,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);
            var propertyInfo16 = GetPropertyInfo(property16);
            var propertyInfo17 = GetPropertyInfo(property17);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                propertyInfo16.SetValue(newObject, record.Item16);
                propertyInfo17.SetValue(newObject, record.Item17);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            Expression<Func<TObject, T16>> property16,
            Expression<Func<TObject, T17>> property17,
            Expression<Func<TObject, T18>> property18,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);
            var propertyInfo16 = GetPropertyInfo(property16);
            var propertyInfo17 = GetPropertyInfo(property17);
            var propertyInfo18 = GetPropertyInfo(property18);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                propertyInfo16.SetValue(newObject, record.Item16);
                propertyInfo17.SetValue(newObject, record.Item17);
                propertyInfo18.SetValue(newObject, record.Item18);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            Expression<Func<TObject, T16>> property16,
            Expression<Func<TObject, T17>> property17,
            Expression<Func<TObject, T18>> property18,
            Expression<Func<TObject, T19>> property19,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);
            var propertyInfo16 = GetPropertyInfo(property16);
            var propertyInfo17 = GetPropertyInfo(property17);
            var propertyInfo18 = GetPropertyInfo(property18);
            var propertyInfo19 = GetPropertyInfo(property19);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                propertyInfo16.SetValue(newObject, record.Item16);
                propertyInfo17.SetValue(newObject, record.Item17);
                propertyInfo18.SetValue(newObject, record.Item18);
                propertyInfo19.SetValue(newObject, record.Item19);
                _internalList.Add(newObject);
            }
        }
    }

    public class TupleTable<TObject, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : TupleTable<TObject>
        where TObject : new()
    {
        public TupleTable(
            Expression<Func<TObject, T1>> property1,
            Expression<Func<TObject, T2>> property2,
            Expression<Func<TObject, T3>> property3,
            Expression<Func<TObject, T4>> property4,
            Expression<Func<TObject, T5>> property5,
            Expression<Func<TObject, T6>> property6,
            Expression<Func<TObject, T7>> property7,
            Expression<Func<TObject, T8>> property8,
            Expression<Func<TObject, T9>> property9,
            Expression<Func<TObject, T10>> property10,
            Expression<Func<TObject, T11>> property11,
            Expression<Func<TObject, T12>> property12,
            Expression<Func<TObject, T13>> property13,
            Expression<Func<TObject, T14>> property14,
            Expression<Func<TObject, T15>> property15,
            Expression<Func<TObject, T16>> property16,
            Expression<Func<TObject, T17>> property17,
            Expression<Func<TObject, T18>> property18,
            Expression<Func<TObject, T19>> property19,
            Expression<Func<TObject, T20>> property20,
            params (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)[] records)
        {
            var propertyInfo1 = GetPropertyInfo(property1);
            var propertyInfo2 = GetPropertyInfo(property2);
            var propertyInfo3 = GetPropertyInfo(property3);
            var propertyInfo4 = GetPropertyInfo(property4);
            var propertyInfo5 = GetPropertyInfo(property5);
            var propertyInfo6 = GetPropertyInfo(property6);
            var propertyInfo7 = GetPropertyInfo(property7);
            var propertyInfo8 = GetPropertyInfo(property8);
            var propertyInfo9 = GetPropertyInfo(property9);
            var propertyInfo10 = GetPropertyInfo(property10);
            var propertyInfo11 = GetPropertyInfo(property11);
            var propertyInfo12 = GetPropertyInfo(property12);
            var propertyInfo13 = GetPropertyInfo(property13);
            var propertyInfo14 = GetPropertyInfo(property14);
            var propertyInfo15 = GetPropertyInfo(property15);
            var propertyInfo16 = GetPropertyInfo(property16);
            var propertyInfo17 = GetPropertyInfo(property17);
            var propertyInfo18 = GetPropertyInfo(property18);
            var propertyInfo19 = GetPropertyInfo(property19);
            var propertyInfo20 = GetPropertyInfo(property20);

            foreach (var record in records)
            {
                var newObject = new TObject();
                propertyInfo1.SetValue(newObject, record.Item1);
                propertyInfo2.SetValue(newObject, record.Item2);
                propertyInfo3.SetValue(newObject, record.Item3);
                propertyInfo4.SetValue(newObject, record.Item4);
                propertyInfo5.SetValue(newObject, record.Item5);
                propertyInfo6.SetValue(newObject, record.Item6);
                propertyInfo7.SetValue(newObject, record.Item7);
                propertyInfo8.SetValue(newObject, record.Item8);
                propertyInfo9.SetValue(newObject, record.Item9);
                propertyInfo10.SetValue(newObject, record.Item10);
                propertyInfo11.SetValue(newObject, record.Item11);
                propertyInfo12.SetValue(newObject, record.Item12);
                propertyInfo13.SetValue(newObject, record.Item13);
                propertyInfo14.SetValue(newObject, record.Item14);
                propertyInfo15.SetValue(newObject, record.Item15);
                propertyInfo16.SetValue(newObject, record.Item16);
                propertyInfo17.SetValue(newObject, record.Item17);
                propertyInfo18.SetValue(newObject, record.Item18);
                propertyInfo19.SetValue(newObject, record.Item19);
                propertyInfo20.SetValue(newObject, record.Item20);
                _internalList.Add(newObject);
            }
        }
    }

}