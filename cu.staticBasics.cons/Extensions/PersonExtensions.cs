using cu.staticBasics.cons.Entities;

namespace cu.staticBasics.cons.Extensions;

public static class PersonExtensions
{
    public static string GetPrefix(this Person person)
    {
        //get the honorifics Mr or Ms or Mdm or They or Them or Dr
        return person.Name.Split(" ")[0];
    }

    public static int GetAge(this Person person)
    {
        return DateTime.Now.Year - person.YearOfBirth.Year;
    }

    public static int GetId(this Person person)
    {
        return person.Id;
    }
}