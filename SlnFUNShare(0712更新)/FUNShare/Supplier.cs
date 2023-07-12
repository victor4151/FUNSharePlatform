//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUNShare
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Advertise_Order = new HashSet<Advertise_Order>();
            this.Products = new HashSet<Product>();
        }
    
        public int Supplier_ID { get; set; }
        public string Tax_ID { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> City_ID { get; set; }
        public byte[] Supplier_Photo { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public string Contact_Person { get; set; }
        public byte[] Logo_Image { get; set; }
        public string Description { get; set; }
        public int Status_ID { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertise_Order> Advertise_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual City City { get; set; }
        public virtual Status Status { get; set; }
    }
}
