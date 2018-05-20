using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XuHos.Common;
using XuHos.Common.Enum;
using XuHos.Extensions;

namespace XuHos.DTO
{
    /// <summary>
    /// ����ҽ��
    /// </summary>
    public partial class DoctorTriageDTO
    {
        /// <summary>
        /// ԤԼID
        /// </summary>
        public string OPDRegisterID { get; set; }

        /// <summary>
        /// ����ҽ��ID
        /// </summary>
        public string TriageDoctorID { get; set; }

        /// <summary>
        /// ����״̬��0�ޣ�1�����2�����У�3�ѷ��
        /// </summary>
        public EnumTriageStatus TriageStatus { get; set; }

        /// <summary>
        /// �Ƿ�Ҫ��������ϵͳ����
        /// </summary>
        public bool IsToGuidance { get; set; }

    }
}
