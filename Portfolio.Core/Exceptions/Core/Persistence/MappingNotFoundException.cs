using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Exceptions
{
    public class MappingNotFoundException : Exception
    {
        public Type MappingType { get; set; }
        public object Id { get; set; }

        public MappingNotFoundException() : base() { }

        public MappingNotFoundException(Type mappingType) : this(mappingType, null, null) { }
        public MappingNotFoundException(Type mappingType, object id) : this(mappingType, id, null) { }
        public MappingNotFoundException(Type mappingType, object id, Exception innerException) : base(
          id == null ? $"There is no such an entity given given id. Entity type: {mappingType.FullName}" :
                       $"There is no such an entity. Entity type: {mappingType.FullName}, id: {id}", innerException)
        {
            MappingType = mappingType; Id = id;
        }

        public MappingNotFoundException(string message) : base(message) { }
        public MappingNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    }
}
