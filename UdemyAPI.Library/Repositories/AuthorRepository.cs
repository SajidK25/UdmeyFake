using System;
using System.Collections.Generic;
using UdemyAPI.Core;

namespace UdemyAPI.Library.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        UdmeyContext _udmeyContext;
        public AuthorRepository(UdmeyContext udmeyContext)
        {
            _udmeyContext = udmeyContext;
        }

        public void Add(tag author)
        {
            throw new NotImplementedException();
        }

        public void Delete(tag author)
        {
            throw new NotImplementedException();
        }

        public tag GetAuthor(int auhtorId)
        {
            throw new NotImplementedException();
        }

        public List<tag> getAuthors()
        {
            throw new NotImplementedException();
        }

        public void Update(tag author)
        {
            throw new NotImplementedException();
        }
    }
}
