using Entities.Models;

namespace Entities.LinkModels
{
    public class LinkResponseBase
    {
        public LinkCollectionWrapper<Entity> LinkedEntities { get; set; }
    }
}