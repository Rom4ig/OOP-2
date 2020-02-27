using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace OOP_11
{
    public class MainViewModel
    {
        public ObservableCollection<TheatreViewModel> CompaniesList { get; set; } 
        public MainViewModel(List<Theatre> list)
        {
            CompaniesList = new ObservableCollection<TheatreViewModel>(list.Select(b => new TheatreViewModel(b)));
        }
    }

}
