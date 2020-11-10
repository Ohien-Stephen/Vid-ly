using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vid_ly.Data.Models;

namespace Vid_ly.Services
{
    interface IChannelService
    {
        Task<IEnumerable<Channel>> GetAllChannels();
        Task<Channel> GetChannelById(int id);
        Task CreateChannel(Channel channel);
        void UpdateChannel(Channel channel);
        Task RemoveChannel(int id);
        Task<bool> SaveChanges();
    }
}
