using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XuHos.Common.Enum;
namespace XuHos.Entity
{

    public class Order : AuditableEntity
    {
        public Order()
        {
            PayType = EnumPayType.None;
            OrderTime = DateTime.Now;
            OrderExpireTime = OrderTime.AddMinutes(30);
            RefundState = EnumRefundState.NoRefund;
            OrderState = EnumOrderState.NoConfirm;
            totalFee = 0;
            RefundFee = 0;
            LogisticState = EnumLogisticState.�����;
        }

        /// <summary>
        /// ������
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string OrderNo { get; set; }

        /// <summary>
        /// �û�ID
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserID { get; set; }

  

        /// <summary>
        /// �����ⲿID(�����ⲿ����)
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string OrderOutID { get; set; }

        /// <summary>
        /// ����״̬��state��0-��֧����1-��֧����2-����ɡ�3-��ȡ����
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumOrderState OrderState { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumProductType OrderType { get; set; }

        /// <summary>
        /// �������ͣ�0-���ѡ�1-��ѡ�2-���3-�ײ͡�4-��Ա��5-��ͥҽ����
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumCostType CostType { get; set; }

        /// <summary>
        /// �˿���
        /// </summary>
        [Required]
        [Column(TypeName = "decimal")]
        public decimal RefundFee { get; set; }

        /// <summary>
        /// �˿��
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string RefundNo { get; set; }

        /// <summary>
        /// �˿�״̬
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumRefundState RefundState { get; set; }

        /// <summary>
        /// �˿�ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime RefundTime { get; set; }

        /// <summary>
        /// ֧�����ͣ�state��-1-��֧����0-����֧����1-΢��֧����2-֧������3-�й�������4-MasterCard��5-PayPal��6-VISA��
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumPayType PayType { get; set; }

        /// <summary>
        /// ������֧�����׺�
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string TradeNo { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TradeTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StoreTime { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime ExpressTime { get; set; }

        /// <summary>
        /// ԭ��
        /// </summary>
        [Required]
        [Column(TypeName = "decimal")]
        public decimal OriginalPrice
        { get; set; }

        /// <summary>
        /// ���׽����ۺ��Ӧ���۸�
        /// </summary>
        [Required]
        [Column(TypeName = "decimal")]
        public decimal totalFee { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// ��������ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderExpireTime { get; set; }

        /// <summary>
        /// ����ȡ��ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CancelTime { get; set; }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FinishTime { get; set; }

        /// <summary>
        /// ȡ��ԭ��
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(1024)]
        public string CancelReason { get; set; }


        /// <summary>
        /// �������
        /// </summary>
        [MaxLength(32)]
        public string LogisticNo { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        public EnumLogisticState LogisticState { get; set; }

        /// <summary>
        /// ������˾
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public string LogisticCompanyName { get; set; }

        /// <summary>
        /// �����˵�����
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public string LogisticWayBillNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        /// <summary>
        /// �տ��˺�
        /// </summary>
        public string SellerID
        { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string OrgnazitionID { get; set; }

        /// <summary>
        /// �Ƿ�������
        /// </summary>
        [Column(TypeName = "bit")]
        public bool IsEvaluated { get; set; }
    }


}
