using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace Yolofy.Test
{
    public class TupleTableTest
    {
        private enum Gender
        {
            Neutral,
            Male,
            Female
        }

        private class Person
        {
            public int Field;

            public int Age { get; set; }

            public Gender Gender { get; set; }

            public Guid   Id     { get; set; }

            public string Name { get; set; }

            public string ReadOnlyProperty { get; } = "This property has no setter";
        }

        private int Number { get; set; }

        [Fact]
        public void TupleTable_CreatesAndInitializes_Objects()
        {
            var table = TupleTable<Person>.Create
                  (r => r.Id,           r2 => r2.Name,  r3 => r3.Age,   r4 => r4.Gender,
                  (Guid.NewGuid(),      "Xumina",       15,             Gender.Female),
                  (Guid.NewGuid(),      "Bale",         26,             Gender.Male),
                  (Guid.NewGuid(),      "Robin",        30,             Gender.Neutral),
                  (Guid.NewGuid(),      "Adama",        25,             Gender.Female),
                  (Guid.NewGuid(),      "Theodore",     43,             Gender.Male),
                  (Guid.NewGuid(),      "Georgios",     82,             Gender.Male),
                  (Guid.NewGuid(),      "Anastasia",    14,             Gender.Female),
                  (Guid.NewGuid(),      "William",      39,             Gender.Male),
                  (Guid.NewGuid(),      "Yuina",        55,             Gender.Female),
                  (Guid.NewGuid(),      "Eden",         62,             Gender.Neutral));

            var array = table.ToArray();

            foreach (var record in array)
            {
                Assert.NotEqual(default, record.Id);
            }

            Assert.Equal("Xumina",       array[0].Name);
            Assert.Equal(15,             array[0].Age);
            Assert.Equal(Gender.Female,  array[0].Gender);

            Assert.Equal("Bale",         array[1].Name);
            Assert.Equal(26,             array[1].Age);
            Assert.Equal(Gender.Male,    array[1].Gender);

            Assert.Equal("Robin",        array[2].Name);
            Assert.Equal(30,             array[2].Age);
            Assert.Equal(Gender.Neutral, array[2].Gender);

            Assert.Equal("Adama",        array[3].Name);
            Assert.Equal(25,             array[3].Age);
            Assert.Equal(Gender.Female,  array[3].Gender);

            Assert.Equal("Theodore",     array[4].Name);
            Assert.Equal(43,             array[4].Age);
            Assert.Equal(Gender.Male,    array[4].Gender);

            Assert.Equal("Georgios",     array[5].Name);
            Assert.Equal(82,             array[5].Age);
            Assert.Equal(Gender.Male,    array[5].Gender);

            Assert.Equal("Anastasia",    array[6].Name);
            Assert.Equal(14,             array[6].Age);
            Assert.Equal(Gender.Female,  array[6].Gender);

            Assert.Equal("William",      array[7].Name);
            Assert.Equal(39,             array[7].Age);
            Assert.Equal(Gender.Male,    array[7].Gender);

            Assert.Equal("Yuina",        array[8].Name);
            Assert.Equal(55,             array[8].Age);
            Assert.Equal(Gender.Female,  array[8].Gender);

            Assert.Equal("Eden",         array[9].Name);
            Assert.Equal(62,             array[9].Age);
            Assert.Equal(Gender.Neutral, array[9].Gender);
        }

        [Fact]
        public void TupleTable_SelectingAMethod_ThrowsArgumentException()
        {
            void Test()
            {
                var table = TupleTable<Person>.Create
                  (r => r.Id,           r2 => r2.ToString(),  r3 => r3.Age,   r4 => r4.Gender,
                  (Guid.NewGuid(),      "Xumina",             15,             Gender.Female)).ToArray();
            }

            Assert.Throws<ArgumentException>("property", Test);
        }

        [Fact]
        public void TupleTable_SelectingAField_ThrowsArgumentException()
        {
            void Test()
            {
                var table = TupleTable<Person>.Create
                  (r => r.Id,           r2 => r2.Name,  r3 => r3.Field,   r4 => r4.Gender,
                  (Guid.NewGuid(),      "Xumina",       15,               Gender.Female));
                var array = table.ToArray();
            }

            Assert.Throws<ArgumentException>("property", Test);
        }

        [Fact]
        public void TupleTable_ReadonlyProperty_ThrowsArgumentException()
        {
            void Test()
            {
                var table = TupleTable<Person>.Create
                  (r => r.Id,           r2 => r2.ReadOnlyProperty,  r3 => r3.Age,   r4 => r4.Gender,
                  (Guid.NewGuid(),      "Xumina",                   15,             Gender.Female));
                var array = table.ToArray();
            }

            Assert.Throws<ArgumentException>("property", Test);
        }

        [Fact]
        public void TupleTable_UnrelatedProperty_ThrowsArgumentException()
        {
            void Test()
            {
                var table = TupleTable<Person>.Create
                  (r => r.Id,           r2 => r2.ReadOnlyProperty,  r3 => this.Number,   r4 => r4.Gender,
                  (Guid.NewGuid(),      "Xumina",                   15,                  Gender.Female));
                var array = table.ToArray();
            }

            Assert.Throws<ArgumentException>("property", Test);
        }
    }
}