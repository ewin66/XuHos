using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace XuHos.Entity
{
    
    /// <summary>
    /// ҽ���Ű�
    /// </summary>
    public partial class DoctorSchedule : AuditableEntity
    {
        public DoctorSchedule()
        {
        }

        /// <summary>
        /// �Ű�ID
        /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string ScheduleID { get; set; }

        /// <summary>
        /// ҽ��ID
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DoctorID { get; set; }

        /// <summary>
        /// �Ű�����
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OPDate { get; set; }

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
        /// ��Դ����
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// ��ԤԼ��Դ
        /// </summary>
        public int AppointNumber { get; set; }

    }
}
