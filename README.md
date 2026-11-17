# Clinical Edit Checks in C#

A small .NET 8 console program that applies clinical-trial-style edit checks to patient records:
- Age must be between 18 and 75
- Visit date must not be before consent date

When a value breaks a rule, the program raises a "query", similar to how edit checks work in EDC systems such as Medidata Rave. I built it while learning C# for clinical data programming.

## Run
```bash
dotnet run
```

## Next steps
- Missing-value checks
- Lab-value ranges
- Reading records from a CSV file
