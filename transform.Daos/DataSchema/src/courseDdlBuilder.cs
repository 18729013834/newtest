using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.DataSchema.src
{
	public class courseDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE course(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,CourseNumber int,CourseName nvarchar(255),Name nvarchar(255),Description nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE course";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'course'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
