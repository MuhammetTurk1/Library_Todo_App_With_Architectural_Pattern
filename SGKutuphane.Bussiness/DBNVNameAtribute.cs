using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness
{
    public class DBNVNameAtribute : Attribute
    {
        public DBNVNameAtribute()
        {

        }
        public DBNVNameAtribute(string tableName)
        {
            this.TableName = tableName;
        }
        public DBNVNameAtribute(string tableName,string viewName)
        {
            this.TableName = tableName;
            this.ViewName = viewName;
        }
        public string ViewName { get; set; }
        public string TableName { get; set; }
    }
}
