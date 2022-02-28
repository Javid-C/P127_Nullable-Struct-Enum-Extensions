using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Extensions
{
    struct MySturct
    {
        public int X;
        public int Y;

        public MySturct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Space(int x,int y)
        {
            return x * y;
        }
    }
}
