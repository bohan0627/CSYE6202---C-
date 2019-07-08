using System;
using System.Collections.Generic;
namespace Bo_Han_Assignment2
{
    public interface IWriteable
    {
        void WriteAll(string fileName, List<string> data);
    }
}
