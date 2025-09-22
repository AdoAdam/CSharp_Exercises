
Person person = new()
{
    firstName = "Anders",
    lastName = "Andersson"
};
Person person2 = new()
{
    firstName = "Per",
    lastName = "Persson"
};

Console.WriteLine(person.firstName + " " + person.lastName);
Console.WriteLine(person2.firstName + " " + person2.lastName);

Console.WriteLine(person.GetFullName());
Console.WriteLine(person.GetFullName("Mr."));
Console.WriteLine(person.GetFullNameReversed());

// 6.
Person mom = new()
{
    firstName = "Mamma",
    lastName = "Mammsson"
};

Person dad = new();

Person myself = new()
{
    firstName = "Adam",
    lastName = "Adolfsson",
    mother = mom,
    father = dad
};

Console.WriteLine(myself.GetFullName());
Console.WriteLine(myself.mother.GetFullName());

Console.WriteLine(myself.GetSelfAndParents());

person.SetLength(1.82);
Console.WriteLine(person.GetLength());
person.SetWeight(75);

Console.WriteLine(person.GetBMI());


// 1.
public class Person
{
    public string firstName;
    public string lastName;

    private double length;
    private double weight;

    // 5.
    public Person mother;
    public Person father;

    // 2.
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    // 3.
    public string GetFullNameReversed()
    {
        char[] chars = GetFullName().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // 4.
    public string GetFullName(string title)
    {
        return title + " " + firstName + " " + lastName;
    }

    // 7.
    public string GetSelfAndParents()
    {
        string mothersName;
        string fathersName;
        if (!String.IsNullOrEmpty(mother.GetFullName())) mothersName = mother.GetFullName();
        else mothersName = "okänd";

        if (String.IsNullOrEmpty(father.GetFullName())) fathersName = father.GetFullName();
        else fathersName = "okänd";

        return GetFullName() + " - Mamma: " + mothersName + " - Pappa: " + fathersName;
    }

    // 8.
    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return length;
    }

    // 9.
    public void SetWeight(int weight)
    {
        this.weight = weight;
    }
    public double GetWeight()
    {
        return weight;
    }

    public double GetBMI()
    {
        return weight / (length * length);
    }
}