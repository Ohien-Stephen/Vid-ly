using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vid_ly.Data;
using Vid_ly.Data.Models;

namespace Vid_ly.Services
{
    public class ChannelService : IChannelService
    {
        private readonly ApplicationDbContext _context;

        public ChannelService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Channel>> GetAllChannels() =>
            await _context.Channels.ToListAsync();

        public async Task<Channel> GetChannelById(int id) =>
            await _context.Channels.FirstOrDefaultAsync(x => x.Id == id);

        public async Task CreateChannel(Channel channel)
        {
            await _context.Channels.AddAsync(channel);
        }

        public void UpdateChannel(Channel channel)
        {
            _context.Channels.Update(channel);
        }

        public async Task RemoveChannel(int id)
        {
            var channel = await _context.Channels.FirstOrDefaultAsync(x => x.Id == id);
            if (channel != null)
            {
                _context.Channels.Remove(channel);
            }

        }

        public async Task<bool> SaveChanges() => 
            (await _context.SaveChangesAsync() >= 1);

    }
}
