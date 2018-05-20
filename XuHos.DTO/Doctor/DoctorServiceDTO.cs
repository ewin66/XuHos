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
    /// ҽ���۸����
    /// </summary>
    public partial class DoctorServiceDTO
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public string ServiceID { get; set; }

        /// <summary>
        /// ҽ��ID
        /// </summary>
        public string DoctorID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public EnumDoctorServiceType ServiceType { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public string ServiceTypeName
        {
            get
            {
                return this.ServiceType.GetEnumDescript();
            }
        }

        /// <summary>
        /// ���񿪹�(0-�رշ���1-��������)
        /// </summary>
        public int ServiceSwitch { get; set; }

        /// <summary>
        /// ����۸�
        /// </summary>
        public decimal ServicePrice { get; set; }

        public bool HasSchedule { get; set; }
    }
}
