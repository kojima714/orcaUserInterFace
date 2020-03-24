using System.Windows;

namespace OrcaClient {
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell {
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }
        private string name;

        public bool CanSayHello
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name);
            }
        }

        public void SayHello()
        {
            MessageBox.Show("Hello, " + Name);
        }
    }
}