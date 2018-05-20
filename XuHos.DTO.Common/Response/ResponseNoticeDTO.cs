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
    public class ResponseNoticeDTO
    {
        /// <summary>
        /// ֪ͨID
        /// </summary>
        public string UserNoticeID { get; set; }

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
        /// ֪ͨ����(�û�ID)
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// ֪ͨ����
        /// </summary>
        public DateTime NoticeDate { get; set; }

        /// <summary>
        /// �Ƿ��Ѷ�
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// �Ķ�ʱ��
        /// </summary>
        public DateTime? ReadDate { get; set; }

        /// <summary>
        /// �Ķ��նˣ�WEB,IOS,��׿
        /// </summary>
        public string ReadTerminals { get; set; }

        public string PageArgs { get; set; }
        public RequestMessageExtrasConfigDTO AndroidExtrasConfig { get; set; }
        public RequestMessageExtrasConfigDTO IOSExtrasConfig { get; set; }
        public RequestMessageExtrasConfigDTO WebExtrasConfig { get; set; }

    }


}
