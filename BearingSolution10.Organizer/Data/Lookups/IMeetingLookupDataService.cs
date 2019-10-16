﻿using BearingSolution10.Organizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BearingSolution10.Organizer.Data.Lookups
{
    public interface IMeetingLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetMeetingLookupAsync();
    }
}