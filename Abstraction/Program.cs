using Abstraction;

Employee employee1 = new Manager 
{ 
    Name = "Ajda", 
    LastName = "Pekkan", 
    Department = "Management" 
};

Employee employee2 = new Developer
{
    Name = "Cem",
    LastName = "Yılmaz",
    Department = "Development"
};

Employee employee3 = new Designer
{
    Name = "Banu",
    LastName = "Alkan",
    Department = "Design"
};

Employee employee4 = new SalesOfficer
{
    Name = "Hadise",
    LastName = "Dümtektek",
    Department = "Sales"
};

employee1.Introduce();
employee1.Work();
employee2.Introduce();
employee2.Work();
employee3.Introduce();
employee3.Work();
employee4.Introduce();
employee4.Work();