using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Services
{
    public abstract class AbstractService<TObject> where TObject : class
    {
        protected IQueryable<TObject> query;
        protected Dictionary<string, object> search_options;

        // Default search params
        protected Dictionary<string, object> searchable_fields_equals = new Dictionary<string, object>();
        protected Dictionary<string, object> searchable_fields_likes = new Dictionary<string, object>();

        // Default order params
        protected string order_by = "id";
        protected string order_direction = "asc";



        protected void AddOrderOptions()
        {
            string order_by = search_options.ContainsKey("order_by") ? search_options["order_by"].ToString() : this.order_by;
            string order_direction = search_options.ContainsKey("order_direction") ? search_options["order_direction"].ToString() : this.order_direction;
        }

        protected void AddRelationships()
        {
            if (search_options.ContainsKey("with"))
            {

            }

            if (search_options.ContainsKey("with_count"))
            {
                string[] with_count = search_options["with_count"] as string[];
            }
        }

        protected void AddStandardSearchOptions()
        {
            foreach (KeyValuePair<string, object> field in searchable_fields_equals)
            {
                if (IsSearchOptionsValueSet(field.Value))
                {
                    
                }
            }

            foreach (KeyValuePair<string, object> field in searchable_fields_likes)
            {
                if (IsSearchOptionsValueSet(field.Value))
                {
                   
                }
            }
        }

        protected virtual IQueryable<TObject> GetQueryable()
        {
            return null;
        }

        protected bool IsSearchOptionsValueSet(object value)
        {
            return value != null && !string.IsNullOrEmpty(value.ToString());
        }
    }
}
