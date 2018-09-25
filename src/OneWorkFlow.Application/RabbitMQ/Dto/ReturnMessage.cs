using System;
using System.Collections.Generic;
using System.Text;

namespace OneWorkFlow.RabbitMQ.Dto
{
    /// <summary>
    /// 返回消息
    /// </summary>
    public class ReturnMessage
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 按钮信息
        /// </summary>
        public string Buttons { get; set; }
    }
}
