using System;
using System.Data;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Domain.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (_articleCategoryRepository.Exists(title))
               // throw new Exception();
                throw new DuplicateNameException($"{title} Already Exists in Database");
        }
    }
}