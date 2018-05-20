using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.DTO.Common
{

    public class SysDictDTO
    {
        /// <summary>
        /// �ֵ�ID
        /// </summary>
        public string DicID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public string DictTypeID { get; set; }

        /// <summary>
        /// �ֵ���
        /// </summary>
        public string DicCode { get; set; }

        /// <summary>
        /// �ֵ�������
        /// </summary>
        public string CNName { get; set; }

        /// <summary>
        /// �ֵ�Ӣ����
        /// </summary>
        public string ENName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }

        public SysDictTypeDTO SysDictType { get; set; }

    }

    public class SysDictTypeDTO
    {
        /// <summary>
        /// ����ID
        /// </summary>
        public string DictTypeID { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public string DictTypeName { get; set; }
    }
}
