using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Repositories
{
    public interface ITagRepository
    {
        Tag GetTag(int tagId);
        List<Tag> GetTags();
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(Tag tag);
    }
}
