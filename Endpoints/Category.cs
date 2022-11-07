using AmassWebApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace AmassWebApi.Endpoints
{
    public static class Category
    {
        //Extension class
        public static void Map(this WebApplication app)
        {
            app.MapGet("/Categories", List);
        }
        public static async Task<IResult> List(AmassDb db)
        {
            var res = await db.Categories.ToListAsync();
            return Results.Ok(res);
        }
    }
}
