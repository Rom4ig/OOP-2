using System.Windows;

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //abstract factory
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

        }

        //singleton
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Computer pc = new Computer();
            pc.Launch("PC 1");
            MessageBox.Show(pc.Singleton.Name); 

            pc.Singleton = Singleton.getInstance("PC 2");
            MessageBox.Show(pc.Singleton.Name);
        }
        
        //builder+director
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // содаем объект пекаря
            Baker baker = new Baker();
            // создаем билдер для ржаного хлеба
            BreadBuilder builder = new RyeBreadBuilder();
            // выпекаем
            Bread ryeBread = baker.Bake(builder);
            MessageBox.Show(ryeBread.ToString());
            // создаем билдер для пшеничного хлеба
            Bread wheatBread = baker.Bake(builder);
            MessageBox.Show(wheatBread.ToString());
        }

        //prototype
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }


    //--------------------------------------------------------------------------------
    
    //------------------------------------------------------------------------------------

    //используется в качестве прототипа 
   
    //----------------------------------------------------------------------------------------


    //мука
   

}
