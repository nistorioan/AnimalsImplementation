import java.util.ArrayList;

public class MainClass {

	public static void main(String[] args) {

		
		
		  System.out.println( "The ZOO has the following animals: ");
		ArrayList<Animal> animalsList = new ArrayList<>();
		animalsList.add(new Cat());
		animalsList.add(new Cow());
		animalsList.add(new Bird()); 
		animalsList.add(new Frog()); 

        for (int position = 0; position < animalsList.size(); position++) {
            Animal animals = animalsList.get(position);
            System.out.println(animals.getName() +" make " + animals.sound() + " eats " + animals.eats() + " and sleep " + animals.sleep());
        }
	}
}

	


