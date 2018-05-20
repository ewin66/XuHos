using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{

    public class SysDict : AuditableEntity
    {
        /// <summary>
        /// �ֵ�ID
        /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DicID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DictTypeID { get; set; }

        /// <summary>
        /// �ֵ���
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DicCode { get; set; }

        /// <summary>
        /// �ֵ�������
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(64)]
        public string CNName { get; set; }

        /// <summary>
        /// �ֵ�Ӣ����
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string ENName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int OrderNo { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(512)]
        public string Remark { get; set; }

    }
}
