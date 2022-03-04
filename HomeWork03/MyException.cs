using System;
using System.Collections.Generic;
using System.Text;

namespace homework03
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
