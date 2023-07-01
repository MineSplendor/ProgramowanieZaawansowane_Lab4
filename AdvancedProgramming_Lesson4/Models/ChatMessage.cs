using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AdvancedProgramming_Lesson4.Models
{
    
    public class ChatMessage
    {
        public ChatMessage()
        {
        }

        public ChatMessage(string user, string message)
        {
            User = user;
            Message = message;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        
    }
}
