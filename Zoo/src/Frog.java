
public class Frog implements Animal{
	
	private String name = "Frog";
	
	public String sound() {
        return "Oac-Oac";
    }

    public String eats() {
        return "insects";
    }
    
    public String sleep() {
        return "in the water";
    }

    @Override
    public String getName() {
        return name;
    }


}
