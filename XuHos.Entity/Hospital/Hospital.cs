using XuHos.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{

    public partial class Hospital : AuditableEntity
    {
        public Hospital()
        {
        }

        /// <summary>
        /// ҽԺID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string HospitalID { get; set; }

        /// <summary>
        /// ҽԺ����
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string HospitalName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(4000)]
        public string Intro { get; set; }

        /// <summary>
        /// ���֤
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string License { get; set; }

        /// <summary>
        /// Logo��ַ
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Address { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(10)]
        public string AreaName { get; set; }

        /// <summary>
        /// �곤����
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(32)]
        public string DrugstoreManageName { get; set; }

        /// <summary>
        /// �곤/�ŵ�绰
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(16)]
        public string Mobile { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Longitude { get; set; }

        /// <summary>
        /// γ��
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Latitude { get; set; }

        /// <summary>
        /// �ʱ�
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        public string PostCode { get; set; }

        /// <summary>
        /// �绰
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string Telephone { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string Email { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Column(TypeName = "int")]
        public EnumOrgType OrgType { get; set; }

        /// <summary>
        /// �㼶
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// �㼶·��
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Path { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string ParentID { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// �б�ͼƬ
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string ListImageUrl { get; set; }

        /// <summary>
        /// �Ƿ���Webǰ����ʾ
        /// </summary>
        public bool IsShowInWeb { get; set; }

        /// <summary>
        /// �Ƿ�Ϊ�������� �û�������Դ��ʶ
        /// </summary>
        public bool IsStandalone { get; set; }

        /// <summary>
        /// �Ƿ�������� (ҽ�ƹ�)
        /// </summary>
        public bool IsCooperation { get; set; }

        /// <summary>
        /// �Ƿ����Լ�����ʹ���ǻ�ҩ��ҩƷ
        /// </summary>
        public bool IsUseWisdom { get; set; }
        
        /// <summary>
        /// ����·��
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string Mp4Url { get; set; }

        /// <summary>
        /// ����Ԥ��ͼ
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string Mp4PreviewUrl { get; set; }

        /// <summary>
        /// �����ǻ�ҩ������ID������ҽԺID ���� �Լ����� ��ʹ���ǻ�ҩ����ҩ��Ϊ�գ�
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string ChannelID { get; set; }

        /// <summary>
        /// ��ҳ������ʽ
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string HomePageTheme { get; set; }

        /// <summary>
        /// ����ʡ��ֱϽ��
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string ProvinceID { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string CityID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string AreaID { get; set; }

        /// <summary>
        /// �Ƿ�ʹ���ܵ�ҩƷ
        /// </summary>
        [Column(TypeName = "bit")]
        public bool IsUseParentOrgDrug { get; set; }
    }
}
