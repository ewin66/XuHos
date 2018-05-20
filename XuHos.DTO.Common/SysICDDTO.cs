using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.DTO.Common
{

    public class SysICDDTO
    {
        /// <summary>
        /// ICDID
        /// </summary>
        public string ICDID { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string DiseaseCode { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string DiseaseName { get; set; }

        /// <summary>
        /// ����Ӣ������
        /// </summary>
        public string DiseaseEnName { get; set; }

        /// <summary>
        /// ƴ������
        /// </summary>
        public string PinYinCode { get; set; }

        /// <summary>
        /// ���ͱ���
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// ��������(1-��ҽ������2-��ҽ����)
        /// </summary>
        public XuHos.Common.Enum.EnumDiagnoseType ICDType { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
