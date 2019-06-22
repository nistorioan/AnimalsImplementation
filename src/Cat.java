
public class Cat implements Animal{
	private String name = "Cat";

    
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
