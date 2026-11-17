Clinical Edit Checks in C#

A small .NET 8 console program that applies clinical-trial-style edit checks to patient records: an age range (18–75) and visit date must not be before consent date. When a value breaks a rule, it raises a “query,” similar to how edit checks work in EDC systems such as Medidata Rave. I built it while learning C# for clinical data programming. Next: missing-value checks, lab-value ranges, and reading records from a CSV file.

Run: dotnet run
