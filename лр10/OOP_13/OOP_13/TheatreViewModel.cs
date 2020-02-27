using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
namespace OOP_11
{
    public class TheatreViewModel : ViewModelBase
    {
        public Theatre theatre;
        public TheatreViewModel(Theatre th)
        {
            theatre = th;
        }
        #region Id
        public int Id
        {
            set
            {
                theatre.Id = value;
                OnPropertyChanged("Id");
            }
            get
            {
                return theatre.Id;
            }
        }
        #endregion
        #region Quantity_of_seats
        public byte Quantity_Of_Seats
        {
            set
            {
                theatre.Quantity_Of_Seats = value;
                OnPropertyChanged("Quantity_Of_Seats");
            }
            get
            {
                return theatre.Quantity_Of_Seats;
            }
        }
        #endregion
        #region Direction
        public string Direction
        {
            set
            {
                theatre.Direction = value;
                OnPropertyChanged("Direction");
            }
            get
            {
                return theatre.Direction;
            }
        }
        #endregion
        #region Day_Of_Week
        public DayOfWeek Day_Of_Week
        {
            set
            {
                theatre.Day_Of_Week = value;
                OnPropertyChanged("Day_Of_Week");
            }
            get
            {
                return theatre.Day_Of_Week;
            }
        }
#endregion
        #region Commands
        #region Купить
        private DelegateCommand getItemCommand;
        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }
        private void GetItem()
        {
            if (Quantity_Of_Seats <  Byte.MaxValue)
           Quantity_Of_Seats++;
        }
        #endregion
        #region Вернуть
        private DelegateCommand giveItemCommand;
        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                    giveItemCommand = new DelegateCommand(GiveItem);
                return giveItemCommand;
            }
        }
        private void GiveItem()
        {
            if (Quantity_Of_Seats > 0)
            Quantity_Of_Seats--;
        }
        #endregion
        #endregion

    }
}
