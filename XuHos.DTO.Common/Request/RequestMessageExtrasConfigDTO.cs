using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XuHos.Common;
using XuHos.Common.Enum;
using XuHos.Extensions;
using XuHos.DTO.Common;

namespace XuHos.DTO.Common
{
    public class RequestMessageExtrasConfigDTO
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ExtrasConfigID { get; set; }

        /// <summary>
        /// �ն�����
        /// </summary>
        public EnumTerminalType TerminalType { get; set; }

        /// <summary>
        /// ������Ϣ����
        /// </summary>
        public EnumNoticeSecondType MsgType { get; set; }

        /// <summary>
        /// ֪ͨģ��
        /// </summary>
        public string MsgTitle { get; set; }

        /// <summary>
        /// ��תҳ��
        /// </summary>
        public string PageUrl { get; set; }

        /// <summary>
        /// //ҳ�����ͣ�HTML/Native��
        /// </summary>
        public string PageType { get; set; }

        /// <summary>
        /// ��Ŀ��(_Blank/_Parent/_Self/_Top)
        /// </summary>
        public string PageTarget { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public object PageArgs { get; set; }

    }


    public class RequestMessageExtrasDTO
    {
        public string MsgID { get; set; }

        public List<RequestMessageExtrasConfigDTO> MsgBody { get; set; }
    }

}
