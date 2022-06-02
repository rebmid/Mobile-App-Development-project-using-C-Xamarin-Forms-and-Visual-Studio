using System;
using System.Collections.Generic;
using SQLite;
using C971app.Models;

namespace C971app.Services
{
    internal class MockDataFactory
    {
        public static void GenerateSampleMockData(int termId)
        {
            Term term = new Term()
            {
                Name = $"Term {termId}",
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddMonths(3)
            };
            using (SQLiteConnection connection = new SQLiteConnection(App.FilePath))
            {
                connection.Insert(term);
            }

            Course course = new Course()
            {
                Name = $"Test Course 1",
                TermId = term.Id,
                Status = "Anticipate To Take",
                StartDate = DateTime.Today.AddDays(3),
                EndDate = DateTime.Today.AddDays(6),
                InstructorName = "Rebekah Midkiff",
                InstructorEmail = "rmidkif@wgu.edu",
                InstructorPhone = "425-555-5555",
                Note = $"Welcome to your Test Course 1."
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.FilePath))
            {
                connection.Insert(course);
            }

            Assessment performanceAssessment = new Assessment()
            {
                Name = "PAG1",
                CourseId = course.Id,
                StartDate = DateTime.Today.AddDays(3),
                EndDate = DateTime.Today.AddDays(3).AddHours(2.5),
                Type = "Performance"
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.FilePath))
            {
                connection.Insert(performanceAssessment);
            }

            Assessment objectiveAssessment = new Assessment()
            {
                Name = "OBJ1",
                CourseId = course.Id,
                StartDate = DateTime.Today.AddDays(2),
                EndDate = DateTime.Today.AddDays(2).AddHours(2.5),
                Type = "Objective"
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.FilePath))
            {
                connection.Insert(objectiveAssessment);
            }
        }
    }
}
