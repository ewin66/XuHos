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
    public class RequestNoticeMessageDTO
    {
        /// <summary>
        /// ��ϢID
        /// </summary>
        public string MessageID { get; set; }

        /// <summary>
        /// ֪ͨ����
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ժҪ
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// ֪ͨ����
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// �û�Ӧ�ö�(ҽ���ˣ����߶�)
        /// </summary>
        public EnumUserNoticeType UserNoticeType { get; set; }

        /// <summary>
        /// һ����Ϣ����(ҽ���ˣ�ϵͳ���桢������Ϣ��ҵ����Ϣ�����߶ˣ�ϵͳ���桢������Ϣ)
        /// </summary>
        public EnumNoticeFirstType NoticeFirstType { get; set; }

        /// <summary>
        /// ������Ϣ����
        /// </summary>
        public EnumNoticeSecondType NoticeSecondType { get; set; }

        /// <summary>
        /// ֪ͨ����
        /// </summary>
        public DateTime NoticeDate { get; set; }

        /// <summary>
        /// �����Ϣ����ҵ��ҳ��Ĳ���
        /// </summary>
        public string PageArgs { get; set; }

        public string ClientName { get; set; }
    }



}
