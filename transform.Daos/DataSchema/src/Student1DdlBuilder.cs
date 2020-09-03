using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.DataSchema.src
{
	public class Student1DdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE Student1(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,StudentNUM int,Description nvarchar(255),Name nvarchar(255),StudentName nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE Student1";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'Student1'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
