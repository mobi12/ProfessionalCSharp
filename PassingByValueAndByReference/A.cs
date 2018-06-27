//书里假设的类，我不管它是不是脱了裤子放屁，我还是弄一个
using System;
using System.Collections.Generic;
using System.Text;

namespace PassingByValueAndByReference
{
    public struct A
    {
        private int _x;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
    }
}