using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiService
{
    class Helper
    {
        public static int GetIdByUrl(string url)
        {
            string[] elements = url.Split('/');
            return Int32.Parse(elements.Last(), 0);
        }
    }
}
