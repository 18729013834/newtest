using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using transform.Daos.Interfaces.src;
using transform.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace transform.Daos.src
{
	public class courseDao : CommonObjectDao<course>, IcourseDao
	{
		public class courseSqlBuilder : ObjectSqlBuilder
		{
			public courseSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"course")
			{
				this.SqlInsert = "INSERT INTO course (CourseName,CourseNumber," + this.SqlBaseFieldInsertFront + ") VALUES (@CourseName,@CourseNumber," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE course SET CourseName=@CourseName,CourseNumber=@CourseNumber," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class courseResultHandler : CommonObjectResultHandler<course>
		{
			public override void GetColumnValues(IDataReader reader, course item)
			{
				base.GetColumnValues(reader, item);
				int ordinalCourseNumber = reader.GetOrdinal("CourseNumber");
				item.CourseNumber = reader.IsDBNull(ordinalCourseNumber) ? 0 : reader.GetInt32(ordinalCourseNumber);
				int ordinalCourseName = reader.GetOrdinal("CourseName");
				item.CourseName = reader.IsDBNull(ordinalCourseName) ? null : reader.GetString(ordinalCourseName);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, course item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "CourseNumber", item.CourseNumber);
				context.AddParameter(command, "CourseName", item.CourseName ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public courseDao(SqlDialect sqlDialect) : base(new courseSqlBuilder(sqlDialect), new courseResultHandler())
		{
		}

		public courseDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new courseSqlBuilder(sqlDialect), new courseResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
