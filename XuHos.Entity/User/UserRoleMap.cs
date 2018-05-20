using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    /// <summary>
    /// �û�-��ɫ��ϵ
    /// </summary>
    public partial class UserRoleMap : AuditableEntity, IUserBaseEntity
    {
        /// <summary>
        /// ��ɫ���
        /// </summary>
        [Key,MaxLength(32)]
        public string UserRoleMapID { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        [Required,MaxLength(32)]
        public string RoleID { get; set; }

        /// <summary>
        /// �û�ID
        /// </summary>
        [Required, MaxLength(32)]
        public string UserID { get; set; }
    }
}
