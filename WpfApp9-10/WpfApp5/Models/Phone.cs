using System.Collections.Generic;

namespace WpfApp5.NewFolder1
{
    public class Phone
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public ICollection<notebooks> notes { get; set; }
        public Phone()
        {
            notes = new List<notebooks>();
        }
    }

}
