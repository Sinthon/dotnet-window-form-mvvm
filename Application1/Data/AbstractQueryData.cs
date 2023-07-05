using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Data
{
    public abstract class AbstractQueryData
    {
        protected IDbConnection connection;
        protected Array searchOptions;

        // Default search params
        protected Array searchFieldEqual;
        protected Array searchFieldLike;


        // Default order params
        protected string orderBy = "Id";
        protected string orderDirection = "ASC";

        public IEnumerable Handle<TObject>(Array searchOptions)
        {
            this.searchOptions = searchOptions;
            this.connection = this.getConnection();

            return new List<TObject>();
        }

        abstract protected IDbConnection getConnection();
    }
}
