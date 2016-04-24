//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Justin.BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRole
    {
        public UserRole()
        {
            this.AuthorizedUsers = new HashSet<User>();
            this.Permissions = new HashSet<Permission>();
            this.AuthorizedDepartments = new HashSet<Department>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EntityState State { get; set; }
    
        public virtual ICollection<User> AuthorizedUsers { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Department> AuthorizedDepartments { get; set; }
    }
}