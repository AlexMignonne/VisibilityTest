﻿using System;

namespace CommonLibrary.Message
{
    public abstract class Message
    {
        protected Message()
        {
            MessageType = GetType().Name;
            DateCreated = DateTime.UtcNow;
        }

        public DateTime DateCreated { get; }
        public string MessageType { get; }
        public string CorrelationId { get; protected set; }
    }
}
