using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Beridze_1
{
    class VIewModel : INotifyPropertyChanged
    {
        #region Fields
        private DateTime _dateBirth = DateTime.Today;
        private int _age;
        private string _zodiac;
        private string _chinese;
        #endregion

        #region Properties
        internal VIewModel()
        {
        }

        public string Age
        {
            get
            {
                return $"{_age}";
            }
        }

        public string Zodiac
        {
            get
            {
                return _zodiac;
            }
            private set
            {
                _zodiac = value;
                OnPropertyChanged();
            }
        }

        public string Chinese
        {
            get
            {
                return _chinese;
            }
            private set
            {
                _chinese = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateBirth; }
            set
            {
                _dateBirth = value;
                Update();
                if (_age < 0 || _age > 135)
                    MessageBox.Show("Illegal date!");
                OnPropertyChanged();
            }
        }

        private async void Ok()
        {
            await Task.Run(() => Thread.Sleep(5000));
            MessageBox.Show("Goodbye!");
        }
        #endregion

        #region Calculates
        private void Update()
        {
            int days = (DateTime.Today - _dateBirth).Days;
            var age = days / 365;

            _age = age;
            OnPropertyChanged(nameof(Age));

            Chinese = ChineseC();
            Zodiac = ZodiacC();
            IsBirthDay();
           
        }
 
        private void IsBirthDay()
        {
          if (DateTime.Today.DayOfYear == _dateBirth.DayOfYear)
                MessageBox.Show("It`s your birthday!");
        }

        private string ChineseC()
        {
            switch ((_dateBirth.Year - 4) % 12)
            {
                case 0:
                    return "Rat";
                    
                case 1:
                    return "Ox";
                    
                case 2:
                    return "Tiger";
                    
                case 3:
                    return "Rabbit";
                    
                case 4:
                    return "Dragon";
                    
                case 5:
                    return "Snake";
                    
                case 6:
                    return "Horse";
                   
                case 7:
                    return "Goat";
                   
                case 8:
                    return "Monkey";
                    
                case 9:
                    return "Rooster";
                    
                case 10:
                    return "Dog";
                    
                case 11:
                    return "Pig";
                    
                default:
                    return " ";
                   
            }
        
    }
        private string ZodiacC()
        {
            switch (_dateBirth.Month)
            {
                case 1:
                    if (_dateBirth.Day <= 20)
                        return "Your zodiac sign is Capricorn";
                    else
                        return "Your zodiac sign is Aquarius";
                    
                case 2:
                    if (_dateBirth.Day <= 19)
                        return "Your zodiac sign is Aquarius"; 
                    else
                        return "Your zodiac sign is Pisces"; 
                    
                case 3:
                    if (_dateBirth.Day <= 20)
                        return "Your zodiac sign is Pisces";
                    else
                        return "Your zodiac sign is Aries";
                    
                case 4:
                    if (_dateBirth.Day <= 20)
                        return "Your zodiac sign is Aries";
                    else
                        return "Your zodiac sign is Taurus";
                    
                case 5:
                    if (_dateBirth.Day <= 21)
                        return "Your zodiac sign is Taurus";
                    else
                        return "Your zodiac sign is Gemini";
                    
                case 6:
                    if (_dateBirth.Day <= 22)
                        return "Your zodiac sign is Gemini";
                    else
                        return "Your zodiac sign is Cancer";
                    
                case 7:
                    if (_dateBirth.Day <= 22)
                        return "Your zodiac sign is Cancer";
                    else
                        return "Your zodiac sign is Leo";
                    
                case 8:
                    if (_dateBirth.Day <= 23)
                        return "Your zodiac sign is Leo";
                    else
                        return "Your zodiac sign is Virgo";
                    
                case 9:
                    if (_dateBirth.Day <= 23)
                        return "Your zodiac sign is Virgo";
                    else
                        return "Your zodiac sign is Libra";
                    
                case 10:
                    if (_dateBirth.Day <= 23)
                        return "Your zodiac sign is Libra";
                    else
                        return "Your zodiac sign is Scorpio";
                    
                case 11:
                    if (_dateBirth.Day <= 22)
                        return "Your zodiac sign is Scorpio";
                    else
                        return "Your zodiac sign is Sagittarius";
                    
                case 12:
                    if (_dateBirth.Day <= 21)
                        return "Your zodiac sign is Sagittarius";
                    else
                        return "Your zodiac sign is Capricorn";
                default:
                    return "Your zodiac sign was not found! Please try again!";
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
