using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Services
{
    public interface ICourseService
    {
        Tag GetSingleCourse(int tagId);
        List<Tag> GetAllCourses();
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
        List<Course> GetAllTagsOfACourse(int courseId);
    }
}
