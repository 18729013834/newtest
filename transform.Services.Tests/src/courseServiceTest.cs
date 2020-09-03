using System;
using System.Collections.Generic;
using NUnit.Framework;
using transform.Entities.src;
using transform.TestData.src;
using transform.Services.Tests.Common;
using transform.Services.Interfaces.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Services.Tests.src
{

	[TestFixture]
	public class courseServiceTest : CommonServiceTest<course, IcourseService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(courseTestData.courseCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			course itemTest = courseTestData.Createcourse1();

			List<course> find = this.Service.SelectBy(new course {CourseNumber = itemTest.CourseNumber}, new List<string> {"CourseNumber"});
			Assert.IsNotNull(find);

			foreach (course item in find)
			{
				Assert.AreEqual(itemTest.CourseNumber, item.CourseNumber);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			course itemTest = courseTestData.Createcourse1();

			course find = this.Service.SelectById(new course {Id = itemTest.Id});
			Assert.IsNotNull(find);

			courseTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			course itemTest = courseTestData.Createcourse2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, courseTestData.courseCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			course itemTest = new course
			{
				CourseNumber = 0, 
				CourseName = string.Empty, 
				Name = string.Empty, 
				Description = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, courseTestData.courseCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			course itemTest = courseTestData.Createcourse1();

			course beforeUpdate = this.Service.SelectById(new course {Id = itemTest.Id});
			beforeUpdate.CourseNumber = 0 ;
			this.Service.Update(beforeUpdate, true);

			course afterUpdate = this.Service.SelectById(new course {Id = itemTest.Id});
			courseTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
