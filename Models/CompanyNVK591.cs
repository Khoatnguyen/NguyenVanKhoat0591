using System.ComponentModel.DataAnnotations;

namespace NguyenVanKhoat0591.Models {
    public class CompanyNVK591{
        [Key]
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
    }
}