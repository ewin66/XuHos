using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XuHos.DTO.Common
{

    public class SysConfigDTO
    {
        /// <summary>
        /// ���ý�Key
        /// </summary>
        public string ConfigKey { get; set; }

        /// <summary>
        /// ���ý�Value
        /// </summary>
        public string ConfigValue { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }

    }
}
