using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using XuHos.Common;
using XuHos.Common.Enum;
using XuHos.Extensions;
namespace XuHos.DTO
{
    public class UserBaseDTO : Common.ImageBaseDTO
    {
        /// <summary>
        /// �û�ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// �˺�
        /// </summary>
        public string UserAccount { get; set; }

        /// <summary>
        /// �û�������
        /// </summary>
        public string UserCNName { get; set; }

        /// <summary>
        /// �û�Ӣ����
        /// </summary>
        public string UserENName { get; set; }

        /// <summary>
        /// �û�����(0-����Ա��1-���ߡ�2-ҽ��)
        /// </summary>
        public EnumUserType UserType { get; set; }

        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Email { get; set; }


        public string _PhotoUrl { get; set; }

        /// <summary>
        /// ͷ��·��
        /// </summary>
        public string PhotoUrl
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_PhotoUrl))
                {
                    if (UserType == EnumUserType.Doctor)
                    {
                        return PaddingUrlPrefix("images/doctor/default.jpg");


                    }
                    else
                    {
                        return PaddingUrlPrefix("images/doctor/default.jpg");
                    }

                }
                else
                {
                    return PaddingUrlPrefix(_PhotoUrl);
                }
            }
            set
            {
                _PhotoUrl = value;
            }
        }
    }
    public class UserDTO : UserBaseDTO
    {

        /// <summary>
        /// �Լ���ϵ�� memberID
        /// </summary>
        public string MemberID { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ֧������
        /// </summary>
        public string PayPassword { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// �Ǽ�
        /// </summary>
        public int Star { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public int Comment { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public int Good { get; set; }

        /// <summary>
        /// ��˿��
        /// </summary>
        public int Fans { get; set; }

        /// <summary>
        /// �ȼ�
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// ��֤
        /// </summary>
        public int Checked { get; set; }

        /// <summary>
        /// ע��ʱ��
        /// </summary>
        public DateTime RegTime { get; set; }

        /// <summary>
        /// ע��ʱ��
        /// </summary>
        public DateTime CancelTime { get; set; }

        /// <summary>
        /// �û�״̬(0-������1-���ᡢ2-����)
        /// </summary>
        public EnumUserState UserState { get; set; }

        /// <summary>
        /// �û�����(0-��ͨ�û���1-��Ա��2-������)
        /// </summary>
        public int UserLevel { get; set; }

        /// <summary>
        /// �һ���������
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// ע���ն�(0-Web��1-��׿��2-IOS)
        /// </summary>
        public string Terminal { get; set; }

        /// <summary>
        /// ����¼ʱ��
        /// </summary>
        public DateTime LastTime { get; set; }


        /// <summary>
        /// �û�Ψһ��ʶ
        /// </summary>
        public int identifier { get; set; }

    }
}
