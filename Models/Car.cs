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
    
    public partial class Car
    {
        public int Id { get; set; }
        public string VIN_Number { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Color_Id { get; set; }
        public Nullable<int> Engine_Type_Id { get; set; }
        public string Type_Of_Drive { get; set; }
        public Nullable<int> Driver_Id { get; set; }
        public Nullable<int> Region_Code_Id { get; set; }
    
        public virtual Car_Colors Car_Colors { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Engine_Types Engine_Types { get; set; }
        public virtual Region_Codes Region_Codes { get; set; }
    }
}
