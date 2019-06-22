import java.util.ArrayList;

public class MainClass {

	public static void main(String[] args) {
	   //  AnimalFactory animalFactory = new AnimalFactory();

	      //get an object of Circle and call its draw method.
	     // Animal cat = animalFactory.getAnimal("CAT");
	      //cat.eats();
	      //cat.sleep();

	      //get an object of Rectangle and call its draw method.
	      //Animal cow = animalFactory.getAnimal("COW");
	      //cow.eats();
	      //cow.sleep();

	      //get an object of Square and call its draw method.
	      //Animal bird = animalFactory.getAnimal("BIRD");
	      //bird.eats();
	      //bird.sleep();
	   //}
	
		
		
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

	


