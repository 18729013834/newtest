using System;
using System.Collections.Generic;
using System.Web.Mvc;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Web.Models.src
{
	public class courseModel: CommonModel<course>
	{
		public int CourseNumber {get; set;}
		public string CourseName {get; set;}

		public override void PopulateFrom(course entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.CourseNumber = entity.CourseNumber;
			this.CourseName = entity.CourseName;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(course entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.CourseNumber = this.CourseNumber;

			entity.CourseName = this.CourseName;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
