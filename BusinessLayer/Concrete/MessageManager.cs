﻿//using BusinessLayer.Abstract;
//using DataAccessLayer.Abstract;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer.Concrete
//{
//    public class MessageManager : IMessageService
//    {
//        IMessageDal _msgdAL;

//        public MessageManager(IMessageDal msgdAL)
//        {
//            _msgdAL = msgdAL;
//        }

//        public Message GetById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Message> GetList()
//        {
//            throw new NotImplementedException();
//        }

//        public List<Message> GetInboxListByWriter(string p)
//        {
//            return _msgdAL.GetListAll(x => x.Receiver == p);
//        }

//        public void TAdd(Message t)
//        {
//            throw new NotImplementedException();
//        }

//        public void TDelete(Message t)
//        {
//            throw new NotImplementedException();
//        }

//        public void TUpdate(Message t)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
