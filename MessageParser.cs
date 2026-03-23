using System.Text.Json;
using NetworkProgramming.Models;

namespace NetworkProgramming.Network
{
    public static class MessageParser
    {
        public static string Serialize(Message msg)
        {
            return JsonSerializer.Serialize(msg);
        }

        public static Message Deserialize(string json)
        {
            return JsonSerializer.Deserialize<Message>(json);
        }
    }
}