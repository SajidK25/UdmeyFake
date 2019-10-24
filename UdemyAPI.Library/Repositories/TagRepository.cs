using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UdemyAPI.Core;

namespace UdemyAPI.Library.Repositories
{
    public class TagRepository : ITagRepository
    {
        UdmeyContext _udmeyContext;
        public TagRepository(UdmeyContext udmeyContext)
        {
            _udmeyContext = udmeyContext;
        }

        public void Add(Tag tag)
        {
            _udmeyContext.Tags.Add(tag);
            _udmeyContext.SaveChanges();
        }

        public void Delete(Tag tag)
        {
            _udmeyContext.Tags.Remove(tag);
            _udmeyContext.SaveChanges();
        }

        public Tag GetTag(int tagId)
        {
            return _udmeyContext.Tags.Where(t => t.Id == tagId).SingleOrDefault();
        }

        public List<Tag> GetTags()
        {
            return _udmeyContext.Tags.OrderBy(t => t.Id).ToList();
        }

        public void Update(Tag tag)
        {
            _udmeyContext.Tags.Update(tag);
        }
    }
}
