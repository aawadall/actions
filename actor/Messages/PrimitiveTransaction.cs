using System;
using System.Collections.Generic;

namespace actor.Messages
{
    public class PrimitiveTransaction
    {
        public Guid Id { get; private set; }
        public Double Amount { get; private set; }
        public Currency Currency { get; private set; }
        public Account FromAccount { get; private set; }
        public IEnumerable<Account> ToAccounts { get; private set; }
        public DateTime EffectiveDate { get; private set; }
        public IEnumerable<Denomination> Denominations { get; private set; }
    }
}