using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace RMS_MPD
{
    class utility
    {
        public static string currentemail;  //This stores the email of current customer that has signed in. 
        public static string currentSocialID;
        public static string OrderID;
        ///////////
        public static string ManagerUser;
        public static string ManagerPass;
        //////////////
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static void Generate_OrderID()
        {
            OrderID = RandomString(9);
        }
        //////////////
        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }


        //////////////////////////////////////////////////////
        public static bool usernamecheck(string input)
        {
            if (input == "manager")
                return true;
            else
                return false;
        }

        public static bool phonecheck(string input)
        {
            string pattern1 = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            Regex sample1 = new Regex(pattern1, RegexOptions.IgnoreCase);
            if (sample1.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool emailcheck(string input)
        {
            string basic = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex sample = new Regex(basic, RegexOptions.IgnoreCase);
            if (sample.IsMatch(input))
                return true;
            else
                return false;
        }
        public static bool passwordcheck(string input)
        {
            bool check = false;
            int c = 0;
            string pattern1 = @"(?=.*[0-9])";
            string pattern2 = @"(?=.*[a-z])";
            string pattern3 = @"(?=.*[A-Z])";
            string pattern4 = @"(?=.*[@!#$%^&*()_+-=~`{}|[':;/?.>,<])";
            Regex sample1 = new Regex(pattern1, RegexOptions.IgnoreCase);
            Regex sample2 = new Regex(pattern2, RegexOptions.IgnoreCase);
            Regex sample3 = new Regex(pattern3, RegexOptions.IgnoreCase);
            Regex sample4 = new Regex(pattern4, RegexOptions.IgnoreCase);
            if (sample1.IsMatch(input))
            {
                c++;
            }

            if (sample2.IsMatch(input) || sample3.IsMatch(input))
            {
                c++;
            }

            if (sample4.IsMatch(input))
            {
                c++;
            }

            if (c == 3)
                check = true;
            return check;
        }
        /////////////////////////for checking id
        public static bool All_Same(string s)
        {
            int temp = Convert.ToInt32(new string(s[0], 1));
            int counter = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (Convert.ToInt32(new string(s[i], 1)) == temp)
                {
                    counter++;
                }
            }
            if (counter == 9) return true;
            return false;
        }
        public static bool Is_ID_Ok(string s)
        {
            string pattern1 = @"^[0-9]";
            Regex sample1 = new Regex(pattern1, RegexOptions.IgnoreCase);
            if (sample1.IsMatch(s))
            {
                return true;
            }
            return false;
        }
        /////////////////////////
    }
}
