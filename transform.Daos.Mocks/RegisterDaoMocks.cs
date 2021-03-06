﻿using MetaShare.Common.Core.Daos;
using transform.Daos.Interfaces.src;
using transform.Daos.Mocks.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IStudent1Dao), new Student1DaoMock(), isRegister);
			factory.Register(typeof(IcourseDao), new courseDaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
