using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Services
{
    public interface IAuthorService
    {
        Tag GetSingleAuthor(int tagId);
        List<Tag> GetAllAuthors();
        void AddAuthor(tag Author);
        void UpdateAuthor(tag Author);
        void DeleteAuthor(tag Author);
    }
}
