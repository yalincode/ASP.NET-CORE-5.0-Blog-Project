using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        
        IContactDal _contaxtDal;
        public ContactManager(IContactDal contaxtDal)
        {
            _contaxtDal = contaxtDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contaxtDal.Insert(contact);
        }
    }
}
