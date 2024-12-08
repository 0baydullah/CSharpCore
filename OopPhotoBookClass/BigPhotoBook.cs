using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPhotoBookClass
{
    internal class BigPhotoBook
    {
        private int numPages;
        public BigPhotoBook()
        {
            numPages = 64;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
