﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface ITicketConfirmer
    {
        ScannedStatus ConfirmArrival(ScannedTicket scannedTicket,  bool forceUpdate = false);
    }
}
