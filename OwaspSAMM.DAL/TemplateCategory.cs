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
    
    public partial class TemplateCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TemplateCategory()
        {
            this.TemplateSections = new HashSet<TemplateSection>();
        }
    
        public int CatID { get; set; }
        public int TemplateID { get; set; }
        public int CategoryID { get; set; }
        public int CategoryOrder { get; set; }
    
        public virtual AssessmentTemplate AssessmentTemplate { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateSection> TemplateSections { get; set; }
    }
}