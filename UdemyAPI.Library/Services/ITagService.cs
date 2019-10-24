using System;
using System.Collections.Generic;
using UdemyAPI.Core;
namespace UdemyAPI.Library.Services
{
    public interface ITagService
    {
        Tag GetSingleTag(int tagId);
        List<Tag> GetAllTags();
        void AddTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Tag tag);
    }
}
