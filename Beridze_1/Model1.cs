using System;

namespace Beridze_1
{
    class Model 
    {
        private DateTime _dateBirth;
        private int _age;
        private string _zodiac;
        private string _chinese;

        public DateTime Birth
        {
            get { return _dateBirth; }
            set { _dateBirth = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Zod
        {
            get { return _zodiac; }
            set { _zodiac = value; }
        }

        public string Chi
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
    
}
}
