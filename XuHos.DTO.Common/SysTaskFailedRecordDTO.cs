using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.BLL.Sys
{

    public class SysTaskFailedRecordDTO
    {

        public string SysTaskFailedID { get; set; }

        /// <summary>
        /// ����ʧ�ܵ�ģ��
        /// </summary>
        public EnumTaskFailedModule Module { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// ҵ��ID
        /// </summary>
        public string ServiceID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Param { get; set; }

        /// <summary>
        /// ����ʧ�ܴ���
        /// </summary>
        public int FailedCount { get; set; }

    }

  
}
