//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerProducts
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int PartnerNameID { get; set; }
        public int ProductQuantity { get; set; }
        public System.DateTime SellingDate { get; set; }
    
        public virtual Partners Partners { get; set; }
        public virtual Products Products { get; set; }
    }
}
