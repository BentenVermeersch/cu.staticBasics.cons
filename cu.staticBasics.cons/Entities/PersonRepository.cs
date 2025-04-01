namespace cu.staticBasics.cons.Entities;

public class PersonRepository
{
    public IEnumerable<Person> GetPersons()
    {
        return new List<Person>()
        {
            new Person()
            {
                Id = 1,
                Name = "Mr John",
                YearOfBirth = new DateTime(1980, 1, 1)
            },
            new Person()
            {
                Id = 2,
                Name = "Them Arne",
                YearOfBirth = new DateTime(2000, 11, 30)
            },
            new Person()
            {
                Id = 3,
                Name = "Dr Jeffrey",
                YearOfBirth = new DateTime(1998, 5, 22)
            },
            new Person()
            {
                Id = 4,
                Name = "Mdm Danielle",
                YearOfBirth = new DateTime(2001, 9, 17)
            },
        };
    }
}