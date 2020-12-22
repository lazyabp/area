using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LazyAbp.AreaKit
{
    public enum AreaRegion
    {
        [Display(Name = "东亚")]
        EastAsia,
        [Display(Name = "东南亚")]
        SoutheastAsia,
        [Display(Name = "南亚")]
        SouthAsia,
        [Display(Name = "西亚")]
        WestAsia,
        [Display(Name = "北亚")]
        NorthAsia,
        [Display(Name = "中东")]
        MiddleEast,
        [Display(Name = "东欧")]
        EasternEurope,
        [Display(Name = "西欧")]
        WesternEurope
    }
}
