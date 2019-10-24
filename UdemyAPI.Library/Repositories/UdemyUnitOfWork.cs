using System;
using Microsoft.EntityFrameworkCore;
using UdemyAPI.Library;

namespace UdemyAPI.Library.Repositories
{
    public class UdemyUnitOfWork : IUdemyUnitOfWork
    {
        public IAuthorRepository AuthorRepository { get; private set; }
        public ICourseRepository CourseRepository { get; private set; }
        public ITagRepository TagRepository { get; private set; }
        private UdmeyContext _context;

        public UdemyUnitOfWork(string connection, string migrationAssemblyName)
        {
            _context = new UdmeyContext(connection, migrationAssemblyName);
            AuthorRepository = new AuthorRepository(_context);
            CourseRepository = new CourseRepository(_context);
            TagRepository = new TagRepository(_context);
        }

        public void Completed()
        {
            _context.SaveChanges();
        }
    }
}
