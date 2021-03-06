using RestSharp;

namespace TrelloNet.Internal
{
    internal class CardsRemoveLabelRequest : CardsRequest
    {
        public CardsRemoveLabelRequest(ICardId card, Color color)
            : base(card, "labels/{color}", Method.DELETE)
        {
            Guard.NotNull(color, "color");

            AddParameter("color", color.ColorName, ParameterType.UrlSegment);
        }
    }
}