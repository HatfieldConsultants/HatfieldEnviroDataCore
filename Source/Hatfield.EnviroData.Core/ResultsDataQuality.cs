//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResultsDataQuality
    {
        public int BridgeID { get; set; }
        public long ResultID { get; set; }
        public int DataQualityID { get; set; }
    
        public virtual DataQuality DataQuality { get; set; }
        public virtual Result Result { get; set; }
    }
}