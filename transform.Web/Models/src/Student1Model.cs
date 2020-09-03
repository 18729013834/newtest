using System;
using System.Collections.Generic;
using System.Web.Mvc;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Web.Models.src
{
	public class Student1Model: CommonModel<Student1>
	{
		public int StudentNUM {get; set;}
		public string StudentName {get; set;}

		public override void PopulateFrom(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.StudentNUM = entity.StudentNUM;
			this.StudentName = entity.StudentName;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.StudentNUM = this.StudentNUM;

			entity.StudentName = this.StudentName;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
