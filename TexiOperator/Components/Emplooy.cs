//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TexiOperator.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emplooy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emplooy()
        {
            this.Order = new HashSet<Order>();
            this.Order1 = new HashSet<Order>();
            this.OrderForDriver = new HashSet<OrderForDriver>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> EarningFromOrders { get; set; }
        public Nullable<decimal> Phone { get; set; }
        public Nullable<decimal> Card { get; set; }
        public Nullable<int> OrdersCompl { get; set; }
        public Nullable<int> OchenkaObhay { get; set; }
        public Nullable<int> IsBan { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderForDriver> OrderForDriver { get; set; }
    }
}
