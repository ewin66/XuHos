using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XuHos.Common.Enum;

namespace XuHos.DTO.Common
{
    [Serializable]
    public class SysDrugDTO
    {
        public SysDrugDTO()
        {
        }

        /// <summary>
        /// ҩƷID
        /// </summary>
        public string DrugID { get; set; }

        /// <summary>
        /// ҩƷ����
        /// </summary>
        public string DrugCode { get; set; }

        /// <summary>
        /// ҩƷ����
        /// </summary>
        public string DrugName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// ҩƷ��Ч��
        /// </summary>
        public string DrugExpiryDay { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string BatchNO { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string FactoryName { get; set; }

        /// <summary>
        /// ƴ������
        /// </summary>
        public string PinYinName { get; set; }

        /// <summary>
        /// ��ɱ��
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int TotalDose { get; set; }

        /// <summary>
        /// ������λ
        /// </summary>
        public string DoseUnit { get; set; }

        /// <summary>
        /// ��λ
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// ҩƷ����
        /// </summary>
        public EnumDrugType DrugType { get; set; }

        /// <summary>
        /// ҩ��ID
        /// </summary>
        public string PharmacyID { get; set; }

        /// <summary>
        /// ��ҩ����
        /// </summary>
        public string PharmacyName { get; set; }

        /// <summary>
        /// ҩ����
        /// </summary>
        public string TopPharmacyName { get; set; }

        /// <summary>
        /// ҩ��ҩƷID
        /// </summary>
        public string PharmacyDrugID { get; set; }

        /// <summary>
        /// �Ƿ�ͣ�� 0û��ͣ��,1ͣ��
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// �Ƿ񴦷�ҩ
        /// </summary>
        public bool IsPrescribed { get; set; }

        /// <summary>
        /// ҽ��ҩƷ
        /// </summary>
        public bool IsInsured { get; set; }

        /// <summary>
        /// �Ƿ������
        /// </summary>
        public bool HasEphedrine { get; set; }

        /// <summary>
        /// �Ƿ���Ҫ����ǩ
        /// </summary>
        public bool IsNeedSign { get; set; }

        public decimal OriginalPrice { get; set; }

        public decimal ChannelPrice { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string ProducePlace { get; set; }
        /// <summary>
        /// ����״̬ 0-�޴�1-�д�
        /// </summary>
        public int ValidateState { get; set; }

        /// <summary>
        /// ����ʱ��֤������Ϣ
        /// </summary>
        public string ImportErrorMsg { get; set; }

        /// <summary>
        /// ����ʱ��֤������Ϣ
        /// </summary>
        public bool IsRepeat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DrugOrgMapID { get; set; }

        public string ChannelID { get; set; }
        public int ChannelVersionNo { get; set; }
        

        /// <summary>
        /// �Ƿ��Ƽ�
        /// </summary>
        public bool IsRecommend
        {
            get; set;
        }
    }
}