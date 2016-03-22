using System;

public class CoinManager : Singleton<CoinManager> {
	protected CoinManager () {} 

	public int creditCount = 0;
}

