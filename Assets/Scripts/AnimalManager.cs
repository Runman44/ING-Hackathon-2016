using System;

public class AnimalManager : Singleton<AnimalManager> {
	protected AnimalManager () {} 

	public int creditCount = 0;
}

