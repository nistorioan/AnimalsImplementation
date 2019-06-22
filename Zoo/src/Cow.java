
public class Cow implements Animal{
	private String name = "Cow";
	
	public String sound() {
        return "Muuu";
    }

    public String eats() {
        return "grass";
    }
    
    public String sleep() {
        return "in the stable";
    }

    @Override
    public String getName() {
        return name;
    }


}
