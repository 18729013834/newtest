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
	public class Student1ServiceTest : CommonServiceTest<Student1, IStudent1Service>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(Student1TestData.Student1Count, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			List<Student1> find = this.Service.SelectBy(new Student1 {StudentNUM = itemTest.StudentNUM}, new List<string> {"StudentNUM"});
			Assert.IsNotNull(find);

			foreach (Student1 item in find)
			{
				Assert.AreEqual(itemTest.StudentNUM, item.StudentNUM);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			Student1 find = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			Assert.IsNotNull(find);

			Student1TestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent12();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, Student1TestData.Student1Count - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			Student1 itemTest = new Student1
			{
				StudentNUM = 0, 
				Description = string.Empty, 
				Name = string.Empty, 
				StudentName = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<Student1> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, Student1TestData.Student1Count + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			Student1 itemTest = Student1TestData.CreateStudent11();

			Student1 beforeUpdate = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			beforeUpdate.StudentNUM = 0 ;
			this.Service.Update(beforeUpdate, true);

			Student1 afterUpdate = this.Service.SelectById(new Student1 {Id = itemTest.Id});
			Student1TestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
