using AmassWebApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace AmassWebApi.Endpoints
{
    public static class Log
    {
        public static void Map(this WebApplication app)
        {
            app.MapGet("/Log", DoLog);
        }
        public static async Task<IResult> DoLog(AmassDb db, string msg)
        {
            string sql = @$"

                insert MizerCom..Log(msg) values('{msg}')
                select @@IDENTITY 

            ";

            var res = await db.Database.ExecuteSqlRawAsync(sql);
            return Results.Ok(res);
        }
    }
}
