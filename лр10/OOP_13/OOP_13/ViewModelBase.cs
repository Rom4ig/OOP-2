using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace OOP_11
{
    public class ViewModelBase : INotifyPropertyChanged /*Нередко модель реализует интерфейсы INotifyPropertyChanged или INotifyCollectionChanged, 
        которые позволяют уведомлять систему об изменениях свойств модели.
        Благодаря этому облегчается привязка к представлению,
        хотя опять же прямое взаимодействие между моделью и представлением отсутствует*/
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}/*ViewModel или модель представления связывает модель и представление через механизм привязки данных.
Если в модели изменяются значения свойств, при реализации моделью интерфейса
INotifyPropertyChanged автоматически идет изменение отображаемых данных в представлении,
хотя напрямую модель и представление не связаны.*/
/*Модель описывает используемые в приложении данные. Модели могут содержать логику,
 * непосредственно связанную этими данными, например, логику валидации свойств модели. 
 * В то же время модель не должна содержать никакой логики, 
 * связанной с отображением данных и взаимодействием с визуальными элементами управления.*/
