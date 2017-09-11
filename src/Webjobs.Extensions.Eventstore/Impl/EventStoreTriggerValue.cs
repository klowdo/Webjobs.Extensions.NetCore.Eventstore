﻿using System.Collections.Generic;
using EventStore.ClientAPI;

namespace Webjobs.Extensions.Eventstore.Impl
{
    public class EventStoreTriggerValue
    {
        public IEnumerable<ResolvedEvent> Events { get; }

        public EventStoreTriggerValue(IEnumerable<ResolvedEvent> events)
        {
            Events = events;
        }
    }
}
