using System;
using System.Collections.Generic;
using System.Text;

namespace SubmoduleClasslibrary
{
    public class Operations : IOperations
    {
        public int add(int value1, int value2)
        {
            return value1 + value2;
        }
        public int mul(int value1, int value2)
        {
            return value1 * value2;
        }

        public int sub(int value1, int value2)
        {
            return value1 - value2;
        }

        public long div(int value1, int value2)
        {
            try
            {
                return value1 / value2;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
