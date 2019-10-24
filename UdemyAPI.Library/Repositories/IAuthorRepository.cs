using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Repositories
{
    public interface IAuthorRepository
    {
        tag GetAuthor(int auhtorId);
        List<tag> getAuthors();
        void Add(tag author);
        void Update(tag author);
        void Delete(tag author);

    }
}
