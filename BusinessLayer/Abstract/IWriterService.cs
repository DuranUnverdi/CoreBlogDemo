﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface IWriterService
    {
        void AddWriter(Writer writer);
    }
}
