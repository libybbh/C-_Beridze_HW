using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public string HoroscopeZod
        {
            get { return _zodiac; }
            set { _zodiac = value; }
        }

        public string HoroscopeChi
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
    
}
}
