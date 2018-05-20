using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.DTO
{
    /// <summary>
    /// ҽԺ����
    /// </summary>
    public partial class HospitalDepartmentDTO
    {

        /// <summary>
        /// ����ID
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// ҽԺID
        /// </summary>
        public string HospitalID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public string Intro { get; set; }   
        
        public HospitalDto Hospital { get; set; }     

        /// <summary>
        /// ҽԺҽ��
        /// </summary>
        public List<DoctorDto> Doctors { get; set; }

        /// <summary>
        /// ���ϵͳ���ݹ���
        /// </summary>
        public ConversationExternalDTO ConversationExternals { get; set; }
    }
}
