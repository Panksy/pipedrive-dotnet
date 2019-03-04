﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Stages API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Stages">Stages API documentation</a> for more information.
    public interface IRecentsClient
    {
        Task<IReadOnlyList<Recents>> Get(DateTime sinceWhen);
        Task<IReadOnlyList<Recents>> GetDealRecents(DateTime sinceWhen);
        Task<IReadOnlyList<Recents>> GetActivityRecents(DateTime sinceWhen);
    }
}
