using System;
using System.Collections.Generic;
using NUnit.Framework;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.TestData.src
{
	public class Student1TestData
	{
		public const int Student1Count = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<Student1> CreateStudent1()
		{
			return new List<Student1>
			{
				CreateStudent11(),
				CreateStudent12(),
				CreateStudent13(),
			};
		}

		 public static Student1 CreateStudent11()
		{
			return new Student1
			{
					Id = 1, 
					StudentNUM = 0, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentName = string.Empty, 
			};
		}
		 public static Student1 CreateStudent12()
		{
			return new Student1
			{
					Id = 2, 
					StudentNUM = 0, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentName = string.Empty, 
			};
		}
		 public static Student1 CreateStudent13()
		{
			return new Student1
			{
					Id = 3, 
					StudentNUM = 0, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentName = string.Empty, 
			};
		}
		public static void AssertAreEqual(Student1 expected, Student1 actual)
		{
			Assert.AreEqual(expected.StudentNUM, actual.StudentNUM);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.StudentName, actual.StudentName);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
