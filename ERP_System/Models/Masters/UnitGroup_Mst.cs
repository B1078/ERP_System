﻿namespace ERP_System.Models.Masters
{
    public class UnitGroup_Mst
    {
        public string? UomGRPId { get; set; }
        public string? BaseUomId { get; set; }
        public string? UomGRPName { get; set; }
        public string? IsManual { get; set; }
        public string? IsActive { get; set; }
        public string? errormessage { get; set; }
        public DateOnly? UpdateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public TimeOnly? UpdateTS { get; set; }
        public DateOnly? CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public TimeOnly? CreateTS { get; set; }
    }
}
