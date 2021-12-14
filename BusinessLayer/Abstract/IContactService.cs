using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface IContactService : IGenericService<Contact>
    {
        void AddContact(Contact contact);
    }
}
