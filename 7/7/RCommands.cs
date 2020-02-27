using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _7
{
    public static class RCommands
    {
        private static readonly RoutedUICommand MyCommand;

        static RCommands()
        {
            InputGestureCollection gestureCollection = new InputGestureCollection();//коллекция жестов
            gestureCollection.Add(new KeyGesture(Key.Q, ModifierKeys.Alt, "Alt + Q"));
            gestureCollection.Add(new KeyGesture(Key.Escape));
            RCommands.MyCommand = new RoutedUICommand("MyCommand", "MyCommand", typeof(RCommands), gestureCollection);//кидаем в команду
        }
        public static RoutedUICommand myCommand
        {
            get { return MyCommand; }
        }
    }
}
