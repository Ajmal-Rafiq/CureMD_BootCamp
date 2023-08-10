package Lab1;

import java.util.Scanner;

public class duplicate {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);

	    System.out.print("Enter Word: ");
		String input =scanner.nextLine();
		
		char[] uniqueChar= new char[input.length()];
		int[] frequency = new int[input.length()];
		
		int count =0;
		String combine ="";
		char[] Chars = new char[input.length()];
		
		for (int i =0;i<input.length();i++) {
			
			Chars[i] = input.charAt(i); 
			
		}
		
		 for ( char Char:Chars)
		 {
		
			 boolean found = false;
			 for (int j=0; j<count;j++ )
			 {
			 
				 if(uniqueChar[j]==Char)
				 {
				 
				 frequency[j]++;
				 found =true;
				 break;
				 }
			 }
			 
			 if(!found) 
			 {
				 uniqueChar[count]= Char;
				 frequency [count]= 1;
				 count++;
				
			 }
			 
		 }
		 
		 for(int i =0;i<uniqueChar.length;i++) {
			 
			 combine +=uniqueChar[i];
			 
		 }
		
		
		 
		 System.out.println(combine);
		 
		
		 scanner.close();
		
	}

}
