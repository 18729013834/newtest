using MetaShare.Common.Core.Daos;
using transform.Entities.src;
using transform.Daos.Interfaces.src;
using transform.TestData.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.Mocks.src
{
	public class Student1DaoMock : MockDao<Student1>, IStudent1Dao
	{
		public Student1DaoMock() : base(Student1TestData.CreateStudent1())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
