using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    public class SysFileIndex:AuditableEntity
    {
        /// <summary>
        /// ����ID
        /// </summary>
        [Key,Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string MD5 { get; set; }

        /// <summary>
        /// �ļ���ַ
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        public string FileUrl { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string FileType { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        public string Remark { get; set; }

        [Required]
        public long ReadCount { get; set; }

        [Required]
        public long FileSize { get; set; }

        /// <summary>
        /// ǩ��Key��ͨ����Key�ɻ�ȡ�����ļ�Ȩ��
        /// </summary>
        [Required]
        public string AccessKey { get; set; }
    }
}
