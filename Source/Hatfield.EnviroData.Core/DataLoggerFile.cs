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
    
    public partial class DataLoggerFile
    {
        public DataLoggerFile()
        {
            this.DataloggerFileColumns = new HashSet<DataloggerFileColumn>();
        }
    
        public int DataLoggerFileID { get; set; }
        public int ProgramID { get; set; }
        public string DataLoggerFileName { get; set; }
        public string DataLoggerFileDescription { get; set; }
        public string DataLoggerFileLink { get; set; }
    
        public virtual ICollection<DataloggerFileColumn> DataloggerFileColumns { get; set; }
        public virtual DataloggerProgramFile DataloggerProgramFile { get; set; }
    }
}