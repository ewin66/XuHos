﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuHos.EventBus.Events
{
    /// <summary>
    /// 确认扣库存完后
    
    /// 日期：2017年7月29日
    /// </summary>
    public class StockConfirmDeductionedEvent : BaseEvent, IEvent
    {
        public string OrderNo { get; set; }

        public XuHos.Common.Enum.EnumProductType OrderType { get; set; }

        public string OrderOutID { get; set; }
    }
}
