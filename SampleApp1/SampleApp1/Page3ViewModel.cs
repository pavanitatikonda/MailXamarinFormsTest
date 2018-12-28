using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    public class Page3ViewModel: INotifyPropertyChanged
    {

        public string _wishText;
        public string WishText
        {
            get
            {
                return _wishText;
            }
            set
            {
                _wishText = value;
                OnPropertyChanged("WishText");
            }
        }

        public void gettime()
        {
            int timeOfDay = DateTime.Now.Hour;

            if (timeOfDay >= 0 && timeOfDay < 12)
            {
                WishText = "Good Morning";
            }
            else if (timeOfDay >= 12 && timeOfDay < 16)
            {
                WishText = "Good Afternoon";
            }
            else if (timeOfDay >= 16 && timeOfDay < 21)
            {
                WishText = "Good Evening";
            }
            else if (timeOfDay >= 21 && timeOfDay < 24)
            {
                WishText = "Good Night";
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
