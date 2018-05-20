using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace XuHos.Entity
{
    /// <summary>
    /// APIƽ̨�����˻�
    /// </summary>
    public class SysAccessAccount : AuditableEntity
    {
        /// <summary>
        /// �ļ�ID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string AccessID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(512)]
        public string AppId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(512)]
        public string AppSecret { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(512)]
        public string AppKey { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string SourceType { get; set; } //JS��IOS��Android��


        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string UserKey { get; set; }

    }
}
