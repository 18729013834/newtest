using System;
using System.Collections.Generic;
using NUnit.Framework;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.TestData.src
{
	public class courseTestData
	{
		public const int courseCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<course> Createcourse()
		{
			return new List<course>
			{
				Createcourse1(),
				Createcourse2(),
				Createcourse3(),
			};
		}

		 public static course Createcourse1()
		{
			return new course
			{
					Id = 1, 
					CourseNumber = 0, 
					CourseName = string.Empty, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static course Createcourse2()
		{
			return new course
			{
					Id = 2, 
					CourseNumber = 0, 
					CourseName = string.Empty, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static course Createcourse3()
		{
			return new course
			{
					Id = 3, 
					CourseNumber = 0, 
					CourseName = string.Empty, 
					Name = string.Empty, 
					Description = string.Empty, 
			};
		}
		public static void AssertAreEqual(course expected, course actual)
		{
			Assert.AreEqual(expected.CourseNumber, actual.CourseNumber);
			Assert.AreEqual(expected.CourseName, actual.CourseName);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.Description, actual.Description);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
