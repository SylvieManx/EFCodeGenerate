using System.Collections.Generic;

namespace Microsoft.DbContextPackage.Handlers
{
    public interface ICodeFirstHandler
    {
         void ReverseEngineerCodeFirst(string strCon, List<string> tableNames = null, string savePath = null);
    }
}