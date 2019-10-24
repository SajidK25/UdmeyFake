using System;
namespace UdemyAPI.Library.Repositories
{
    public interface IUdemyUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        ICourseRepository CourseRepository { get; }
        ITagRepository TagRepository { get; }
        void Completed();

    }
}
