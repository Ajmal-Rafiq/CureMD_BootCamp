package Lab1;
import java.util.Scanner;
public class abbreviations {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

	    System.out.print("Enter your full name: ");
	    String fullName = scanner.nextLine();

	    // Split the full name into individual names
	    String[] names = fullName.split(" ");

	    // Get the last name (assuming it is the last element in the 'names' array)
	    String lastName = names[names.length - 1];

	    // Initialize the abbreviated name with the first character of the first name
	    StringBuilder abbreviatedName = new StringBuilder(String.valueOf(names[0].charAt(0))+".");

	    // Loop through the middle names and append their first characters to the abbreviation
	    for (int i = 1; i < names.length - 1; i++) {
	        abbreviatedName.append(names[i].charAt(0)).append(".");
	    }
	 // Append the last name to the abbreviation
	    abbreviatedName.append(lastName);

	    // Display the final abbreviated name
	    System.out.println("Abbreviated name: " + abbreviatedName);
		
	    scanner.close();
		
		}
	
	
	
}
