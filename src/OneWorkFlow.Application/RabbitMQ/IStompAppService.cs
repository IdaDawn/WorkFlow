using Abp.Application.Services;
using OneWorkFlow.RabbitMQ.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OneWorkFlow.RabbitMQ
{
    public interface IStompAppService : IApplicationService
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        ReturnMessage SendMessage(WorkFlowSendMessage message);
        ReturnMessage ReceiveMessage(WorkFlowSendMessage message);
    }
}
