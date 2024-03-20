using System.ComponentModel.DataAnnotations;

namespace ETR.Infra.EagleEye.API2.Models
{
    public class PulseLogs
    {
        [Key] 
        public int Id { get; set; }
        public string Computer { get; set; }
        public string Status { get; set; }
        public string TaskId { get; set; }
    }

}