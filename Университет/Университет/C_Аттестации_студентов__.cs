//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Университет
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_Аттестации_студентов__
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Аттестации_студентов__()
        {
            this.Студенты_ = new HashSet<Студенты_>();
        }
    
        public int ИД { get; set; }
        public string ФИО_студента { get; set; }
        public string Предмет { get; set; }
        public Nullable<int> Аттестация_1 { get; set; }
        public Nullable<int> Аттестация_2 { get; set; }
        public Nullable<int> Аттестация_3 { get; set; }
        public Nullable<int> Итого { get; set; }
        public string Оценка { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Студенты_> Студенты_ { get; set; }
    }
}
