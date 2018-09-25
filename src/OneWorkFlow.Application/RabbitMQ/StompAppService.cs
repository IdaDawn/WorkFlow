using Abp.Application.Services;
using OneWorkFlow.RabbitMQ.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OneWorkFlow.RabbitMQ
{
    public class StompAppService : IStompAppService
    {
        public ReturnMessage SendMessage(WorkFlowSendMessage message)
        {
            ReturnMessage returnMsg = new ReturnMessage();
            string msg = Abp.Json.JsonSerializationHelper.SerializeWithType(message, typeof(string));
            if (msg.IndexOf('|') != -1)
            {
                msg = msg.Substring(msg.IndexOf('|') + 1);
                returnMsg.IsSuccess = StompClient.SendMessage(msg);
                returnMsg.Data = "处理成功！";
                return returnMsg;
            }
            else
            {
                returnMsg.IsSuccess = false;
                returnMsg.Data = "处理失败！";
                return returnMsg;
            }
        }

        public ReturnMessage ReceiveMessage(WorkFlowSendMessage message)
        {
            ReturnMessage returnMsg = new ReturnMessage();
            string msg = Abp.Json.JsonSerializationHelper.SerializeWithType(message, typeof(string));
            if (msg.IndexOf('|') != -1)
            {
                msg = msg.Substring(msg.IndexOf('|') + 1);
                returnMsg.IsSuccess = StompClient.ReceiveMessage(msg);
                returnMsg.Data = "处理成功！";
                return returnMsg;
            }
            else
            {
                returnMsg.IsSuccess = false;
                returnMsg.Data = "处理失败！";
                return returnMsg;
            }
        }
    }
}
