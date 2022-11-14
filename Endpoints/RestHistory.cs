using AmassWebApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace AmassWebApi.Endpoints;

public static class RestHistory
{
    //Extension class
    public static void Map(this WebApplication app)
    {
        app.MapGet("/RestHistory/{UserID}", Get);
    }
    public static async Task<IResult> Get(AmassDb db, int UserID)
    {
        var res = await db.Database.ExecuteSqlRawAsync("report_DailyUserRests @UserID", UserID);
        return Results.Ok(res);
    }
}
