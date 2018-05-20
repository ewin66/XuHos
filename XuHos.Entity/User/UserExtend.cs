using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    /// <summary>
    /// �û���Ϣ��չ��
    /// </summary>
    public class UserExtend : AuditableEntity, IUserBaseEntity
    {

        public UserExtend()
        {
            JRegisterID = "";
            LastTime = DateTime.Now;
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserID { get; set; }

        /// <summary>
        /// ����¼ʱ��
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastTime { get; set; }

        /// <summary>
        /// �������͵��豸ID
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string JRegisterID { get; set; }
    }
}
