
public class Cat implements Animal{
	private String name = "Cat";
	
	public String sound() {
        return "Meaw";
    }
    
    public String eats() {
        return "mouses";
    }
    
    public String sleep() {
        return "10 hours";
    }

    @Override
    public String getName() {
        return name;
    }

}
