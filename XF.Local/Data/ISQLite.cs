using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Local.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
