using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduHome.Helpers
{
    public static class Extensions
    {
        public static bool IsImage( this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
    }
}
