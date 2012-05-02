using System;

namespace CafeSystem
{
    class Constants
    {
        public const int CASHIERDEP_ID = 1;
        public const int MANAGERDEP_ID = 2;
        public const int PASSWORD_COLUMN= 5;
        //private int ordernum = 0;

        private static Constants functions;
        private Constants() {}

        public static Constants Functions
        {
            get
            {
                if (functions == null)
                    functions = new Constants();
                return functions;
            }
        }

        public int ORDER_NUM()
        {
            string[] s = DateTime.Now.ToString().Split(':','.',' ');
            string s2 = s[0] + s[1] + s[2].Substring(3) + s[3] + s[4] + s[5];
            return Int32.Parse(s2);
        }
    }
}
