using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAsyncDirectoryFile
{
    public class NotFoundExpection:Exception
    {
        public NotFoundExpection(string message) : base(message)
        {
            
        }
    }
}
