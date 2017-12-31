using System;
using LeagueManager.Common;
using System.Collections.Generic;

namespace LeagueManager.Common.Interfaces
{
    public interface IPlayerInterface
    {
        void ChangeHomeAddress(string p_newAddress);
        void ChangeEmail(string p_newEmail);
        void ChangePhone(string p_newPhone);
        void RegisterToLeague(League p_leagueToRegister);
    }
}
