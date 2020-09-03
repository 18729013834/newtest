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
	public class courseService : Service<course>, IcourseService
	{
		public courseService() : base(typeof (IcourseDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
