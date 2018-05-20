using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace XuHos.Entity
{
    /// <summary>
    /// ����ʱ��
    /// </summary>
    public partial class HospitalWorkingTime : AuditableEntity
    {  
        /// <summary>
       /// ����ʱ��ID
       /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string WorkingTimeID { get; set; }

        /// <summary>
        /// ҽԺID
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string HospitalID { get; set; }

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(16)]
        public string StartTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(16)]
        public string EndTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int Sort { get; set; }

    }
}
