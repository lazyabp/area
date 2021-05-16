using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lazy.Abp.AreaKit.Countries
{
    public enum Continent
    {
        [Display(Name = "亚洲")]
        Asia,
        [Display(Name = "欧洲")]
        Europe,
        [Display(Name = "非洲")]
        Africa,
        [Display(Name = "北美洲")]
        NorthAmerica,
        [Display(Name = "南美洲")]
        SouthAmerica,
        [Display(Name = "大洋洲")]
        Oceania,
        [Display(Name = "南极洲")]
        Antarctica,
        [Display(Name = "其它")]
        Others
    }
}
