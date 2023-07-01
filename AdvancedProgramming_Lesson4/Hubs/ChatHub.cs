using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Data;
using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.SignalR;

namespace AdvancedProgramming_Lesson4.Hubs
{
    public class ChatHub : Hub
    {
        private readonly MvcContext _context;

        public ChatHub(MvcContext context)
        {
            ChatMessage message = new ChatMessage();
            _context = context;
        }

        public async Task SendMessage(string user, string message)
        {
            var chatMessage = new ChatMessage(user, message);
            _context.Add(chatMessage);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
