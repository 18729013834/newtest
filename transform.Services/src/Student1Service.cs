using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using transform.Entities.src;
using MetaShare.Common.Core.Services;
using transform.Daos.Interfaces.src;
using transform.Services.Interfaces.src;

/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Services.src
{
	public class Student1Service : Service<Student1>, IStudent1Service
	{
		public Student1Service() : base(typeof (IStudent1Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
