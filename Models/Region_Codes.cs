//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gibdd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Region_Codes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region_Codes()
        {
            this.Car = new HashSet<Car>();
        }
    
        public int Id { get; set; }
        public string Region_Name_En { get; set; }
        public string Region_Name_Ru { get; set; }
        public Nullable<int> Subject_Code { get; set; }
        public Nullable<int> Code { get; set; }
        public Nullable<int> OKATO_Code { get; set; }
        public string ISO_3166_2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Car { get; set; }
    }
}
