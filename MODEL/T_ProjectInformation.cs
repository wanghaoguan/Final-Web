//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ProjectInformation
    {
        public T_ProjectInformation()
        {
            this.T_ProjectParticipation = new HashSet<T_ProjectParticipation>();
            this.T_TaskInformation = new HashSet<T_TaskInformation>();
        }
    
        public int ProjId { get; set; }
        public int ProjTypeId { get; set; }
        public string ProjName { get; set; }
        public string ProjLeader { get; set; }
        public string ProjPublisher { get; set; }
        public System.DateTime ProjStartTime { get; set; }
        public System.DateTime ExFinishiTime { get; set; }
        public System.DateTime AcFinishiTime { get; set; }
        public string ProjProfile { get; set; }
        public double ProjPay { get; set; }
        public double ProjIncome { get; set; }
        public string ProjMark { get; set; }
    
        public virtual T_MemberInformation T_MemberInformation { get; set; }
        public virtual T_MemberInformation T_MemberInformation1 { get; set; }
        public virtual ICollection<T_ProjectParticipation> T_ProjectParticipation { get; set; }
        public virtual T_ProjectType T_ProjectType { get; set; }
        public virtual ICollection<T_TaskInformation> T_TaskInformation { get; set; }
    }
}
