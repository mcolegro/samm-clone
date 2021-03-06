//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwaspSAMM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assessment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assessment()
        {
            this.CategoryDatas = new HashSet<CategoryData>();
        }
    
        public int AssessmentID { get; set; }
        public int TemplateVersion { get; set; }
        public int OwnerID { get; set; }
        public string OrganizationName { get; set; }
        public string ApplicationName { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> IndustryID { get; set; }
        public string BusinessUnit { get; set; }
        public Nullable<bool> Finalized { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryData> CategoryDatas { get; set; }
        public virtual UserData UserData { get; set; }
        public virtual UserData UserData1 { get; set; }
        public virtual UserData UserData2 { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
