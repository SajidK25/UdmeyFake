using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Repositories
{
    public interface ICourseRepository
    {
        Course GetCourse(int courseId);
        List<Course> GetCourses();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        void AddToCourseTag(List<CourseTag> courseTags);
        List<Course> GetAllCourseTags(int courseId);
    }
}
