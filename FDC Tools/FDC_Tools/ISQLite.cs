using System;
using SQLite;

namespace FDC_Tools
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
