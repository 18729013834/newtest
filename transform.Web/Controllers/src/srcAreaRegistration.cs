using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Web.Controllers.src
{
	public class srcAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"src",
			"src/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"transform.Web.Controllers.src"});
		}

		public override string AreaName
		{
			get { return "src"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
