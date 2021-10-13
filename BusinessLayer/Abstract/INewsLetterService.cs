using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsletter);
    }
}
