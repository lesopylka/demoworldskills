//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказы
    {
        public int ID { get; set; }
        public string Код_заказа { get; set; }
        public Nullable<double> Дата_создания { get; set; }
        public Nullable<double> Время_заказа { get; set; }
        public Nullable<int> Код_клиента { get; set; }
        public string Услуги { get; set; }
        public string Статус { get; set; }
        public Nullable<double> Дата_закрытия { get; set; }
        public string Время_проката { get; set; }
        public Nullable<int> Код_сотрудника { get; set; }
    
        public virtual Клиент Клиент { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
    }
}
