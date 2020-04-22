using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11_Cherkas_Ivan
{
	public abstract class Person
	{

		public abstract void Work();
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Department { get; set; }
		public Person(string name, string surname, string department)
		{
			Name = name;
			Surname = surname;
			Department = department;
		}

	}
	public class Department
	{
		public string Name;
		public Student Students;
		public Teacher Teachers;
		public HeadOfDepartment HeadOfDepartment;
		public Department(string name)
		{
			Name = name;
		}

	}

	public class Student : Person
	{
		public string Departament { get; set; }
		public Student(string name, string surname, string department) : base(name, surname, department)
		{
			Departament = department;
		}

		public override void Work() => Console.WriteLine($"Меня зовут {Name} {Surname}.Я студент факультета {Departament}");


	}
	public class Teacher : Person
	{
		public string Departament { get; set; }
		public Teacher(string name, string surname, string department) : base(name, surname, department)
		{
			Departament = department;
		}

		public override void Work() => Console.WriteLine($"Меня зовут {Name} {Surname}.Я преподователь факультета {Departament}");
	}
	public class HeadOfDepartment : Person
	{
		public string Departament { get; set; }
		public HeadOfDepartment(string name, string surname, string department) : base(name, surname, department)
		{
			Departament = department;
		}

		public override void Work() => Console.WriteLine($"Меня зовут {Name} {Surname}.Я декан факультета {Departament}");
		public override bool Equals(object obj)
		{
			if (obj.GetType() != GetType()) return false;

			Person person = (Person)obj;
			return Name == person.Name;
		}
		class Program
		{
			static void Main(string[] args)
			{
				Student student1 = new Student("Андрей", "Козлов", "Информатики");
				student1 = new Student("Ольга", "Васильева", "менеджмента");
				Teacher teacher1 = new Teacher("Иван", "Рудный", "Информатики");
				teacher1 = new Teacher("Олег", "Ерофеев", "менеджмента");
				HeadOfDepartment headOfDepartment = new HeadOfDepartment("Андрей", "Козлов", "менеджмента");
				var equals = headOfDepartment.Equals(student1);

				Person[] person = new Person[5];
				person[0] = student1;
				person[1] = student1;
				person[2] = teacher1;
				person[3] = teacher1;
				person[4] = headOfDepartment;

				for (int i = 0; i < person.Length; i++)
				{
					person[i].Work();
					Console.WriteLine();
				}
				
			}
		}
	}
}

