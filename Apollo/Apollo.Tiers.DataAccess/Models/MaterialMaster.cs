using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class MaterialMaster
    {
        public long Id { get; set; }
        public string FgSapcode { get; set; }
        public string FgMaterialName { get; set; }
        public string FgDescription { get; set; }
        public bool? IsVisibleInKanban { get; set; }
        public bool? IsActive { get; set; }
        public string ExSapcode { get; set; }
        public string ExMaterialName { get; set; }
        public string ExDescription { get; set; }
        public decimal? MinAgingPeriod { get; set; }
        public decimal? AgingPeriod { get; set; }
        public decimal? ExpiryPeriod { get; set; }
        public decimal? NoOfMouldsRunning { get; set; }
        public decimal? PerShiftOutput { get; set; }
        public string CompoundMaterial1 { get; set; }
        public string CompoundMaterial2 { get; set; }
        public string CompoundMaterial3 { get; set; }
        public string RepassMaterial { get; set; }
        public decimal? RedLimit { get; set; }
        public decimal? YellowLimit { get; set; }
        public decimal? GreenLimit { get; set; }
        public string SpSapcode { get; set; }
        public string SpMaterialName { get; set; }
        public string SpDescription { get; set; }
        public decimal? SpMinAgingPeriod { get; set; }
        public decimal? SpAgingPeriod { get; set; }
        public decimal? SpExpiryPeriod { get; set; }
        public decimal? SpNoOfMouldsRunning { get; set; }
        public decimal? SpPerShiftOutput { get; set; }
        public decimal? SpRedLimit { get; set; }
        public decimal? SpYellowLimit { get; set; }
        public decimal? SpGreenLimit { get; set; }
        public string FfSapcode { get; set; }
        public string FfMaterialName { get; set; }
        public string FfDescription { get; set; }
        public string FfMaterilaType { get; set; }
        public decimal? TubeWeight { get; set; }
        public decimal? ExpectedBoxQty { get; set; }
        public decimal? ExpectedBoxWeight { get; set; }
        public decimal? ExectedSackQuantity { get; set; }
        public decimal? ExpectedPouchQuantity { get; set; }
        public decimal? ExpectedSackWeight { get; set; }
        public decimal? ExpectedPouchWeight { get; set; }
        public decimal? Tolarance { get; set; }
    }
}
