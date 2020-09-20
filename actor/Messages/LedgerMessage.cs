using System;
using System.Collections.Generic;

namespace actor.Messages
{
    public class LedgerMessage
    {
        public MessageType MessageType { get; private set; }
        public Guid Id { get; private set; }
        public DateTime Timestamp { get; private set; }
        public DateTime TargetDate { get; private set; }
        public Terminal Terminal { get; private set; }
        public double LeadTime { get; private set; }
        public IEnumerable<PrimitiveTransaction> Steps { get; private set; }
        public string Notes { get; private set; }
    }

    public enum MessageType
    {
        AddCash,
        SwapCash,
        EmptyCash,
        ReturnCash

    }
}