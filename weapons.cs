	public PowerUp weaponPowerUp;#name
	public  void Main()
	{
		bow = new Weapon();
		weaponPowerUp = new PowerUp();
		bow.ammoCount+=20; #adds 20 more to ammo
		bow.fireSpell+= weaponPowerUp.powerLevel;#adds more power to starting amount
		Console.WriteLine(bow.weaponNames + " has an ammo count of " + bow.ammoCount );#prints the amount and string
		Console.WriteLine("The spell power has now increased " + bow.fireSpell + " times. ");#same printing 
	}
}
public class Weapon{
	public int ammoCount = 20;#starting amount of ammo
	public string weaponNames = "bow";
	public float fireSpell = 12.5f;#starting amount of fire spell level
}	
public class PowerUp{
	public float powerLevel = 3.5f;
}
