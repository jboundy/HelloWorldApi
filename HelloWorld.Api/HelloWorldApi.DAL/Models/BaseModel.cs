using System;
using System.Data.Entity;

namespace HelloWorldApi.DAL.Models
{
    public class BaseModel
    {
        public static void Build(DbModelBuilder builder, Type type)
        {
            builder.RegisterEntityType(type);
        }
    }
}
