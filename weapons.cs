	public PowerUp weaponPowerUp;
	public  void Main()
	{
		bow = new Weapon();
		weaponPowerUp = new PowerUp();
		bow.ammoCount+=20;
		bow.fireSpell+= weaponPowerUp.powerLevel;
		Console.WriteLine(bow.weaponNames + " has an ammo count of " + bow.ammoCount );
		Console.WriteLine("The spell power has now increased " + bow.fireSpell + " times. ");
	}
}
public class Weapon{
	public int ammoCount = 20;
	public string weaponNames = "bow";
	public float fireSpell = 12.5f;
}	
public class PowerUp{
	public float powerLevel = 3.5f;
}
