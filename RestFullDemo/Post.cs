using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using RestFullDemo.Annotations;

namespace RestFullDemo
{
    internal class Post: INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _title;

        [JsonProperty("title")]
        public string Title
        {
            get
            {
                return _title; 

            }
            set {
                _title = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
