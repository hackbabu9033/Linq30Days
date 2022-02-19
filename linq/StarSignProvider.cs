using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTest
{
    public class StarSignProvider
    {
        public StarSignsContent ListStarSignByInitialAndCount(StarSign ini,int length)
        {
            return new StarSignsContent(ini, length);
        }
    }


    public class StarSignEnum
    {
        public StarSign Current { get; private set; }
        private int _remainingLength;

        public StarSignEnum(StarSign ini,int length)
        {
            Current = ini;
            _remainingLength = length;
        }
        public bool MoveNext()
        {
            if (_remainingLength <= 0)
            {
                return false;
            }
            var enumFlag = ((int)Current + 1) % 12;
            Current = (StarSign)enumFlag;
            _remainingLength--;
            return true;
        }

    }

    public class StarSignsContent
    {
        private StarSign _starSigns;
        private int _length;

        public StarSignsContent(StarSign starSign,int length)
        {
            _starSigns = starSign;
            _length = length;
        }

        public StarSignEnum GetEnumerator()
        {
            return new StarSignEnum(_starSigns, _length);
        }
    }
}
