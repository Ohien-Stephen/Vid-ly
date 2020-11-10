using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vid_ly.Data;
using Vid_ly.Data.Models;

namespace Vid_ly.Services
{
    public class VideoService : IVideoService
    {
        private readonly ApplicationDbContext _context;

        public VideoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Video>> GetAllVideos() =>
            await _context.Videos.AsNoTracking().ToListAsync();

        public async Task<Video> GetVideoById(Guid id) =>
            await _context.Videos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task CreateVideo(Video video)
        {
            await _context.Videos.AddAsync(video);
        }
        public void UpdateVideo(Video video)
        {
            _context.Videos.Update(video);
        }

        public async Task RemoveVideo(Guid id)
        {
            var video = await _context.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (video != null)
            {
                _context.Videos.Remove(video);
            }

        }

        public async Task<bool> SaveChanges() => 
            await _context.SaveChangesAsync() >= 1;

    }
}
