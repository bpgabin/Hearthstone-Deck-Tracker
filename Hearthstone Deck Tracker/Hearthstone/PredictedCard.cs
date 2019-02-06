namespace Hearthstone_Deck_Tracker.Hearthstone
{
	public class PredictedCard
	{
		public string CardId { get; set; }
		public int Count { get; set; }
		public int Turn { get; set; }

		public PredictedCard(string cardId, int turn) : this(cardId, turn, 1)
		{

		}

		public PredictedCard(string cardId, int turn, int count)
		{
			CardId = cardId;
			Count = count;
			Turn = turn;
		}
	}
}
