using System;
using System.Collections.Generic;

namespace Alfa.Entities.Models
{
    public partial class OPE_EXC
    {
        public int WRKID { get; set; }
        public Nullable<int> OPE_ID { get; set; }
        public string OPE_NAME { get; set; }
        public virtual OPERATION OPERATION { get; set; }
        public virtual WRKORD WRKORD { get; set; }
    }
}
