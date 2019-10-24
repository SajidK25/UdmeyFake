using System;
using System.Collections.Generic;
using UdemyAPI.Core;
using UdemyAPI.Library.Repositories;

namespace UdemyAPI.Library.Services
{
    public class CourseService : ICourseService
    {
        private IUdemyUnitOfWork _unitOfWork;
        public CourseService(IUdemyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddCourse(Course course)
        {
            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Completed();
            var tagIds = new List<int>() { 1, 2, 3 };
            foreach (var tagId in tagIds)
            {
                var courseTags = new List<CourseTag>();

                var courseTag = new CourseTag
                {
                    CourseId = course.Id,
                    TagId = tagId
                };

                courseTags.Add(courseTag);
                _unitOfWork.CourseRepository.AddToCourseTag(courseTags);
            }

            //_unitOfWork.Completed();
        }
        public List<Course> GetAllTagsOfACourse(int courseId)
        {
            return _unitOfWork.CourseRepository.GetAllCourseTags(courseId);
        }
        public void DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Tag GetSingleCourse(int tagId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }


    }
}
