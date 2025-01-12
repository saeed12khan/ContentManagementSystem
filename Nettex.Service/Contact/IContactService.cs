using System.Collections.Generic;
using Nettex.Core.Entities;

namespace Nettex.Service
{
    public interface IContactService
    {
        Contact GetById(int Id);
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetDeletedContacts();

        bool Save(Contact contact);
    }
}