
public class AnimalFactory {
	
	//use getShape method to get object of type shape 
	   public Animal getAnimal(String animalType){
	      if(animalType == null){
	         return null;
	      }		
	      if(animalType.equalsIgnoreCase("CAT")){
	         return new Cat();
	         
	      } else if(animalType.equalsIgnoreCase("COW")){
	         return new Cow();
	         
	      } else if(animalType.equalsIgnoreCase("BIRD")){
	         return new Bird();
	      }
	      
	      return null;
	   }
	}

