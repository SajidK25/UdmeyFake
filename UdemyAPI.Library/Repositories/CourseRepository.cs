using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UdemyAPI.Core;

namespace UdemyAPI.Library.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        UdmeyContext _udmeyContext;
        public CourseRepository(UdmeyContext udmeyContext)
        {
            _udmeyContext = udmeyContext;
        }

        public void Add(Course course)
        {
            _udmeyContext.Courses.Add(course);
        }

        public void AddToCourseTag(List<CourseTag> courseTags)
        {
            _udmeyContext.CourseTags.AddRange(courseTags);
            _udmeyContext.SaveChanges();
        }

        public void Delete(Course course)
        {
            _udmeyContext.Courses.Remove(course);
        }

        public List<Course> GetAllCourseTags(int courseId)
        {
            var tags = _udmeyContext.Courses.Where(c => c.Id == courseId)
                .Include(ct => ct.Tags)
                .ThenInclude(ct => ct.Tag).ToList();
            return tags;
        }

        public Course GetCourse(int courseId)
        {
            return _udmeyContext.Courses.Where(c => c.Id == courseId).SingleOrDefault();
        }

        public List<Course> GetCourses()
        {
            return _udmeyContext.Courses.OrderBy(c => c.Id).ToList();
        }

        public void Update(Course course)
        {
            _udmeyContext.Courses.Update(course);
        }
    }
}
