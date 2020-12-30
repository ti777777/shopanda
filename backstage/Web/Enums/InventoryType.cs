using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Enums
{
    /// <summary>
    /// 貨品狀態
    /// </summary>
    public enum InventoryType
    {
        [Description("現貨")]
        InStock,
        [Description("缺貨")]
        OutOfStock
    }
}
