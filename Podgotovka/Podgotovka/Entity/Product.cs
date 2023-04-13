//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Podgotovka.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public string productUnit { get; set; }
        public decimal productCost { get; set; }
        public Nullable<int> productManufacturer { get; set; }
        public Nullable<int> productProvider { get; set; }
        public Nullable<int> productCategory { get; set; }
        public Nullable<byte> productMaxDiscountAmount { get; set; }
        public Nullable<byte> productActiveDiscountAmount { get; set; }
        public int productQuantityInStock { get; set; }
        public string productDescription { get; set; }
        public string productPicture { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
