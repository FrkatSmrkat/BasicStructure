﻿using BasicStructure.Data.Models.Users;

namespace BasicStructure.Data.Models.Orders
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentCard PaymentCard { get; set; }

        //TOFO: maybe?
        //public ApplicationUser User { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public DateTime CanceledAt { get; set; }
        public Order Order { get; set; }
    }
}
