using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.WebApi.Controllers.src
{
	public class srcAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"src",
			routeTemplate:"src/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "src",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"transform.WebApi.Controllers.src"}
			});
		}

		public override string AreaName
		{
			get { return "src"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
