using System;
using LeagueManager.Common.Interfaces;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace LeagueManager.Common
{
    public class Player : IPlayerInterface
    {
        //Variables
        public static List<Player> listOfPlayers = new List<Player>();
        public string m_firstName { get; }
        public string m_lastName { get; }
        public string m_dateOfBirth { get; }
        public string m_homeAddress { get; set; }
        public string m_email { get; set; }
        public string m_phoneNumber { get; set; }
        public List<League> leagueSubscibedTo = new List<League>();

        public Player(string p_firstName, string p_lastName, string p_dateOfBirth, string p_homeAddress, string p_email, string p_phoneNumber)
        {
            this.m_firstName = p_firstName;
            this.m_lastName = p_lastName;
            this.m_dateOfBirth = p_dateOfBirth;
            this.m_homeAddress = p_homeAddress;
            this.m_email = p_email;
            this.m_phoneNumber = p_phoneNumber;
            listOfPlayers.Add(this);

        }

        public void ChangeHomeAddress(string p_newAddress)
        {
            try
            {
                if (!p_newAddress.Equals(m_homeAddress))
                {
                    this.m_homeAddress = p_newAddress;
                }
                else
                {
                    throw new InvalidOperationException("Addresses are identical.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
        public void ChangeEmail(string p_newEmail)
        {
            if (!p_newEmail.Contains("@") && !p_newEmail.Contains(".com"))
            {
                throw new InvalidOperationException("The email address is invalid!");
            }
            else
            {
                m_email = p_newEmail;
            }
            
        }

        public void ChangePhone(string p_newPhone)
        {
            if(!m_phoneNumber.Equals(p_newPhone) &&  CheckNumber(p_newPhone))
            {
                m_phoneNumber = p_newPhone;
            }
            else
            {
                throw new InvalidOperationException("Phone number is invalid!");
            }
        }

        public void RegisterToLeague(League p_leagueToRegister)
        {


            this.leagueSubscibedTo.Add(p_leagueToRegister);
        }

 
        private static bool CheckNumber(string strPhoneNumber)
        {
            string MatchPhoneNumberPattern = "^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            if (strPhoneNumber != null) return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern);
            else return false;
        }

    }
}
