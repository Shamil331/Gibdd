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
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Car = new HashSet<Car>();
            this.License = new HashSet<License>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Middle_Name { get; set; }
        public string Surname { get; set; }
        public Nullable<int> Passport_Serial { get; set; }
        public Nullable<int> Passport_Number { get; set; }
        public Nullable<int> Postcode { get; set; }
        public string Address { get; set; }
        public string Address_Life { get; set; }
        public string Company { get; set; }
        public string Job_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo_Name { get; set; }
        public byte[] Photo_Image { get; set; }
        public string Description { get; set; }
        public string ImagePath
        {
            get
            {
                return "../Resources/photo/" + this.Photo_Name;
            }
        }
        public string FullName
        {
            get
            {
                return this.Surname + " " + this.Name[0] + "." + this.Middle_Name[0] + ".";
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<License> License { get; set; }
    }
}
