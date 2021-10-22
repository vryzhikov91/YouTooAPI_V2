using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.OpenApi.Models;
using SignalRSwaggerGen.Attributes;

namespace YouTooAPI_V2.WebSocketHubs
{
    [SignalRHub(path: "/hubs/ChatHub")]
    public class ChatHub : Hub
    {
        [SignalRMethod(name: "Get message", operationType: OperationType.Get)]
        public Task<List<ChatMessageDto>> GetChatMessages(int conversationId, int anchorId)
        {
            throw new NotImplementedException();
        }

        [SignalRMethod(name: "Update", operationType: OperationType.Put)]
        public Task Update(ChatMessageDto chatMessage, int conversationId,
             int anchorId)
        {
            throw new NotImplementedException();
        }
        
        [SignalRMethod(name: "AddMessage", operationType: OperationType.Post)]
        public Task NewChatMessage(ChatMessageDto chatMessage,  int conversationId, int anchorId)
        {
            throw new NotImplementedException();
        }

        public class ChatMessageDto
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public string Code { get; set; }
            public int ConversationId { get; set; }
            public int UserProfileId { get; set; }
            public DateTime Date { get; set; }
            public int MemberIds { get; set; }
        }
    }
}