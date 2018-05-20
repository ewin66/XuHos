using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{

    public class UserMember : AuditableEntity
    {
        public UserMember()
        {
            IDType = Common.Enum.EnumUserCardType.IDCard;
            Birthday = "";
            MemberName = "";
            Mobile = "";
            Address = "";
            Email = "";
            PostCode = "";
            //UserID = "";
        }
        /// <summary>
        /// ��ԱID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string MemberID { get; set; }

        /// <summary>
        /// �û�ID
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string UserID { get; set; }

        /// <summary>
        /// ��Ա����
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(32)]
        public string MemberName { get; set; }

        /// <summary>
        /// ��ϵ��0-�Լ���1-��ż��2-���ס�3-ĸ�ס�4-���ӡ�5Ů����6-������
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public Common.Enum.EnumUserRelation Relation { get; set; }

        /// <summary>
        /// �Ա�0-�С�1-Ů��2-δ֪��
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public Common.Enum.EnumUserGender Gender { get; set; }

        /// <summary>
        /// �������(0-δ�顢1-�ѻ顢2-δ֪)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public Common.Enum.EnumUserMaritalStatus Marriage { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10), MinLength(10)]
        public string Birthday { get; set; }

        /// <summary>
        /// �ֻ�����
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Mobile { get; set; }

        /// <summary>
        /// ֤������(0-���֤,1-���񻧿ڱ�,2-����,3-����֤,4-��ʻ֤,5-�۰�ͨ��֤,6-̨��ͨ��֤,7-�۰�̨���֤,99-����)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public XuHos.Common.Enum.EnumUserCardType IDType { get; set; }

        /// <summary>
        /// ֤������
        /// </summary>
        //[Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string IDNumber { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Nationality { get; set; }

        /// <summary>
        /// ʡ
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Province { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string ProvinceRegionID { get; set; }


        /// <summary>
        /// ��
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string City { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string CityRegionID { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string District { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DistrictRegionID { get; set; }

        /// <summary>
        /// �壬�ֵ�
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string TownRegionID { get; set; }

        /// <summary>
        /// �壬��ί
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Village { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string VillageRegionID { get; set; }

        /// <summary>
        /// �Ƿ��й���ʷ
        /// </summary>
        public bool IsAllergic { get; set; }

        /// <summary>
        /// ������ʷ��ע
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string AllergicRemark { get; set; }


        /// <summary>
        /// ��ַ
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Address { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string Email { get; set; }

        /// <summary>
        /// �ʱ�
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        public string PostCode { get; set; }

        /// <summary>
        /// �Ƿ�Ĭ�Ͼ�����(0-��Ĭ�ϡ�1-Ĭ�ϣ�һ���û���ֻ��һ��Ĭ�Ͼ�����)
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Remark { get; set; }

        //public virtual User User { get; set; }


        /// <summary>
        /// ����
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string Ethnic { get; set; }

        /// <summary>
        /// ְҵ
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public string Occupation { get; set; }

        /// <summary>
        /// ������λ
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public string CompanyName { get; set; }

    }

}
