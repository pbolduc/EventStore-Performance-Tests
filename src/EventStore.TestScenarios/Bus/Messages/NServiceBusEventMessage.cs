﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace EventStore.TestScenarios
{
    [Serializable]
   public class NServiceBusEventMessage : SmallEvent, IMessage
    {
    }
}
