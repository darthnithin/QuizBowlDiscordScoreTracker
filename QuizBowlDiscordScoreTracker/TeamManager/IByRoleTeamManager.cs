﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBowlDiscordScoreTracker.TeamManager
{
    interface IByRoleTeamManager
    {
        public void ReloadTeamRoles(out string message);
    }
}
