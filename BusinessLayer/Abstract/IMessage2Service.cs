using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
  public  interface IMessage2Service:IGenericService<Message2>
    {
        List<Message2> GetInBoxWriter(int id);
    }
}
