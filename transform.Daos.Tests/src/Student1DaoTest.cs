using System.Collections.Generic;
using NUnit.Framework;
using System;
using transform.Daos.Interfaces.src;
using transform.Daos.DataSchema.src;
using transform.TestData.src;
using transform.Daos.Tests.Common;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.Tests.src
{
	public class Student1DaoTest : CommonDaoTest<Student1, IStudent1Dao, Student1DdlBuilder>
	{
		public Student1DaoTest() : base(Student1TestData.CreateStudent1())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(Student1TestData.Student1Count, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Student1 item = Student1TestData.CreateStudent11();
			Student1 find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			Student1TestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			Student1 item = new Student1
			{
				StudentNUM = 0, 
				Description = string.Empty, 
				Name = string.Empty, 
				StudentName = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			Student1 find = this.Dao.SelectById(this.Context, item);
			Student1TestData.AssertAreEqual(item, find);

			List<Student1> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(Student1TestData.Student1Count + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			Student1 item = Student1TestData.CreateStudent11();
			Student1 beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.StudentNUM = 0;

			this.Dao.Update(this.Context, beforeUpdate);

			Student1 afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			Student1TestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			Student1 item = Student1TestData.CreateStudent11();
			Student1 beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			Student1 afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<Student1> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(Student1TestData.Student1Count - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
