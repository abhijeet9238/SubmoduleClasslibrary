using System;
using System.Collections.Generic;
using System.Text;

namespace SubmoduleClasslibrary
{
    public interface IOperations
    {
        int add(int value1, int value2);
        int sub(int value1, int value2);
        int mul(int value1, int value2);
        int div(int value1, int value2);
    }
}
