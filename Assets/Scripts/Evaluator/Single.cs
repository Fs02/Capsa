﻿using System.Collections;

public class Single : IEvaluator<Single> {
	public override void Evaluate(int index) {
		if (filter(cardSet[index])) {
			var set = new CardSet();
			set.Add(cardSet[index]);
			results.Add(new PokerHand(set, set[0], PokerHand.CombinationType.Single));
		}
	}
}