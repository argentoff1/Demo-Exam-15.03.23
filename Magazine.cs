//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _15._03._2023
{
    using System;
    using System.Collections.Generic;
    
    public partial class Magazine
    {
        public int id { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public int DisciplineId { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
