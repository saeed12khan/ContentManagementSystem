using System.Collections.Generic;
using Nettex.Core.Entities;

namespace Nettex.Service
{
    public interface IMediaStorageService
    {
        MediaStorage GetById(int? id);
        string GetPictureUrl(int? id);
        bool Save(MediaStorage media);
        bool Delete(int id);

        IEnumerable<MediaStorage> GetByEntity(string entityId, string entityName);
    }
}