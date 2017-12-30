using GeoLibrary.Core;

namespace GeoLibrary.Data.Entities
{
    public class State : IIdentifiableEntity
    {
        public int StateId { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public bool IsPrimaryState { get; set; }
        public string SSCode { get; set; }

        public int EntityId
        {
            get { return StateId; }
            set { StateId = value; }
        }
    }
}
