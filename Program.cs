// Simple clinical "edit checks", the kind of rules Rave custom functions enforce
var patients = new[]
{
    new { Id = "P001", Age = 45,  ConsentDate = new DateTime(2026, 3, 1), VisitDate = new DateTime(2026, 3, 10) },
    new { Id = "P002", Age = 82,  ConsentDate = new DateTime(2026, 3, 5), VisitDate = new DateTime(2026, 3, 2)  },
    new { Id = "P003", Age = 17,  ConsentDate = new DateTime(2026, 4, 1), VisitDate = new DateTime(2026, 4, 3)  },
};

foreach (var p in patients)
{
    bool ok = true;

    if (p.Age < 18 || p.Age > 75)
    {
        Console.WriteLine($"{p.Id}: QUERY - age {p.Age} is outside 18-75");
        ok = false;
    }
    if (p.VisitDate < p.ConsentDate)
    {
        Console.WriteLine($"{p.Id}: QUERY - visit date is before consent date");
        ok = false;
    }
    if (ok) Console.WriteLine($"{p.Id}: passed all checks");
}