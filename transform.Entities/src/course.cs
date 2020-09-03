using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Entities.src
{
	public class course : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public int CourseNumber {get; set;}

		[DataMember]
		public string CourseName {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
