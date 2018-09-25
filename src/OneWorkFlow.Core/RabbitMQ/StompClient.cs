using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneWorkFlow.RabbitMQ
{
    public class StompClient
    {

        public static bool SendMessage(string message)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                factory.HostName = "47.104.65.81";
                IConnection connection = factory.CreateConnection();
                var channel = connection.CreateModel();
                channel.ExchangeDeclare("workflowsend", "fanout");
                String routingKey = "workflowsend_key";
                channel.BasicPublish("workflowsend", routingKey, null, System.Text.Encoding.Default.GetBytes(message));
                channel.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static bool ReceiveMessage(string message)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                factory.HostName = "47.104.65.81";
                IConnection connection = factory.CreateConnection();
                var channel = connection.CreateModel();
                channel.ExchangeDeclare("workflowreceive", "fanout");
                String routingKey = "workflowreceive_key";
                channel.BasicPublish("workflowreceive", routingKey, null, System.Text.Encoding.Default.GetBytes(message));
                channel.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
