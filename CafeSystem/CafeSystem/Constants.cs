﻿using System;

namespace CafeSystem
{
    class Constants
    {
        public const int CASHIERDEP_ID = 1;
        public const int MANAGERDEP_ID = 3;
        private int ordernum = 0;

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
            ordernum++;
            return ordernum;
        }
    }
}
