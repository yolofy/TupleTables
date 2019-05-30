# Tuple Tables
Initialize a large collection of objects in a more readable way.

[![NuGet](https://img.shields.io/nuget/dt/Yolofy.TupleTables.svg?style=for-the-badge)](https://www.nuget.org/packages/simpleinjector)

## Example usage
```cs
 var table = TupleTable<Person>.Create
                  (p => p.Id,           p2 => p2.Name,  p3 => p3.Age,   p4 => p4.Gender,
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
```

## Why?
Often in unit tests, there is a lot of data being initialized. The default for many developers is to use object initializers. But this quickly produces a hard to read piece of code:
```cs
var list = new List<Person>
                       {
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Xumina",
                               Age    = 15,
                               Gender = Gender.Female
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Bale",
                               Age    = 26,
                               Gender = Gender.Male
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Robin",
                               Age    = 30,
                               Gender = Gender.Neutral
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Adama",
                               Age    = 25,
                               Gender = Gender.Female
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Theodore",
                               Age    = 43,
                               Gender = Gender.Male
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Georgios",
                               Age    = 82,
                               Gender = Gender.Male
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Anastasia",
                               Age    = 14,
                               Gender = Gender.Female
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "William",
                               Age    = 39,
                               Gender = Gender.Male
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Yuina",
                               Age    = 55,
                               Gender = Gender.Female
                           },
                           new Person
                           {
                               Id     = Guid.NewGuid(),
                               Name   = "Eden",
                               Age    = 62,
                               Gender = Gender.Neutral
                           }
                       };
```

## Why not use the constructor?
The constructor isn't always available (e.g. not provided by a third party library). When it is, it forces you to provide every field in the constructor, in the right order.

```cs
 var list = List<Person>{
                  new Person(Guid.NewGuid(),      "Xumina",       15,    Gender.Female),
                  new Person(Guid.NewGuid(),      "Bale",         26,    Gender.Male),
                  new Person(Guid.NewGuid(),      "Robin",        30,    Gender.Neutral),
                  new Person(Guid.NewGuid(),      "Adama",        25,    Gender.Female),
                  new Person(Guid.NewGuid(),      "Theodore",     43,    Gender.Male),
                  new Person(Guid.NewGuid(),      "Georgios",     82,    Gender.Male),
                  new Person(Guid.NewGuid(),      "Anastasia",    14,    Gender.Female),
                  new Person(Guid.NewGuid(),      "William",      39,    Gender.Male),
                  new Person(Guid.NewGuid(),      "Yuina",        55,    Gender.Female),
                  new Person(Guid.NewGuid(),      "Eden",         62,    Gender.Neutral)};
```

## Why not use a (helper / collection initializer) method
You need to write one for every type, and it forces you to provide every field in the method, in the right order.

```cs
static class PersonExtensions
{
   public static void Add(this ICollection<Person> l, Guid id, String name, Int age, Gender gender)
     => l.Add(new Person { Id = id, Name = name, Age = age, Gender = gender });
}

var table = Table = new List<Person>
        {
            { Guid.NewGuid(),      "Xumina",       15,    Gender.Female},
            { Guid.NewGuid(),      "Bale",         26,    Gender.Male},
            { Guid.NewGuid(),      "Robin",        30,    Gender.Neutral},
            { Guid.NewGuid(),      "Adama",        25,    Gender.Female},
            { Guid.NewGuid(),      "Theodore",     43,    Gender.Male},
            { Guid.NewGuid(),      "Georgios",     82,    Gender.Male},
            { Guid.NewGuid(),      "Anastasia",    14,    Gender.Female},
            { Guid.NewGuid(),      "William",      39,    Gender.Male},
            { Guid.NewGuid(),      "Yuina",        55,    Gender.Female},
            { Guid.NewGuid(),      "Eden",         62,    Gender.Neutral}
        };
```
