using AmassWebApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace AmassWebApi.Endpoints
{
    public static class Income
    {
        //WebApplication Extension class
        public static void Map(this WebApplication app)
        {
            app.MapGet("/Incomes/{category_id}", List);
        }
        public static async Task<IResult> List(AmassDb db, int category_id)
        {
            var res = await db.Incomes.Where( inc => inc.Category_Id == category_id).ToListAsync();
            return Results.Ok(res);
        }
    }
}
