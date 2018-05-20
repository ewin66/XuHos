using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    /// <summary>
    /// ҽԺ����
    /// </summary>
    public partial class HospitalDepartment : AuditableEntity
    {
        public HospitalDepartment()
        {
        }

        /// <summary>
        /// ����ID
        /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DepartmentID { get; set; }

        /// <summary>
        /// ҽԺID
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string HospitalID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        //[MaxLength(2048)]
        public string Intro { get; set; }
        /// <summary>
        /// ���ҷ������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CAT_NO { get; set; }

        /// <summary>
        /// һ�����ҷ������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string PARENT_CAT_NO { get; set; }
    }
}
