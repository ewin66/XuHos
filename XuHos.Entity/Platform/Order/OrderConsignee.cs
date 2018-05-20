using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace XuHos.Entity
{
  
    /// <summary>
    /// �����ջ���
    /// </summary>
    public partial class OrderConsignee : AuditableEntity
    {
        /// <summary>
        /// �������
        /// </summary>
        [Key]
        [MaxLength(32)]
        public string OrderNo { get; set; }

        /// <summary>
        /// �ջ��˵�ַ
        /// </summary>
        [MaxLength(100)]
        [Required]
        public string ConsigneeAddress { get; set; }

        /// <summary>
        /// �ջ�������
        /// </summary>
        [MaxLength(50)]
        [Required]

        public string ConsigneeName { get; set; }

        /// <summary>
        /// �ջ��˵绰
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string ConsigneeTel { get; set; }

        /// <summary>
        /// �ͻ�ʱ��
        /// </summary>
        public DateTime? SendGoodsTime { get; set; }

        /// <summary>
        /// �Ƿ��ͥ��ַ
        /// </summary>
        public decimal IsHosAddress { get; set; }     
    }
}
