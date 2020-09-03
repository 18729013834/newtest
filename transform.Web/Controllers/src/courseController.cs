using System.Collections.Generic;
using transform.Services.Interfaces.src;
using transform.Entities.src;
using transform.Web.Models.src;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using transform.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Web.Controllers.src
{
	public class courseController:CommonController<course, IcourseService, courseModel>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "src_course";
		}


		protected override List<course> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<course> lists = this.Service.SelectBy(pagerSearchModel.Pager,new course { Name = pagerSearchModel.Name }, course => course.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
