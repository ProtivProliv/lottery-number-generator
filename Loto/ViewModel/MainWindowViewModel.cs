using Loto.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Loto.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        Random randomNumber;
        int[] generatedNumbers;
        int number;
        MainWindow mainView;
        public MainWindowViewModel(MainWindow mainView)
        {
            this.mainView = mainView;
        }

        private int numberOne;
        public int NumberOne
        {
            get { return numberOne; }
            set
            {
                numberOne = value;
                OnPropertyChanged("NumberOne");
            }
        }

        private int numberTwo;
        public int NumberTwo
        {
            get { return numberTwo; }
            set
            {
                numberTwo = value;
                OnPropertyChanged("NumberTwo");
            }
        }

        private int numberThree;
        public int NumberThree
        {
            get { return numberThree; }
            set
            {
                numberThree = value;
                OnPropertyChanged("NumberThree");
            }
        }

        private int numberFour;
        public int NumberFour
        {
            get { return numberFour; }
            set
            {
                numberFour = value;
                OnPropertyChanged("NumberFour");
            }
        }

        private int numberFive;
        public int NumberFive
        {
            get { return numberFive; }
            set
            {
                numberFive = value;
                OnPropertyChanged("NumberFive");
            }
        }

        private int numberSix;
        public int NumberSix
        {
            get { return numberSix; }
            set
            {
                numberSix = value;
                OnPropertyChanged("NumberSix");
            }
        }

        private int numberSeven;
        public int NumberSeven
        {
            get { return numberSeven; }
            set
            {
                numberSeven = value;
                OnPropertyChanged("NumberSeven");
            }
        }

        private ICommand generateCommand;
        public ICommand GenerateCommand
        {
            get
            {
                if (generateCommand == null)
                {
                    generateCommand = new RelayCommand(Generate);
                    return generateCommand;
                }
                return generateCommand;
            }
        }
        private void Generate(object obj)
        {
            randomNumber = new Random();
            generatedNumbers = new int[7];
            
            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                number = randomNumber.Next(1, 40);
                if (generatedNumbers.Contains(number))
                {
                    i--;
                }
                else
                {
                    generatedNumbers[i] = number;
                }
            }
            NumberOne = generatedNumbers[0];
            NumberTwo = generatedNumbers[1];
            NumberThree = generatedNumbers[2];
            NumberFour = generatedNumbers[3];
            NumberFive = generatedNumbers[4];
            NumberSix = generatedNumbers[5];
            NumberSeven = generatedNumbers[6];
        }

        private ICommand closeCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (closeCommand == null)
                {
                    closeCommand = new RelayCommand(Close);
                    return closeCommand;
                }
                return closeCommand;
            }
        }
        private void Close(object obj)
        {
            mainView.Close();
        }
    }
}
