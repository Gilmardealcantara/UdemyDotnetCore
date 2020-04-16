using System;

namespace ITDeveloper.Domain.Entitites
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
