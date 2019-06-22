
public class Zoo {

	public static void main(String[] args) {
		
		        for (PriceFactory.PriceType priceType : PriceFactory.PriceType.values()) {
		            System.out.println("Price for " + priceType + " is " + PriceFactory.createPrice(priceType).getPrice());
		        }
		    }
}
