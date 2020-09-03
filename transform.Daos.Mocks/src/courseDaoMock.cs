using MetaShare.Common.Core.Daos;
using transform.Entities.src;
using transform.Daos.Interfaces.src;
using transform.TestData.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.Mocks.src
{
	public class courseDaoMock : MockDao<course>, IcourseDao
	{
		public courseDaoMock() : base(courseTestData.Createcourse())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
