using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using RijlesPlanner.Data.Connection;
using RijlesPlanner.Interface;
using RijlesPlanner.Interface.Interfaces.Lesson;

namespace RijlesPlanner.Data.Dal
{
    public class LessonDal : ILessonDal, ILessonContainerDal
    {
        public void Update(LessonDto lessonDto)
        {
            throw new System.NotImplementedException();
        }

        public List<LessonDto> GetAllLessons()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                var query = "SELECT * FROM [dbo].[Lessons]";

                return connection.Query<LessonDto>(query).ToList();
            }
        }

        public List<LessonDto> GetLessonsByUserId(Guid userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                var parameters = new { Id = userId };
                var query = "SELECT * FROM [dbo].[Lessons] WHERE Id = @Id";

                return connection.Query<LessonDto>(query, parameters).ToList();
            }
        }

        public int CreateNewLesson(LessonDto lessonDto)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.GetConnectionString()))
            {
                var parameters = new { Title = lessonDto.Title, Description = lessonDto.Description, StartDate = lessonDto.StartDate, EndDate = lessonDto.EndDate };
                var query = "INSERT INTO [dbo].[Lessons](Title, Description, StartDate, EndDate) VALUES (@Title, @Description, @StartDate, @EndDate)";

                connection.Query(query, parameters);

                return 1;
            }
        }
    }
}