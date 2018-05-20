using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    /// <summary>
    /// �û���ɫ
    /// </summary>
    public partial class UserRole : AuditableEntity
    {
    
        /// <summary>
        /// ��ɫ���
        /// </summary>��
        [Key,MaxLength(32)]
        [Column(TypeName = "varchar")]
        public string RoleID { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        [Required,MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string RoleName { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        [MaxLength(200)]
        public string Memo { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        [Column(TypeName = "int")]
        public EnumRoleType RoleType { get; set; }
    }
}
