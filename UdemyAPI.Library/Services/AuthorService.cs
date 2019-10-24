using System;
using System.Collections.Generic;
using UdemyAPI.Core;
using UdemyAPI.Library.Repositories;

namespace UdemyAPI.Library.Services
{
    public class AuthorService : IAuthorService
    {
        private IUdemyUnitOfWork _unitOfWork;
        public AuthorService(IUdemyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddAuthor(tag Author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(tag Author)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Tag GetSingleAuthor(int tagId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(tag Author)
        {
            throw new NotImplementedException();
        }
    }
}
