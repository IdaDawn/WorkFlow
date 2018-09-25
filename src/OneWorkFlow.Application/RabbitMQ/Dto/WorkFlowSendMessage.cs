using System;
using System.Collections.Generic;
using System.Text;

namespace OneWorkFlow.RabbitMQ.Dto
{
    public class WorkFlowSendMessage
    {
        /// <summary>
        /// 外键
        /// </summary>
        public string RId { get; set; }
        /// <summary>
        /// 操作
        /// </summary>
        public int FlowOpation { get; set; }
    }
}
