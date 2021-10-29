using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Assembly_Browser;

namespace Assembly_Browser.ViewModel
{
    class ButtonViewModel : INotifyPropertyChanged
    {
        private string _fileName;
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
                OnPropertyChanged("FileName");
            }
        }


        public ButtonCommand ButtonCommand { get; set; }
        public ButtonViewModel()
        {
            ButtonCommand = new ButtonCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnExecute()
        {
            
            var fileDialog = new OpenFileDialog
            {
                Filter = "Assemblies|*.dll;*.exe",
                Title = "Select assembly",
                Multiselect = false
            };

            var isOpen = fileDialog.ShowDialog();

            if(isOpen == null)
            {
                //MessageBox.Show("ohhhh");
                FileName = "File hasn't been chosen.";
                return;
            }

            if (isOpen.Value)
            {
                //MessageBox.Show("opened");
                FileName = fileDialog.FileName;
                CreateTree(FileName);
            }
            //MessageBox.Show("Button is cliicked");
        }

        private List<int> _namespaces;
        public List<int> Namespaces { get; set; }
        //private readonly AssemblyBrowser;

        private void CreateTree(string FileName)
        {
            Namespaces = null;
            try
            {
                //Namespaces=
            }catch(Exception e)
            {
                FileName = e.Message;
            }

            OnPropertyChanged("Namespaces");
        }

    }
}
