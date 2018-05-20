using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    public class User : AuditableEntity, IUserBaseEntity
    {
        public User()
        {
            //Score = 0;
            //Star = 1;
            //Comment = 0;
            //Good = 0;
            //Fans = 0;
            //Grade = 1;
            //Checked = 1;
            RegTime = DateTime.Now;
            CancelTime = DateTime.Now;
            UserState =  EnumUserState.Disabled;
            UserLevel =  0;
            OrgCode = "";
            UserAccount = "";
        }


        /// <summary>
        /// �û�ID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserID {
            get;
            set; }

        /// <summary>
        /// �˺�
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserAccount {
            get;
            set; }

        /// <summary>
        /// �û�������
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(64)]
        public string UserCNName { get; set; }

        /// <summary>
        /// �û�Ӣ����
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserENName { get; set; }

        /// <summary>
        /// �û�����(0-����Ա��1-���ߡ�2-ҽ��)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public Common.Enum.EnumUserType UserType { get; set; }

        /// <summary>
        /// �ֻ�����
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(16)]
        public string Mobile { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string Email { get; set; }

        /// <summary>
        /// ��¼����
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string Password { get; set; }

        /// <summary>
        /// ͷ��·��
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string PhotoUrl { get; set; }

        /// <summary>
        /// ע��ʱ��
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime RegTime { get; set; }

        /// <summary>
        /// ע��ʱ��
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CancelTime { get; set; }

        /// <summary>
        /// �û�״̬(-1=δ����,0-������1-���ᡢ2-����)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public EnumUserState UserState { get; set; }

        /// <summary>
        /// �û�����(0-��ͨ�û���10 ���� Vip�ȼ�)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int UserLevel { get; set; }

        /// <summary>
        /// �������� ,  ֻ��ʶ�û�ע����Դ  ��Ҫ�ͻ�����Ա������ҽ��������������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string OrgCode { get; set; }

    }
}
