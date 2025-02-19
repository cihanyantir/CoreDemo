﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity_Framework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public int GetWriterID(string useridentity)
        {
            using (var c = new Context())
            {
                return c.Writers.Where(x => x.WriterMail == useridentity).Select(y => y.WriterID).FirstOrDefault();

            }
          
        }
    }
}
