using WpfApp5.NewFolder1;

namespace WpfApp5
{
    public class notebooks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public int? PhoneID { get; set; }
        public Phone Phone { get; set; }
    }
}
