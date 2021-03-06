using RestSharp;

namespace TrelloNet.Internal
{
    internal class CardsAddLabelRequest : CardsRequest
    {
        public CardsAddLabelRequest(ICardId card, Color color)
            : base(card, "labels", Method.POST)
        {
            Guard.NotNull(color, "color");

            this.AddValue(color.ColorName);
        }
    }
}