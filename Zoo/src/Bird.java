
public class Bird implements Animal{
	private String name = "Bird";
	
	public String sound() {
        return "Cip-Cip";
    }
    
    public String eats() {
        return "cereals";
    }
    
    public String sleep() {
        return "in the tree";
    }

    @Override
    public String getName() {
        return name;
    }


}
