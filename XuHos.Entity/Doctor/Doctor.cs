using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.Entity
{
    /// <summary>
    /// ҽ��
    /// </summary>
    public partial class Doctor : AuditableEntity
    {
        public Doctor()
        {
        }
        /// <summary>
        /// �û�ID
        /// </summary>
        [Key, Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DoctorID { get; set; }

        /// <summary>
        /// ҽ������
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(64)]
        public string DoctorName { get; set; }

        /// <summary>
        /// �Ա�0-�С�1-Ů��2-δ֪��
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public XuHos.Common.Enum.EnumUserGender Gender { get; set; }

        /// <summary>
        /// �������(0-δ�顢1-�ѻ顢2-δ֪)
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public XuHos.Common.Enum.EnumUserMaritalStatus Marriage { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Birthday { get; set; }

        /// <summary>
        /// ֤������
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public XuHos.Common.Enum.EnumUserCardType IDType { get; set; }

        /// <summary>
        /// ֤������
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string IDNumber { get; set; }

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
        [MaxLength(6)]
        public string PostCode { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(4000)]
        public string Intro { get; set; }

        /// <summary>
        /// �Ƿ�ר�ң�0-��1-�ǣ�
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool IsExpert { get; set; }

        /// <summary>
        /// �س�
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(1024)]
        public string Specialty { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(16)]
        public string areaCode { get; set; }

        /// <summary>
        /// ҽԺID��û�й�����ҽԺIDĬ��Ϊ0��
        /// </summary>
        [Required]
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
        /// ҽԺ�ȼ�
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string Grade { get; set; }

        /// <summary>
        /// ����ID��û�й����Ŀ���IDĬ��Ϊ0��
        /// </summary>
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(32)]
        public string DepartmentID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// ѧ��
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(64)]
        public string Education { get; set; }

        /// <summary>
        /// ְ��
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(64)]
        public string Title { get; set; }

        /// <summary>
        /// ��������ְ��
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(512)]
        public string Duties { get; set; }

        /// <summary>
        /// ��֤״̬��0-δ��֤��1-��ͨ����2-δͨ����3-��֤�С�4-��������֤�У�
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int CheckState { get; set; }

        /// <summary>
        /// ǩ��ͼƬURL
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(128)]
        public string SignatureURL { get; set; }

        /// <summary>
        /// ҽ��ǩǩ��ͼƬ(base64)
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(4000)]
        public string BJCASignature { get; set; }

        /// <summary>
        /// ҽʦִҵ֤����� 
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(64)]
        public string CertificateNo { get; set; }

        /// <summary>
        /// BJCAҽ��Ψһ��ʶ
        /// </summary>
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string OpenID { get; set; }

        /// <summary>
        /// �Ƿ���ʾ��ǰ��
        /// </summary>
        public bool IsShow { get; set; }

        /// <summary>
        /// ҽ������ 0-������ҽ�� 1-���ִҵҽ�� 2-ִҵҽ��(�ڿ���ҽԺ������) 3-��Ƹҽ��
        /// </summary>
        public int DoctorType { get; set; }

        /// <summary>
        /// ������ǩ����״�ٰ������ٰ���θ�����᳦���ȣ�
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(512)]
        public string DiseaseLabel { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int Sort { get; set; }

        /// <summary>
        /// ҽ����������
        /// </summary>
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string RoomName { get; set; }
    }
}