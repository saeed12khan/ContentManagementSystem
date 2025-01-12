using System.Collections.Generic;
using Nettex.Core.Entities;

namespace Nettex.Service
{
    public interface IPostTagService
    {
        bool Save( string tagName);
        bool Delete(string tagName);

        bool Save(int postId, string tagName);
        bool Delete(int postId, string tagName);

        PostTag GetByName(string tagName);

        IEnumerable<PostTag> GetAllTags();
        IEnumerable<PostTag> GetTagsByPostId(int postId);
    }
}