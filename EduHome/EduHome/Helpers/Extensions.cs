using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduHome.Helpers
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
        public static bool IsOrder1Mb(this IFormFile file)
        {
            return file.Length/1024 > 1024;
        }
    }
}
