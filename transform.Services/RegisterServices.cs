using MetaShare.Common.Core.CommonService;
using transform.Services.Interfaces.src;
using transform.Services.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IStudent1Service), new Student1Service(), isRegister);
			factory.Register(typeof(IcourseService), new courseService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
