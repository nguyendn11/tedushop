﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDecription { get; set; }
        bool Status { get; set; }
    }
}
