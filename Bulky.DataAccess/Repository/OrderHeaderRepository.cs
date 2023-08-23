﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if (orderFromDb == null) 
                return;

            orderFromDb.OrderStatus = orderStatus;
            if (string.IsNullOrEmpty(paymentStatus))
            {
                orderFromDb.PaymentStatus = paymentStatus;
            }
        }

        public void UpdateStripePaymentId(int id, string sessionId, string stripePaymentId)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);

            if (orderFromDb == null) 
                return;

            if (!string.IsNullOrEmpty(sessionId))
            {
                orderFromDb.SessionId = sessionId;
            }

            if (!string.IsNullOrEmpty(stripePaymentId))
            {
                orderFromDb.PaymentIntentId = stripePaymentId;
                orderFromDb.PaymentDate = DateTime.Now;
            }
        }
    }
}