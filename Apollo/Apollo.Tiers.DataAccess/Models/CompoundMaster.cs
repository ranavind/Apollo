using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class CompoundMaster
    {
        public long Id { get; set; }
        public string Sapcode { get; set; }
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public string PorcessCode { get; set; }
        public decimal? ProcessOrder { get; set; }
        public decimal? BatchLimit { get; set; }
        public decimal? MinAgingPeriod { get; set; }
        public decimal? AgingPeriod { get; set; }
        public decimal? ExpiryPeriod { get; set; }
        public decimal? MixingCycleTime { get; set; }
        public bool? IsVisibleKanban { get; set; }
        public decimal? RedLimit { get; set; }
        public decimal? YellowLimit { get; set; }
        public decimal? GreenLimit { get; set; }
    }
}
