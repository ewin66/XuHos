using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace XuHos.Entity
{
    /// <summary>
    /// ҽ���۸����
    /// </summary>
    public partial class DoctorService : AuditableEntity
    {
        /// <summary>
        /// ����ID
        /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string ServiceID { get; set; }

        /// <summary>
        /// ҽ��ID
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DoctorID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public Common.Enum.EnumDoctorServiceType ServiceType { get; set; }

        /// <summary>
        /// ���񿪹�(0-�رշ���1-��������)
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool ServiceSwitch { get; set; }

        /// <summary>
        /// ����۸�
        /// </summary>
        [Required]
        [Column(TypeName = "decimal")]
        public decimal ServicePrice { get; set; }

    }
}
