using System;
using System.Collections.Generic;
using UdemyAPI.Core;
using UdemyAPI.Library.Repositories;

namespace UdemyAPI.Library.Services
{
    public class TagService : ITagService
    {
        //private IUdemyUnitOfWork _unitOfWork;
        private IUdemyUnitOfWork _udemyUnitOfWork;
        public TagService(IUdemyUnitOfWork udemyUnitOfWork)
        {
            _udemyUnitOfWork = udemyUnitOfWork;
        }

        public void AddTag(Tag tag)
        {
            _udemyUnitOfWork.TagRepository.Add(tag);
        }

        public void DeleteTag(Tag tag)
        {
            _udemyUnitOfWork.TagRepository.Delete(tag);
        }

        public List<Tag> GetAllTags()
        {
            return _udemyUnitOfWork.TagRepository.GetTags();
        }

        public Tag GetSingleTag(int tagId)
        {
            return _udemyUnitOfWork.TagRepository.GetTag(tagId);
        }

        public void UpdateTag(Tag tag)
        {
            _udemyUnitOfWork.TagRepository.Update(tag);
            _udemyUnitOfWork.Completed();
        }
    }
}
