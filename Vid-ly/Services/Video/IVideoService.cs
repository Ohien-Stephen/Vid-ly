using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vid_ly.Data.Models;


namespace Vid_ly.Services
{
    public interface IVideoService
    {
        Task<IEnumerable<Video>> GetAllVideos();
        Task<Video> GetVideoById(Guid id);
        Task CreateVideo(Video video);
        void UpdateVideo(Video video);
        Task RemoveVideo(Guid id);
        Task<bool> SaveChanges();
    }
}
